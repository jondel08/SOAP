using System.Collections.Generic;
using Pacagroup.Comercial.Creditos.Contrato;
using Pacagroup.Comercial.Creditos.Dominio;
using Pacagroup.Comercial.Creditos.Fachada;
using System;
using System.ServiceModel;

namespace Pacagroup.Comercial.Creditos.Implementacion {
    public class CreditoService :ICreditoService {

        public IEnumerable<Credito> ListarCredito () {
            using(CreditoFachada creditoFachada = new CreditoFachada()) {
                return creditoFachada.ListarCredito();
            }
        }
        public Credito RegistrarCredito (Credito pCredito) {
            using(CreditoFachada creditoFachada = new CreditoFachada()) {
                return creditoFachada.RegistrarCredito(pCredito);
            }
        }
        public Credito ActualizarCredito (Credito pCredito) {
            using(CreditoFachada creditoFachada = new CreditoFachada()) { 
                return creditoFachada.ActualizarCredito(pCredito);
            }
        }
        public bool EliminarCredito (string idCredito) {
            using(CreditoFachada creditoFachada = new CreditoFachada()) { 
                return creditoFachada.EliminarCredito(idCredito);
            }
        }
    }//EndClass
}//EndNamespace
