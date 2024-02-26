using Pacagroup.Comercial.Creditos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pacagroup.Comercial.Creditos.ContratoRepositorio;
using Pacagroup.Comercial.Creditos.SqlRepositorio;

namespace Pacagroup.Comercial.Creditos.Fachada {
    public class CreditoFachada :IDisposable {

        public IEnumerable<Credito> ListarCredito () {
            ICreditoRepositorio instancia = new CreditoRepositorio ();
            return instancia.ListarCredito();
        }

        public Credito RegistrarCredito (Credito pCredito) {
            ICreditoRepositorio instancia = new CreditoRepositorio();
            return instancia.RegistrarCredito(pCredito);
        }

        public Credito ActualizarCredito (Credito pCredito) {
            ICreditoRepositorio instancia = new CreditoRepositorio();
            return instancia.ActualizarCredito(pCredito);
        }

        public bool EliminarCredito (string idCredito) {
            ICreditoRepositorio instancia = new CreditoRepositorio();
            return instancia.EliminarCredito(idCredito);
        }

        public void Dispose () {
            GC.SuppressFinalize(this);
        }
    }//EndClass
}//EndNamespace
