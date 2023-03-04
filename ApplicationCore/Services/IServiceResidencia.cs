using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructure.Models;

namespace ApplicationCore.Services
{
    public interface IServiceResidencia
    {
        IEnumerable<Residencia> GetResidencia();
        IEnumerable<Residencia> GetResidenciaByNombreUsuario(String nombre);
        IEnumerable<Residencia> GetResidenciaByUsuario(int idUsuario);

        Residencia GetResidenciaByID(int id);
        void DeleteResidencia(int id);
        Residencia Save(Residencia residencia);
    }
}
