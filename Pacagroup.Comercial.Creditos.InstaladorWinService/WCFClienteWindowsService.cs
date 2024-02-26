using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceProcess;
using Pacagroup.Comercial.Creditos.Contrato;
using Pacagroup.Comercial.Creditos.Implementacion;

namespace Pacagroup.Comercial.Creditos.InstaladorWinService {
    public class WCFClienteWindowsService :ServiceBase {

        private ServiceHost _serviceHost = null;

        public WCFClienteWindowsService () {
            ServiceName="WCFServicioCliente";
        }

        public static void Main () {
            ServiceBase.Run (new WCFClienteWindowsService ());
        }

        protected override void OnStart (string[] args) {
            _serviceHost?.Close ();
            _serviceHost=new ServiceHost(typeof(ClienteService));
            _serviceHost.Open();
        }

        protected override void OnStop () {
            if(_serviceHost==null) {
                return;
            } else {
                _serviceHost.Close();
            }
           _serviceHost = null;
        }

    }//EndClass
}//EndNamespace
