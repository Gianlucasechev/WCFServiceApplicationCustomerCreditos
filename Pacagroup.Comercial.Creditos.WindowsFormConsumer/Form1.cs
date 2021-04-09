using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using Pacagroup.Comercial.Creditos.Dominio;
using System.ServiceModel;

namespace Pacagroup.Comercial.Creditos.WindowsFormConsumer
{
    public partial class frmlistadocreditos : Form
    {
        public frmlistadocreditos()
        {
            InitializeComponent();
        }

        private void btnlistarcreditos_Click(object sender, EventArgs e)
        {
            //Rest();
            SoapListar();
        }
        private void Rest()
        {
            WebClient proxy = new WebClient();
            string ServiceURL = "http://localhost/WcfService/CreditoService.svc/rest/ListarCreditos";
            byte[] data = proxy.DownloadData(ServiceURL);
            //lo almacenamos temporalmente
            Stream stream = new MemoryStream(data);
            //declaramos nuestro objeto tipo datacontractjsonserializer ienumerable de credito
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(IEnumerable<Credito>));
            //des-serializamos nuestro objeto almacenado a traves del readobject.
            IEnumerable<Credito> coleccioncreditos = obj.ReadObject(stream) as IEnumerable<Credito>;

            gridCreditos.DataSource = coleccioncreditos;
        }
        private void SoapListar()
        {
            ProxyCreditos.CreditoServiceClient proxyclient = new ProxyCreditos.CreditoServiceClient();
            gridCreditos.DataSource = proxyclient.listarCreditos();
            if(proxyclient.State == CommunicationState.Opened)
            {
                proxyclient.Close();
            }
        }
    }
}
