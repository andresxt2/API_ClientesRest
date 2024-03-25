using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Cache;
namespace Logica
{
    public class logicaClientes
    {
        cacheClientes cache = new cacheClientes();
        public List<Clientes> ListarClientes()
        {
            return cache.ObtenerTodosLosClientes();
        }

        public Clientes ListarClientesPorCedula(string cedula)
        {
            return cache.ObtenerTodosLosClientes().Where(c=>c.Cedula == cedula).SingleOrDefault();
        }


        public void InsertarCliente(Clientes cliente)
        {
            cache.InsertarCliente(cliente);
        }

        public void ActualizarCliente(Clientes cliente)
        {
            cache.ActualizarCliente(cliente);
        }

        public bool EliminarCliente(Clientes cliente)
        {
            return cache.EliminarCliente(cliente);
        }

    }
}
