using Newtonsoft.Json;
using System.IO;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    public class Apoyo
    {
        [Key]
        public string Identificacion { get; set; }
        [JsonProperty]
        public string Personas { get; set; }

        [JsonProperty]
        public string Tipo { get; set; }

        [JsonProperty]
        public int Valor { get; set; }

        [JsonProperty]
        public DateTime Fecha { get; set; }

        public Apoyo() {
            this.Identificacion = "Vaci";
            this.Persona = "1";
            this.Tipo = "comedor ";
            this.Valor = 0;
            this.Fecha = new DateTime()
        }
    }
    
}
