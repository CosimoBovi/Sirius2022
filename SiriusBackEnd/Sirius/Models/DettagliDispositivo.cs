//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sirius.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class DettagliDispositivo
    {
        public int id { get; set; }
        public Nullable<int> Dispositivoid { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<double> ActivePowerkW { get; set; }
        public Nullable<double> AmbientTempC { get; set; }
        public Nullable<double> ControllerHubTempC { get; set; }
        public Nullable<double> ControllerTopTempC { get; set; }
        public Nullable<double> CosPhi { get; set; }
        public Nullable<double> FrequencyHz { get; set; }
        public Nullable<double> GeneratorSpeedrpm { get; set; }
        public Nullable<double> HydraulicOilPressure { get; set; }
        public Nullable<double> HydraulicOilTempC { get; set; }
        public Nullable<double> NacelleDirdegs { get; set; }
        public Nullable<double> NacelleTempC { get; set; }
        public Nullable<double> ProduciblePower { get; set; }
        public Nullable<double> ProduciblePowerVestas { get; set; }
        public Nullable<double> ReactivePowerkVAr { get; set; }
        public Nullable<double> RotorSpeedrpm { get; set; }
        public Nullable<double> SpinnerTempC { get; set; }
        public Nullable<double> WindDirdegs { get; set; }
        public Nullable<double> WindSpeedms { get; set; }

       
    }
}
