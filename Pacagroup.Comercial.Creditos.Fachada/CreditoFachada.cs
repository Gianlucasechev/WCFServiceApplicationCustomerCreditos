using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pacagroup.Comercial.Creditos.Dominio;
using Pacagroup.Comercial.Creditos.ContratoRepositorio;
using Pacagroup.Comercial.Creditos.SqlRepositorio;

namespace Pacagroup.Comercial.Creditos.Fachada
{
    public class CreditoFachada : IDisposable
    {
        public IEnumerable<Credito> listarCreditos()
        {
            ICreditoRepositorio instancia = new CreditoRepositorio();
            return instancia.listarCreditos();
        }
        public Credito registrarCredito(Credito credito)
        {
            ICreditoRepositorio instancia = new CreditoRepositorio();
            return instancia.registrarCredito(credito);
        }
        public Credito actualizarCredito(Credito credito)
        {
            ICreditoRepositorio instancia = new CreditoRepositorio();
            return instancia.actualizarCredito(credito);
        }
        public bool eliminarCredito(string idCredito)
        {
            ICreditoRepositorio instancia = new CreditoRepositorio();
            return instancia.eliminarCredito(idCredito);
        }
        public Credito obtenerCredito(string idCredito)
        {
            ICreditoRepositorio instancia = new CreditoRepositorio();
            return instancia.obtenerCredito(idCredito);
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
