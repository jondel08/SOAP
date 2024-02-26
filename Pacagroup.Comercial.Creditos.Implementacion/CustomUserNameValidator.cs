using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Selectors;
using System.Configuration;
using System.ServiceModel;

namespace Pacagroup.Comercial.Creditos.Implementacion {
    public class CustomUserNameValidator : UserNamePasswordValidator {
        public override void Validate(string userName, string password) {

            string userAccess = ConfigurationManager.AppSettings.Get("User");
            string pwdAccess = ConfigurationManager.AppSettings.Get("Password");

            if (userName == null || password == null) {
                throw new ArgumentNullException();
            }

            if (userName != userAccess || password != pwdAccess) {
                throw new FaultException("Usuario o Password incorrecto");
            }
        }

    }//EndClass
}//EndNamespace
