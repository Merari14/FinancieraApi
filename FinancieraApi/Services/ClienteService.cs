using FinancieraApi.Data;
using FinancieraApi.Dtos.Cliente;
using FinancieraApi.Interfaces;
using FinancieraApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FinancieraApi.Services
{
    public class ClienteService : IClienteService
    {
        private readonly FinancieraContext _context;

        public ClienteService(FinancieraContext context) 
        {
            _context = context;
        }

        public async Task<List<ClienteResponseDto>> ObtenerClientesAsync()
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

        public async Task<ClienteResponseDto?> ObtenerClientePorIdAsync(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);

            if(cliente == null)
            {
                return null; 
            }
            return new ClienteResponseDto
            {
                Id = cliente.Id,
                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido,
                CURP = cliente.CURP,
                RFC = cliente.RFC,
                Telefono = cliente.Telefono,
                Correo = cliente.Correo,
                IngresoMensual = cliente.IngresoMensual
            };

        }

    }
}
