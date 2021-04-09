using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Pacagroup.Comercial.Creditos.Dominio;
using System.ServiceModel.Web;
namespace Pacagroup.Comercial.Creditos.Contrato
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        [FaultContract(typeof(Error))]
        [WebGet(RequestFormat =WebMessageFormat.Json, ResponseFormat =WebMessageFormat.Json, UriTemplate="/obtenerClientes/{numeroDocumento}", BodyStyle =WebMessageBodyStyle.Bare)]
        Cliente obtenerClientes(string numerodocumento);
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/listarClientes", BodyStyle = WebMessageBodyStyle.Bare)]
        IEnumerable<Cliente> listarClientes();
    }
}
