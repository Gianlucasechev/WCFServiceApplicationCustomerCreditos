using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pacagroup.Comercial.Creditos.Contrato;
using Pacagroup.Comercial.Creditos.Dominio;
using Pacagroup.Comercial.Creditos.Fachada;
using System.ServiceModel;

namespace Pacagroup.Comercial.Creditos.Implementacion
{
    public class ClienteService : IClienteService
    {
        public IEnumerable<Cliente> listarClientes()
        {
            try
            {
                using (ClienteFachada instancia = new ClienteFachada())
                {
                    return instancia.listarClientes();
                }
            }
            
            catch (Exception ex)
            {
                throw new FaultException<Error>(new Error() { CodigoError = "10001", Descripcion = "Excepcion administrada por el servicio", MensajeError = ex.Message });
            }

        }

        public Cliente obtenerClientes(string numerodocumento)
        {
            using(ClienteFachada instancia = new ClienteFachada())
            {
                return instancia.obtenerClientes(numerodocumento);
            }
        }
    }
}
