using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Contracts
{
    public interface IGenericRepository<Entity> where Entity:class
    {
        int Add(Entity entity);
        int Edit(Entity entity);
        int Remove(string  Usuario);
        int RangoFecha(DateTime FechaInicial, DateTime FechaFinal);
        IEnumerable<Entity> GetAll();
    }
}
