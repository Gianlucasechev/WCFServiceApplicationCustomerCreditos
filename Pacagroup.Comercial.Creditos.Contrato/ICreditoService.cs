using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;
using Pacagroup.Comercial.Creditos.Dominio;
using System.ComponentModel; //Nos permitirá agregar el atributo descripción al contrato

namespace Pacagroup.Comercial.Creditos.Contrato
{
    [ServiceContract]
    public interface ICreditoService
    {
        [OperationContract]
        [Description("Servicio REST que lista toda la información de los Creditos")]
        [WebGet(RequestFormat =WebMessageFormat.Json, ResponseFormat =WebMessageFormat.Json, UriTemplate ="/ListarCreditos", BodyStyle =WebMessageBodyStyle.Bare)]       
        IEnumerable<Credito> listarCreditos();
        [OperationContract]
        [Description("Servicio REST que permite registrar toda la información de un nuevo credito")]
        [WebInvoke(Method ="POST", RequestFormat = WebMessageFormat.Json, ResponseFormat =WebMessageFormat.Json, UriTemplate ="/RegistrarCredito", BodyStyle =WebMessageBodyStyle.Bare )]
        Credito registrarCredito(Credito credito);
        [Description("Servicio REST que permite actualizar toda la información de un credito")]
        [OperationContract]
        [WebInvoke(Method = "PUT", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ActualizarCredito", BodyStyle = WebMessageBodyStyle.Bare)]
        Credito actualizarCredito(Credito credito);
        [Description("Servicio REST que permite eliminar toda la información de un credito")]
        [OperationContract]
        [WebInvoke(Method = "DELETE", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/EliminarCredito/{idCredito}", BodyStyle = WebMessageBodyStyle.Bare)]
        bool EliminarCredito(string idCredito);
        [Description("Servicio REST que permite obtener un credito y sus datos")]
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ObtenerCreditos/{idCredito}", BodyStyle = WebMessageBodyStyle.Bare)]
        Credito obtenerCredito(string idCredito);
    }
}
