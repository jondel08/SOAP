using System.Collections.Generic;
using Pacagroup.Comercial.Creditos.Contrato;
using Pacagroup.Comercial.Creditos.Dominio;
using Pacagroup.Comercial.Creditos.Fachada;
using System;
using System.ServiceModel;


namespace Pacagroup.Comercial.Creditos.Implementacion {
    public class ClienteService :IClienteService {

        public Cliente ObtenerCliente (string numeroDocumento) {

            try {
                using(ClienteFachada clienteFachada = new ClienteFachada()) {
                    return clienteFachada.ObtenerCliente(numeroDocumento);
                }
            } catch(Exception ex) {

                throw new FaultException<Error>(new Error() { CodigoError="1001", Descripcion="Excepcion administrada por el servicio", Message=ex.Message });
            }
        }

        public IEnumerable<Cliente> ListarClientes () {
            using(ClienteFachada clienteFachada = new ClienteFachada()) {
                return clienteFachada.ListarClientes();
            }
        }
    }//EndClass
}//EndNamespace

