using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using Pacagroup.Comercial.Creditos.Contrato;
using Pacagroup.Comercial.Creditos.Implementacion;

namespace Pacagroup.Comercial.Creditos.InstaladorEXE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private ServiceHost _serviceHost = null;
        private void btniniciar_Click(object sender, EventArgs e)
        {
            _serviceHost?.Close();
            _serviceHost = new ServiceHost(typeof(ClienteService));
            _serviceHost.Open();
        }

        private void btndetener_Click(object sender, EventArgs e)
        {
            if (_serviceHost == null) return;
            _serviceHost.Close();
            _serviceHost = null;
        }
    }
}
