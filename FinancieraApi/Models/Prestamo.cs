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
        public decimal TasaIntereses { get; set; }
        public DateTime FechaSolicitus {  get; set; }
        public string Estatus { get; set; }
        public Cliente? Cliente { get; set; }

    }
}
