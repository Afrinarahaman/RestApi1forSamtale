function getPerson(){
            fetch("https://localhost:44334/Person").then((data)=> {
                //console.log(data);
                return data.json();
            }).then((objectdata)=>{
                console.log(objectdata);
                let tabledata="";
                objectdata.map((values)=>{
                tabledata += `<tr>
                <th scope="row">1</th>
                <td>${values.FirstName}   </td>
                <td> ${values.LastName}   </td>
                <td>  ${values.Gender}   </td>
                <td>  ${values.Flag}   </td>
            </tr>`;
                })
                document.getElementById("table_body").innerHTML = tabledata;
            });
}

getPerson();

function survivorsPercentage() {
    fetch("https://localhost:44334/Survivour").then((data) => {
        console.log(data);
        return data.json();
    }).then((res) => {
        console.log(res);
       

        document.getElementById("Survivor").innerHTML = res;
    });
      
}

survivorsPercentage();

function survivoursList() {
    fetch("https://localhost:44334/SurvivourList").then((data) => {
        return data.json();

    }).then((objectdata) => {
        console.log(objectdata);
        let tabledata = "";
        objectdata.map((values) => {
            tabledata += `<tr>
                <th scope="row">1</th>
                <td>${values.FirstName}   </td>
                <td> ${values.LastName}   </td>
                <td>  ${values.Gender}   </td>
                <td>  ${values.Flag}   </td>
            </tr>`
        })
        document.getElementById("table_survivour").innerHTML = tabledata;
    

    });

     
}


survivoursList();