using System;
using System.Windows.Forms;
using System.ServiceModel;
using Pacagroup.Comercial.Creditos.Contrato;
using Pacagroup.Comercial.Creditos.Implementacion;

namespace Pacagroup.Comercial.Creditos.InstaladorEXE {
    public partial class frmServerWCF :Form {

        private ServiceHost _serviceHost = null;

        public frmServerWCF () {
            InitializeComponent();
        }

        private void btnIniciar_Click (object sender, EventArgs e) {
            _serviceHost.Close();
            _serviceHost=new ServiceHost(typeof(ClienteService));
            _serviceHost.Open();
        }

        private void btnDetener_Click (object sender, EventArgs e) {
            if(_serviceHost!=null) {
                return;
            } else {
                _serviceHost.Close();
            }
            _serviceHost=null;
        }
    }//EndClass
}//EndNamespace
