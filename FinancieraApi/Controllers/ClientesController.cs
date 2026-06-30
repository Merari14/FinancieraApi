using FinancieraApi.Data;
using FinancieraApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


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
    }
}
