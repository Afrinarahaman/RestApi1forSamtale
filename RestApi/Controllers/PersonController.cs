using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        //List of persons information
        public static List<Person> persons = new List<Person>()
        {
            new Person(1, "Ida", "Jensen", 56, "Female", 55.676,12.568,true),
            new Person(2,"Oscar", "Hansen", 40, "Male", 59.334, 18.063, false ),
            new Person(3, "Ida3", "Jensen", 56, "Female", 55.676,12.568,true),
            new Person(4,"Oscar4", "Hansen", 40, "Male", 59.334, 18.063, false )
        };

        //Getting all peoples information
        [HttpGet]
        public List<Person> getAllPersons()
        {

            return persons;

        }

        //Getting that specific persons information whose id has been given
        [HttpGet("{id}")]
        public Person getPersonById(int id)
        {
            Person person = persons.Find(p => p.Id == id);

            return person;
        }

        //Adding person information in the system
        [HttpPost]
        public List<Person> addNewPerson([FromBody] Person person)
        {
            person.Id = persons.Count+1;
            persons.Add(person);
            return persons;
        }

        //Updating the survivours last location
     
        //

       [HttpPut]
       [Route("/LastLocation")]
        public int updateLastLocation([FromBody] Person person)
        {
            Person personToUpdate = persons.Find(f => f.Id == person.Id);
            if (personToUpdate != null && personToUpdate.Flag)
            {
                personToUpdate.LastLocationLatitude = person.LastLocationLatitude;
                personToUpdate.LastLocationLongitude = person.LastLocationLongitude;
                return personToUpdate.Id;
            }
            return 0;
        }

        //Search on lastname in order to find or track down relatives and check if they're deceased

        [HttpGet]
        [Route("/Family")]
        public List<Person> getPersonByLastName(string lastName)
        {
            return persons.Where(p => p.LastName.Equals(lastName)).ToList();
        }

        //Percentage of survivors
        [HttpGet]
        [Route("/Survivour")]
        public float getSurvivour()
        {
            int totalCount = persons.Count;
            var aliveCOunt=persons.Count(p => p.Flag);
            var surviours = aliveCOunt * 100 / totalCount;
            return surviours;
        }

        //List of survivors, including their last known location
        [HttpGet]
        [Route("/SurvivourList")]
        public List<Person> getSurvivourList()
        {
            return persons.Where(p => p.Flag == true).ToList();





        }
    }
}
