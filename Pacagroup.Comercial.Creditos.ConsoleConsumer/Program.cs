using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//añadimos estas 2 librerias
using System.Net;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;
using System.ServiceModel;
using Pacagroup.Comercial.Creditos.Dominio;
using System.Runtime.Serialization.Json;

namespace Pacagroup.Comercial.Creditos.ConsoleConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rest();
            SOAP();
        }

        private static void Rest()
        {
            WebClient proxy = new WebClient();
            //declaramos la url dondee tendremos nuestro servicio.
            string ServiceURL = "http://localhost/WcfService/CreditoService.svc/rest/ListarCreditos";
            byte[] data = proxy.DownloadData(ServiceURL);
            Stream stream = new MemoryStream(data);

            //serializamos nuestro objeto ienumerable de credito.
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(IEnumerable<Credito>));

            IEnumerable<Credito> credito = obj.ReadObject(stream) as IEnumerable<Credito>;

            if (credito != null)
            {
                foreach(var dato in credito)
                {
                    Console.WriteLine("El IdCredito es: " + dato.IdCliente + " En la fecha de: " + dato.Fecha + " y el monto que tendrá que pagar el cliente es: " + dato.Monto );
                }
            }
            Console.ReadLine();
        }
        private static void SOAP()
        {
            ProxyCredito.CreditoServiceClient proxy = new ProxyCredito.CreditoServiceClient();
            IEnumerable<Credito> coleccion = proxy.listarCreditos();
            if (coleccion != null)
            {
                foreach (var dato in coleccion)
                {
                    Console.WriteLine("El IdCredito es: " + dato.IdCliente + " En la fecha de: " + dato.Fecha + " y el monto que tendrá que pagar el cliente es: " + dato.Monto);
                }
            }
            if (proxy.State == CommunicationState.Opened)
            {
                proxy.Close();
            }
            Console.ReadKey();
        }
    }
}
