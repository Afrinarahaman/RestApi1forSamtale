using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestApi.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(32)")]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar(32)")]
        public string LastName { get; set; }

        [Column(TypeName = "smallint")]
        public int Age { get; set; }

        [Column(TypeName = "nvarchar(32)")]
        public string Gender { get; set; }

        [Column(TypeName = "decimal(9,6)")]
        public double LastLocationLatitude { get; set; }

        public double LastLocationLongitude { get; set; }

       
        public bool Flag { get; set; }

        public Person(int id, string firstName, string lastName, int age, string gender, double lastLocationLatitude, double lastLocationLongitude, bool flag)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Gender = gender;
            this.LastLocationLatitude = lastLocationLatitude;
            this.LastLocationLongitude = lastLocationLongitude;
            this.Flag = flag;
        }

        public Person()
        { }
    }
}

