using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Pacagroup.Comercial.Creditos.Dominio;

namespace Pacagroup.Comercial.Creditos.ContratoRepositorio
{
    [ServiceContract]
    public interface IClienteRepositorio
    {
        [OperationContract]
        Cliente obtenerClientes(string numerodocumento);
        [OperationContract]
        IEnumerable<Cliente> listarClientes();
        
    }
}
