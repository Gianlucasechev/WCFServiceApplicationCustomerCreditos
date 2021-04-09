using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pacagroup.Comercial.Creditos.Dominio;
using System.ServiceModel;

namespace Pacagroup.Comercial.Creditos.ContratoRepositorio
{
    [ServiceContract]
    public interface ICreditoRepositorio
    {
        [OperationContract]
        IEnumerable<Credito> listarCreditos();
        [OperationContract]
        Credito registrarCredito(Credito credito);
        [OperationContract]
        Credito actualizarCredito(Credito credito);
        [OperationContract]
        bool eliminarCredito(string idCredito);
        [OperationContract]
        Credito obtenerCredito(string idCredito);
    }
}
