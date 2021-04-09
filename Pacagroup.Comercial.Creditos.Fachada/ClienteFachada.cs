using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pacagroup.Comercial.Creditos.SqlRepositorio;
using Pacagroup.Comercial.Creditos.ContratoRepositorio;
using Pacagroup.Comercial.Creditos.Dominio;

namespace Pacagroup.Comercial.Creditos.Fachada
{
    public class ClienteFachada : IDisposable
    {
        public Cliente obtenerClientes(string numerodocumento)
        {
            IClienteRepositorio instancia = new ClienteRepositorio();
            return instancia.obtenerClientes(numerodocumento);
        }
        public IEnumerable<Cliente> listarClientes()
        {
            IClienteRepositorio instancia = new ClienteRepositorio();
            return instancia.listarClientes();
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
