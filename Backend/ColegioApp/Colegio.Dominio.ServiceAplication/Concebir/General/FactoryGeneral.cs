using Colegio.Context.Core;
using Colegio.Dominio.Interfaces.Concebir.General;
using Colegio.Infraestructura.Datos.Repositorio.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.Dominio.ServiceAplication.Concebir.General
{
    public class FactoryGeneral
    {
        private static ConcebirContext db = new ConcebirContext();

        public static IColegioRepository GetColegioRepository()
        {
            return new ColegioRepository(db);
        }
    }
}
