
using Microsoft.EntityFrameworkCore;
using BackEndApiEmpleado.Models;
using BackEndApiEmpleado.Services.Contrato;

namespace BackEndApiEmpleado.Services.Implentacion
{
    
    public class DepartamentoService: IDepartamentoService
    {
        private DbempleadoContext _dbContext;


        public DepartamentoService(DbempleadoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Departamento>> GetList()
        {
            try { 
                List<Departamento> lista = new List<Departamento>();
                lista = await _dbContext.Departamentos.ToListAsync();
                return lista;
            }
            catch(Exception ex) {
                throw ex;
            }
        }
    }
}
