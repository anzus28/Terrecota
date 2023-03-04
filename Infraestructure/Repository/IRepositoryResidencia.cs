using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public interface IRepositoryResidencia
    {
        IEnumerable<Residencia> GetResidencia();
        IEnumerable<Residencia> GetResidenciaByNombreUsuario(String nombre);
        IEnumerable<Residencia> GetResidenciaByUsuario(int idUsuario);
       
        Residencia GetResidenciaByID(int id);
        void DeleteResidencia(int id);
        Residencia Save(Residencia residencia);
    }
}
