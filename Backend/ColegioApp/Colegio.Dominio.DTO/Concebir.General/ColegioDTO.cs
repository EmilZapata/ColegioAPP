using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.Dominio.DTO.Concebir.General
{
    [Table("ColegioDTO", Schema = "public")]
    public class ColegioDTO
    {
        [Key]
        public int Col_Id { get; set; }
        public string Col_Nombre { get; set; }
        public string Col_Direccion { get; set; }
        public string Col_Codigo { get; set; }
    }
}
