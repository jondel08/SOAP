using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using Pacagroup.Comercial.Creditos.WebConsumer2.Models.Credito;
using System.IO;
using System.Text;


namespace Pacagroup.Comercial.Creditos.WebConsumer2.Controllers {
    public class CreditoController : Controller {
        // GET: Credito
        public async Task<ActionResult> Index() {

            using (var client = new HttpClient()) {
                client.BaseAddress = new Uri("http://localhost/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = await client.GetAsync("WCFServiceCliente/CreditoService.svc/rest/ListarCredito");

                if (res.IsSuccessStatusCode) {
                    var result = res.Content.ReadAsStreamAsync().Result;
                    DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(List<Models.Credito.CreditoViewModel>));
                    List<CreditoViewModel> response = obj.ReadObject(result) as List<CreditoViewModel>;
                    return View(response);
                }
                return View();
            }
        }

        public ActionResult Create() {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreditoViewModel credito) {
            using (var client = new HttpClient()) {
                client.BaseAddress = new Uri("http://localhost/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(CreditoViewModel));
                MemoryStream stream = new MemoryStream();
                obj.WriteObject(stream, credito);
                string data = Encoding.UTF8.GetString(stream.ToArray(), 0, (int) stream.Length);

                HttpResponseMessage res = await client.PostAsync("WCFServiceCliente/CreditoService.svc/rest/RegistrarCredito", new StringContent(data, Encoding.UTF8, "application/json"));

                if (res.IsSuccessStatusCode) {
                    return RedirectToAction("Index");
                } else {
                    return View();
                }
            }
        }

        public async Task<ActionResult> Edit(int idCredito) {

            using (var client = new HttpClient()) {
                client.BaseAddress = new Uri("http://localhost/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = await client.GetAsync("WCFServiceCliente/CreditoService.svc/rest/ObtenerCredito/"+idCredito);

                if (res.IsSuccessStatusCode) {
                    var result = res.Content.ReadAsStreamAsync().Result;
                    DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(CreditoViewModel));
                    CreditoViewModel response = obj.ReadObject(result) as CreditoViewModel;
                    return View(response);
                }
                return View();
            }
        }

        [HttpPost]
        public async Task<ActionResult> Edit(CreditoViewModel credito) {
            using (var client = new HttpClient()) {
                client.BaseAddress = new Uri("http://localhost/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(CreditoViewModel));
                MemoryStream stream = new MemoryStream();
                obj.WriteObject(stream, credito);
                string data = Encoding.UTF8.GetString(stream.ToArray(), 0, (int) stream.Length);

                HttpResponseMessage res = await client.PutAsync("WCFServiceCliente/CreditoService.svc/rest/ActualizarCredito", new StringContent(data, Encoding.UTF8, "application/json"));

                if (res.IsSuccessStatusCode) {
                    return RedirectToAction("Index");
                } else {
                    return View();
                }
            }
        }

        public async Task<ActionResult> Details(int idCredito) {

            using (var client = new HttpClient()) {
                client.BaseAddress = new Uri("http://localhost/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = await client.GetAsync("WCFServiceCliente/CreditoService.svc/rest/ObtenerCredito/" + idCredito);

                if (res.IsSuccessStatusCode) {
                    var result = res.Content.ReadAsStreamAsync().Result;
                    DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(CreditoViewModel));
                    CreditoViewModel response = obj.ReadObject(result) as CreditoViewModel;
                    return View(response);
                }
                return View();
            }
        }

        public async Task<ActionResult> Delete(int idCredito) {

            using (var client = new HttpClient()) {
                client.BaseAddress = new Uri("http://localhost/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = await client.DeleteAsync("WCFServiceCliente/CreditoService.svc/rest/ObtenerCredito/" + idCredito);

                if (res.IsSuccessStatusCode) {
                    var result = res.Content.ReadAsStreamAsync().Result;
                    DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(CreditoViewModel));
                    CreditoViewModel response = obj.ReadObject(result) as CreditoViewModel;
                    return View(response);
                }
                return View();
            }
        }

        [HttpPost]
        public async Task<ActionResult> Delete(CreditoViewModel credito) {

            using (var client = new HttpClient()) {
                client.BaseAddress = new Uri("http://localhost/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = await client.GetAsync("WCFServiceCliente/CreditoService.svc/rest/EliminarCredito/" + credito.IdCredito);

                if (res.IsSuccessStatusCode) {
                    return View("Index");
                }
                return View();
            }
        }


    }//EndClass
}//EndNamespace