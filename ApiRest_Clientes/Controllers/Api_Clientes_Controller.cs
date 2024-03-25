using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AccesoDatos;
using Logica;

namespace ApiRest_Clientes.Controllers
{
    public class Api_Clientes_Controller : ApiController
    {
        logicaClientes logica = new logicaClientes();

        // GET: api/Api_Clientes_
        public List <Clientes> Get()
        {
            return logica.ListarClientes();
        }

        // GET: api/Api_Clientes_/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Api_Clientes_
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Api_Clientes_/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Api_Clientes_/5
        public void Delete(int id)
        {
        }
    }
}
