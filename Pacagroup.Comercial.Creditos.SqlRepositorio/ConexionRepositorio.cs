using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacagroup.Comercial.Creditos.SqlRepositorio {
    public  class ConexionRepositorio {
        
        public static string ObtenerCadenaConexion () { 
            return ConfigurationManager.ConnectionStrings["CreditosDB"].ToString ();
        }

    }//EndClass
}//EndNamespace
