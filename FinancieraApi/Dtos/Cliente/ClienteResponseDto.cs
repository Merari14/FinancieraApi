namespace FinancieraApi.Dtos.Cliente
{
    public class ClienteResponseDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CURP { get; set; }
        public string RFC { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public decimal IngresoMensual { get; set; }
    }
}
