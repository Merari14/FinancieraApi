using FinancieraApi.Dtos.Cliente;

namespace FinancieraApi.Interfaces
{
    public interface IClienteService
    {
        Task<List<ClienteResponseDto>> ObtenerClientesAsync();

        Task<ClienteResponseDto?> ObtenerClientePorIdAsync(int id);

        Task<ClienteResponseDto> CrearClienteAsync(ClienteResponseDto clienteDto);
    }
}
