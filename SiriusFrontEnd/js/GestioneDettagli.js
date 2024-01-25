var oggettoGrafico;

function init() {
  const labels = [];

  const data = {
    labels: labels,
    datasets: [{
      label: 'Grafico temperature',
      backgroundColor: 'rgb(255, 99, 132)',
      borderColor: 'rgb(255, 99, 132)',
      data: []
    }]
  };

  const config = {
    type: 'bar',
    data: data,
    options: {}
  };

  oggettoGrafico = new Chart(
    document.getElementById('graficoTemperature'),
    config
  );
}

function invia() {
  const device = sessionStorage.getItem("device");

  fetch(`https://localhost:44383/api/DettagliDispositivo/Dispositivo/${device}`)
    .then(response => response.json())
    .then(data => {
      var vettorePower = [];
      var vettoreOre = [];

      for (i = 0; i < data.length && i < 24; i++) {
        vettorePower.push(data[i].activePowerkW);
        vettoreOre.push(data[i].date);
      }

      oggettoGrafico.data.labels = vettoreOre;
      oggettoGrafico.data.datasets[0].data = vettorePower;
      oggettoGrafico.data.datasets[0].label = "power";

      oggettoGrafico.update();
    })
    .catch(error => {
      console.error('Errore durante il recupero dei dati:', error);
    });
}
