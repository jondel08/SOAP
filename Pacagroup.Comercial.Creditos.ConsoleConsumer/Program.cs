using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.Serialization;
using System.IO;
using Pacagroup.Comercial.Creditos.Dominio;
using System.Runtime.Serialization.Json;

namespace Pacagroup.Comercial.Creditos.ConsoleConsumer {
    public class Program {
        static void Main(string[] args) {
            //Rest();
            Soap();
        }

        public static void Rest() {
            WebClient proxy = new WebClient();

            //Esto sería conveniente colocarlo en un archivo de configuración u otro tipo de recurso para accederle
            string serviceURL = "http://localhost/WCFServiceCliente/CreditoService.svc/rest/ListarCredito";
            byte[] data = proxy.DownloadData(serviceURL);
            Stream stream = new MemoryStream(data);

            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(IEnumerable<Credito>));
            IEnumerable<Credito> creditos = obj.ReadObject(stream) as IEnumerable<Credito>;

            if (creditos != null) {
                foreach (Credito credito in creditos) {
                    Console.WriteLine($"Id Credito: \t{credito.IdCredito}");
                    Console.WriteLine($"Id Cliente: \t{credito.IdCliente}");
                    Console.WriteLine($"Fecha: \t{credito.Fecha}");
                    Console.WriteLine($"Tasa: \t{credito.Tasa}");
                    Console.WriteLine($"Comisión: \t{credito.Comision}");
                    Console.WriteLine($"Tipo Credito: \t{credito.TipoCredito}");
                    Console.WriteLine($"Dia de Pago: \t{credito.DiaPago}");
                    Console.WriteLine($"Monto : \t{credito.Monto}");
                    Console.WriteLine("******************************************");
                }
            }
            Console.ReadLine();
        }

        private static void Soap() {
            ProxyCredito.CreditoServiceClient proxy = new ProxyCredito.CreditoServiceClient();
            IEnumerable<Credito> creditos = proxy.ListarCredito();

            if (creditos != null) {
                foreach (Credito credito in creditos) {
                    Console.WriteLine($"Id Credito: \t{credito.IdCredito}");
                    Console.WriteLine($"Id Cliente: \t{credito.IdCliente}");
                    Console.WriteLine($"Fecha: \t{credito.Fecha}");
                    Console.WriteLine($"Tasa: \t{credito.Tasa}");
                    Console.WriteLine($"Comisión: \t{credito.Comision}");
                    Console.WriteLine($"Tipo Credito: \t{credito.TipoCredito}");
                    Console.WriteLine($"Dia de Pago: \t{credito.DiaPago}");
                    Console.WriteLine($"Monto : \t{credito.Monto}");
                    Console.WriteLine("******************************************");
                }
            }
            
            if (proxy.State == System.ServiceModel.CommunicationState.Opened) {
                proxy.Close();
            }

            Console.ReadLine();
        }

    }//EndClass
}//EndNamespace
