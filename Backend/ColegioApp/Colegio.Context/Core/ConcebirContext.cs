using Colegio.Dominio.DTO.Concebir.General;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.Context.Core
{
    public class ConcebirContext : DbContext
    {
        static ConcebirContext()
        {
            Database.SetInitializer<ConcebirContext>(null);
        }

        public ConcebirContext() : base("Name=ConcebirContext") { }


        public DbSet<ColegioDTO> Colegios { get; set; }

    }
}
