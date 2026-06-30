using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FinancieraApi.Models
{
    public class Prestamo
    {
        public int Id { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteId    { get; set; }
        public decimal Monto { get; set; }
        public int PlazoMeses {  get; set; }
        public decimal TasaInteres { get; set; }
        public DateTime FechaSolicitud {  get; set; }
        public string Estatus { get; set; }
        public Cliente? Cliente { get; set; }

    }
}
