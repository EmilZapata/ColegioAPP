using Colegio.Dominio.Interfaces.Concebir.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colegio.Dominio.DTO.Concebir.General;
using Colegio.Context.Core;

namespace Colegio.Infraestructura.Datos.Repositorio.General
{
    public class ColegioRepository : IColegioRepository
    {
        ConcebirContext db = null;

        public ColegioRepository(ConcebirContext context) {
            this.db = context;
        }

        public List<ColegioDTO> GetList()
        {
            return db.Colegios.AsNoTracking().ToList();
        }
    }
}
