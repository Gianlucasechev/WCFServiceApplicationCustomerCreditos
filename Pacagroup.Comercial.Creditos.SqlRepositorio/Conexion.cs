using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Pacagroup.Comercial.Creditos.SqlRepositorio
{
    public class Conexion
    {
        public static string obtenerCadenaConexion()
        {
            return ConfigurationManager.ConnectionStrings["CreditosDB"].ToString();
        }
    }
}
