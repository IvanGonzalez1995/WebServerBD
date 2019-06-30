using System.ComponentModel.DataAnnotations;

namespace WebServerBD.models
{
    public class Carros
    {
        [Key]
        public int Carro_ID {get;set;}
        public string Modelo {get;set;}
        public string Color {get;set;}
        public double Precio {get;set;}
    }
}