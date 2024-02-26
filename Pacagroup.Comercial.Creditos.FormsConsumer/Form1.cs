using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pacagroup.Comercial.Creditos.Dominio;
using System.Runtime.Serialization.Json;

namespace Pacagroup.Comercial.Creditos.FormsConsumer {
    public partial class frmListadoCreditos : Form {
        public frmListadoCreditos() {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e) {
            Rest();
        }
        private void btnListarSoap_Click(object sender, EventArgs e) {
            Soap();
        }

        private void Rest() {
            WebClient proxy = new WebClient();

            //Esto sería conveniente colocarlo en un archivo de configuración u otro tipo de recurso para accederle
            string serviceURL = "http://localhost/WCFServiceCliente/CreditoService.svc/rest/ListarCredito";
            byte[] data = proxy.DownloadData(serviceURL);
            Stream stream = new MemoryStream(data);

            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(IEnumerable<Credito>));
            IEnumerable<Credito> coleccionCreditos = obj.ReadObject(stream) as IEnumerable<Credito>;

            gridCreditos.DataSource = coleccionCreditos;
        }

        private void Soap() {
            ProxyCredito.CreditoServiceClient proxyClient = new ProxyCredito.CreditoServiceClient();
            gridCreditos.DataSource = proxyClient.ListarCredito();

            if (proxyClient.State == System.ServiceModel.CommunicationState.Opened) {
                proxyClient.Close();
            }
        }
        
    }//EndClass
}//EndNamespace
