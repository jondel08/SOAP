using System;
using System.Collections.Generic;
using Pacagroup.Comercial.Creditos.Dominio;
using Pacagroup.Comercial.Creditos.ContratoRepositorio;
using Pacagroup.Comercial.Creditos.SqlRepositorio;

namespace Pacagroup.Comercial.Creditos.Fachada {
    public class ClienteFachada :IDisposable {
        public Cliente ObtenerCliente (string numeroDocumento) {
            IClienteRepositorio clienteRepositorio = new ClienteRepositorio ();    
            return clienteRepositorio.ObtenerCliente(numeroDocumento);
        }

        public IEnumerable<Cliente> ListarClientes () {
            IClienteRepositorio clienteRepositorio = new ClienteRepositorio ();
            return clienteRepositorio.ListarClientes();
        }

        public void Dispose () {
            GC.SuppressFinalize(this);
        }
    }//EndClass

}//EndNamespace
