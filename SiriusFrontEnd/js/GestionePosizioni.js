function init() {
    fetch("https://localhost:44383/api/Dispositivo/Posizioni")
        .then(response => response.json())
        .then(data => {
            data.forEach(element => {
                var divPlant = document.createElement("div");
                divPlant.setAttribute("id", element.plant);
                divPlant.appendChild(document.createTextNode(element.plant));

                divPlant.addEventListener("click", vaiAPlant);

                document.getElementById("elenco").appendChild(divPlant);
            });
        })
        .catch(error => {
            console.error('Errore durante il recupero dei dati:', error);
        });
}

function vaiAPlant(event) {
    sessionStorage.setItem("plant", event.currentTarget.id);
    console.log(event.currentTarget.id);
    window.location.href = "Plant.html";
}