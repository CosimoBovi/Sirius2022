function init(){

    
	const xhttp = new XMLHttpRequest();
	

    xhttp.onload = function(){
		
        var oggetto = JSON.parse(xhttp.responseText);


        oggetto.forEach(element => {
            
            var divPlant = document.createElement("div");
            divPlant.setAttribute("id",element.id);
            divPlant.appendChild(document.createTextNode(element.device));

            divPlant.addEventListener("click",vaiADevice );

            document.getElementById("elenco").appendChild(divPlant);
         

        });
        
		
	}

    plant = sessionStorage.getItem("plant");
	
	xhttp.open("GET","https://localhost:44383/api/Dispositivo/Plant/"+plant,true);
	xhttp.send();

}

function vaiADevice(event){

    sessionStorage.setItem("device",event.currentTarget.id);

    console.log(event.currentTarget.id);
    window.location.href="Dettagli.html";


}