using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using Pacagroup.Comercial.Creditos.WebConsumer.Models.Credito;
using System.IO;
using System.Text;

namespace Pacagroup.Comercial.Creditos.WebConsumer.Controllers
{
    public class CreditoController : Controller
    {

        // GET: Credito
        public async Task<ActionResult> Index()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await client.GetAsync("WcfService/CreditoService.svc/rest/ListarCreditos");

                if (res.IsSuccessStatusCode)
                {
                    var result = res.Content.ReadAsStreamAsync().Result;
                    DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(List<CreditoViewModel>));

                    List<CreditoViewModel> response = obj.ReadObject(result) as List<CreditoViewModel>;
                    return View(response);
                }
                return View();

            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreditoViewModel credito)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(CreditoViewModel));
                MemoryStream men = new MemoryStream();
                ser.WriteObject(men, credito);
                string data = Encoding.UTF8.GetString(men.ToArray(), 0, (int)men.Length);

                HttpResponseMessage res = await client.PostAsync("WcfService/CreditoService.svc/rest/RegistrarCredito",
                    new StringContent(data, Encoding.UTF8, "application/json"));

                if (res.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
        }
        public async Task<ActionResult> Edit(int idcredito)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                HttpResponseMessage res = await client.GetAsync("WcfService/CreditoService.svc/rest/ObtenerCreditos/" + idcredito);
                if (res.IsSuccessStatusCode)
                {
                    var result = res.Content.ReadAsStreamAsync().Result;
                    DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(CreditoViewModel));

                    CreditoViewModel response = obj.ReadObject(result) as CreditoViewModel;
                    return View(response);
                }
                return View();
            }
        }
        //Actualizar
        [HttpPost]
        public async Task<ActionResult> Edit(CreditoViewModel credito)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(CreditoViewModel));
                MemoryStream men = new MemoryStream();
                ser.WriteObject(men, credito);
                string data = Encoding.UTF8.GetString(men.ToArray(), 0, (int)men.Length);

                HttpResponseMessage res =
                    await client.PutAsync("WcfService/CreditoService.svc/rest/ActualizarCredito", new StringContent(data, Encoding.UTF8, "application/json"));

                if (res.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }


            }
        }
        public async Task<ActionResult> Details(int idcredito)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = await client.GetAsync("WcfService/CreditoService.svc/rest/ObtenerCreditos/" + idcredito);

                if (res.IsSuccessStatusCode)
                {
                    var result = res.Content.ReadAsStreamAsync().Result;
                    DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(CreditoViewModel));

                    CreditoViewModel response = obj.ReadObject(result) as CreditoViewModel;
                    return View(response);
                }
                else
                {
                    return View();
                }


            }
        }
        public async Task<ActionResult> Delete(int idcredito)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = await client.GetAsync("WcfService/CreditoService.svc/rest/ObtenerCreditos/" + idcredito);

                if (res.IsSuccessStatusCode)
                {
                    var result = res.Content.ReadAsStreamAsync().Result;
                    DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(CreditoViewModel));

                    CreditoViewModel response = obj.ReadObject(result) as CreditoViewModel;
                    return View(response);
                }
                else
                {
                    return View();
                }


            }
        }
        [HttpPost]
        public async Task<ActionResult> Delete(CreditoViewModel credito)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = await client.DeleteAsync("WcfService/CreditoService.svc/rest/EliminarCredito/" + credito.IdCredito);

                if (res.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }


            }
        }
    }
}