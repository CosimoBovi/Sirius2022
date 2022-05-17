function init(){

    
	const xhttp = new XMLHttpRequest();
	

    xhttp.onload = function(){
		
        var oggetto = JSON.parse(xhttp.responseText);


        oggetto.forEach(element => {
            
            var divPlant = document.createElement("div");
            divPlant.setAttribute("id",element.plant);
            divPlant.appendChild(document.createTextNode(element.plant));

            divPlant.addEventListener("click",vaiAPlant );

            document.getElementById("elenco").appendChild(divPlant);
         

        });
        
		
	}
	
	xhttp.open("GET","https://localhost:44383/api/Dispositivo/Posizioni",true);
	xhttp.send();

}

function vaiAPlant(event){

    sessionStorage.setItem("plant",event.currentTarget.id);

    console.log(event.currentTarget.id);
    window.location.href="Plant.html";


}