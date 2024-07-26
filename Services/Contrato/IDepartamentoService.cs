
using BackEndApiEmpleado.Models;

namespace BackEndApiEmpleado.Services.Contrato
{
    public interface IDepartamentoService
    {
        Task<List<Departamento>> GetList();
    }
}
