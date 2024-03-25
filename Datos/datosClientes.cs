using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
namespace Datos
{
    public class datosClientes
    {
        bddClientesEntities bdd = new bddClientesEntities();
        public datosClientes()
        {
            bdd = new bddClientesEntities();
        }

        #region metodosLectura
        public List<Clientes> ListarClientes()
        {
            return bdd.Clientes.ToList();
        }


        private Clientes SeleccionarClientePorId(int id)
        {
            return bdd.Clientes.FirstOrDefault(c => c.id == id);
        }
        #endregion

        public void InsertarCliente(Clientes cliente)
        {
            bdd.Clientes.Add(cliente);
            bdd.SaveChanges();
        }
        public void ModificarCliente(Clientes cliente)
        {
            Clientes clienteAModificar = bdd.Clientes.FirstOrDefault(c => c.id == cliente.id);
            clienteAModificar.Cedula = cliente.Cedula;
            clienteAModificar.Nombre = cliente.Nombre;
            clienteAModificar.FechaNacimiento = cliente.FechaNacimiento;
            bdd.SaveChanges();
        }
        public bool EliminarCliente(Clientes clienteActualizado)
        {
            Clientes cliente = SeleccionarClientePorId(clienteActualizado.id);
            if (cliente != null)
            {
                bdd.Clientes.Remove(cliente);
                bdd.SaveChanges();
                return true;
            }
            else
                return false;
        }
    }
}
