using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AccesoDatos;
using System.Web.UI.WebControls;
using Logica;
namespace ApiClientes
{
    /// <summary>
    /// Descripción breve de ApiClientesGestion
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ApiClientesGestion : System.Web.Services.WebService
    {
        logicaClientes logica = new logicaClientes();

        #region metodosLectura
        [WebMethod]
        public List<Clientes> ListarClientes()
        {
            return logica.ListarClientes();
        }

        [WebMethod]
        public Clientes ListarClientesPorCedula(string cedula)
        {
            return logica.ListarClientesPorCedula(cedula);
        }

        #endregion

        #region metodosEscritura
        [WebMethod]
        public void InsertarCliente(Clientes cliente)
        {
            logica.InsertarCliente(cliente);
        }
        [WebMethod]
        public void ModificarCliente(Clientes cliente)
        {
            logica.ActualizarCliente(cliente);
        }
        [WebMethod]
        public bool EliminarCliente(Clientes cliente)
        {
            return logica.EliminarCliente(cliente);
        }
        #endregion
    }
}
