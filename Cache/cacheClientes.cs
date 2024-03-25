using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;
namespace Cache
{
    public class cacheClientes
    {
        private static List<Clientes> _cache = new List<Clientes>();
        private static datosClientes datos = new datosClientes();

        static cacheClientes()
        {
            _cache = new List<Clientes>();
        }

        // Método para obtener todos los clientes, se asume que se desea cachear todos los clientes juntos
        public List<Clientes> ObtenerTodosLosClientes()
        {
            // Si la caché está vacía, se carga desde la base de datos
            if (!_cache.Any())
            {
                CargarClientesDesdeBD();
            }
            return _cache;
        }


        // Métodos para insertar y actualizar un cliente en la caché
        public void InsertarCliente(Clientes cliente)
        {
            datos.InsertarCliente(cliente);
            CargarClientesDesdeBD();
        }

        public void ActualizarCliente(Clientes cliente)
        {
            datos.ModificarCliente(cliente);
            CargarClientesDesdeBD();
        }

        // Método para eliminar un cliente de la caché
        public bool EliminarCliente(Clientes cliente)
        {
            bool flag = datos.EliminarCliente(cliente);
            CargarClientesDesdeBD();
            return flag;
        }

        // Cargar todos los clientes desde la base de datos
        private void CargarClientesDesdeBD()
        {
            // Asumiendo que tienes un método para listar clientes desde la base de datos
            var accesoDatos = new datosClientes(); // Asegúrate de tener la instancia correcta de tu capa de acceso a datos
            _cache = accesoDatos.ListarClientes();
        }
    }
}
