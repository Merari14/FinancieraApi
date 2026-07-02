using FinancieraApi.Data;
using FinancieraApi.Dtos.Cliente;
using FinancieraApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FinancieraApi.Services
{
    public class ClienteService
    {
        private readonly FinancieraContext _context;

        public ClienteService(FinancieraContext context) 
        {
            _context = context;
        }

        public async Task<List<ClienteResponseDto>> ObtenerClienteAsync()
        {
            var clientes = await _context.Clientes.ToListAsync();

            return clientes.Select(c => new ClienteResponseDto
            {
                Id = c.Id,
                Nombre = c.Nombre,
                Apellido = c.Apellido,
                CURP = c.CURP,
                RFC = c.RFC,
                Telefono = c.Telefono,
                Correo = c.Correo,  
                IngresoMensual = c.IngresoMensual

            }).ToList();

        }

    }
}
