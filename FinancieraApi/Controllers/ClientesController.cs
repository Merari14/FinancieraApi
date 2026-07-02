using FinancieraApi.Data;
using FinancieraApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinancieraApi.Dtos.Cliente;
using FinancieraApi.Dtos.Cliente;
using FinancieraApi.Interfaces;


namespace FinancieraApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService; // inyeccion de dependencias
        }

        [HttpGet]
        public async Task<ActionResult<List<IClienteService>>> GetClientes()
        {
            var clientes = await _clienteService.ObtenerClientesAsync();

            return Ok(clientes);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ClienteResponseDto>> GetCliente(int id)
        {
            var cliente = await _clienteService.ObtenerClientePorIdAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(cliente);
        }   


        [HttpPost]

        public async Task<ActionResult<Cliente>> CrearCliente(ClienteCreateDto dto)
        {
            var cliente = new Cliente
            {
                Nombre = dto.Nombre,
                Apellido = dto.Apellido,
                CURP = dto.CURP,
                RFC = dto.RFC,
                Telefono = dto.Telefono,
                Correo = dto.Correo,
                IngresoMensual = dto.IngresoMensual
            };
            _context.Clientes.Add(cliente);

            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetCliente),
                new {id = cliente.Id}, 
                cliente);
        }
    }

}
