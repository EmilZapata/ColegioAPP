using Colegio.Dominio.DTO.Concebir.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.Dominio.Interfaces.Concebir.General
{
    public interface IColegioRepository
    {
        List<ColegioDTO> GetList();
    }
}
