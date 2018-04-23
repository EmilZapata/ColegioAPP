using Colegio.Dominio.DTO.Concebir.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.Dominio.ServiceAplication.Concebir.General
{
    public class GeneralAppService
    {
        public List<ColegioDTO> ColegioGetList()
        {
            return FactoryGeneral.GetColegioRepository().GetList();
        }
    }
}
