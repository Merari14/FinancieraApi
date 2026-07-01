using FinancieraApi.Data;
using FinancieraApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinancieraApi.Dtos.Cliente;


namespace FinancieraApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly FinancieraContext _context;

        public ClientesController(FinancieraContext context)
        {
            _context = context; // inyeccion de dependencias
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            var clientes = await _context.Clientes.ToListAsync();

            var respuesta = clientes.Select(c => new ClienteResponseDto
            {
                Id = c.Id,
                Nombre = c.Nombre,
                Apellido = c.Apellido,
                CURP = c.CURP,
                RFC = c.RFC,
                Telefono = c.Telefono,
                Correo = c.Correo,
                IngresoMensual = c.IngresoMensual
            });
            return Ok(respuesta);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetCliente(int id)
        {
            var cliente = await _context.Clientes.
                FirstOrDefaultAsync(c => c.Id == id);
                
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
