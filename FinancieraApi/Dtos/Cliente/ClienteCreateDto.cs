using System.ComponentModel.DataAnnotations;

namespace FinancieraApi.Dtos.Cliente
{
    public class ClienteCreateDto
    {
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(100)]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(18)]
        public string CURP { get; set; }

        [Required]
        [MaxLength(13)]
        public string RFC { get; set; }

        [Phone]
        public string Telefono { get; set; }

        [EmailAddress]
        public string Correo { get; set; }

        [Range(1, 999999)]
        public decimal IngresoMensual { get; set; }
    }
}
