function init() {
    const plant = sessionStorage.getItem("plant");

    fetch(`https://localhost:44383/api/Dispositivo/Plant/${plant}`)
        .then(response => response.json())
        .then(data => {
            data.forEach(element => {
                var divDevice = document.createElement("div");
                divDevice.setAttribute("id", element.id);
                divDevice.appendChild(document.createTextNode(element.device));

                divDevice.addEventListener("click", vaiADevice);

                document.getElementById("elenco").appendChild(divDevice);
            });
        })
        .catch(error => {
            console.error('Errore durante il recupero dei dati:', error);
        });
}

function vaiADevice(event) {
    sessionStorage.setItem("device", event.currentTarget.id);
    console.log(event.currentTarget.id);
    window.location.href = "Dettagli.html";
}
