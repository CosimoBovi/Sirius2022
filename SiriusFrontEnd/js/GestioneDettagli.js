var oggettoGrafico;

function init(){
	const labels = [
    
  ];

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



function invia(){
	
	const xhttp = new XMLHttpRequest();
	

	xhttp.onload = function(){
		
		var oggetto = JSON.parse(xhttp.responseText);
		var vettorePower = [];
		var vettoreOre = [];

		for(i=0;i<oggetto.length&&i<24;i++){
			vettorePower.push(oggetto[i].activePowerkW);
			vettoreOre.push(oggetto[i].date);
		}
		
		oggettoGrafico.data.labels=vettoreOre;
		oggettoGrafico.data.datasets[0].data=vettorePower;
		oggettoGrafico.data.datasets[0].label="power";
		
		oggettoGrafico.update();
		
	}
	
	xhttp.open("GET","https://localhost:44383/api/DettagliDispositivo/Dispositivo/"+sessionStorage.getItem("device"),true);
	xhttp.send();
	
	
}