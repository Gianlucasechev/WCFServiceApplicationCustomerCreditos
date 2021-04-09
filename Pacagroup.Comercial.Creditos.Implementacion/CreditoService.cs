using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pacagroup.Comercial.Creditos.Contrato;
using Pacagroup.Comercial.Creditos.Dominio;
using Pacagroup.Comercial.Creditos.Fachada;

namespace Pacagroup.Comercial.Creditos.Implementacion
{
    public class CreditoService : ICreditoService
    {
        public Credito actualizarCredito(Credito credito)
        {
            using (var instancia = new CreditoFachada())
            {
                return instancia.actualizarCredito(credito);
            }
        }

        public bool EliminarCredito(string idCredito)
        {
            using (var instancia = new CreditoFachada())
            {
                return instancia.eliminarCredito(idCredito);
            }
        }

        public IEnumerable<Credito> listarCreditos()
        {
            using(var instancia = new CreditoFachada())
            {
                return instancia.listarCreditos();
            }
        }

        public Credito registrarCredito(Credito credito)
        {
            using (var instancia = new CreditoFachada())
            {
                return instancia.registrarCredito(credito);
            }
        }
        public Credito obtenerCredito(string idCredito)
        {
            using(var instancia = new CreditoFachada())
            {
                return instancia.obtenerCredito(idCredito);
            }
        }
    }
}
