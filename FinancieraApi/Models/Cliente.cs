using System.ComponentModel.DataAnnotations;

namespace FinancieraApi.Models
{
    public class Cliente
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [MaxLength(100)]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(18)]
        public string CURP {  get; set; }

        [Required]
        [MaxLength(13)]
        public string RFC { get; set; }

        [Phone]
        public string Telefono { get; set; }

        [EmailAddress]
        public string Correo { get; set; }

        [Range(1,99999)]
        public decimal IngresoMensual { get; set; }

        //relacion uno a muchos

        public ICollection<Prestamo> Prestamos { get; set; }


    }
}
