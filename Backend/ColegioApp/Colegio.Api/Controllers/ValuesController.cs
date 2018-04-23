using Colegio.Dominio.ServiceAplication.Concebir.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Colegio.Api.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        GeneralAppService app = new GeneralAppService();

        // GET api/values
        public IEnumerable<string> Get()
        {
            var colegios = app.ColegioGetList();
            string[] listCole = { "", "" };
            int i = 0;

            foreach (var col in colegios)
            {
                listCole[i] = "Col1 --> " + col.Col_Id + "-" + col.Col_Nombre + "-" + col.Col_Codigo;

                i++;
            }

            return listCole;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
