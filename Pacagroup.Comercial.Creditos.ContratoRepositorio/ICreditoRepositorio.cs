using Pacagroup.Comercial.Creditos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacagroup.Comercial.Creditos.ContratoRepositorio {
    public interface ICreditoRepositorio {
        IEnumerable<Credito> ListarCredito ();

        Credito RegistrarCredito (Credito pCredito);

        Credito ActualizarCredito (Credito pCredito);

        bool EliminarCredito (string idCredito);
    }//EndClass
}//EdnNamespace
