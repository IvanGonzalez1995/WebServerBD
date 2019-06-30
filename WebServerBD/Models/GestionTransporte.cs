using System.ComponentModel.DataAnnotations;

namespace WebServerBD.models
{
    public class GestionTransporte
    {
        [Key]
        public int Id_Gestion {get; set;}
        public string Cod_Contrato {get; set;}
        public string Tipo_Transporte {get; set;}
        public string Desc_Transporte {get; set;}
        public int Cantidad_Transporte {get; set;}
        public string CantidadA_Transportar {get;set;}
        public string Fecha_Alta {get;set;}
        public string Fecha_Inicio {get;set;}
        public string Fecha_Fin {get;set;}
        public int Estado_gestion {get; set;}
        public string Notas {get; set;}
    }
}