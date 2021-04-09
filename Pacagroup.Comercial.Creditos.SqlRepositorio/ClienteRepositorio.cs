using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Pacagroup.Comercial.Creditos.Dominio;
using Pacagroup.Comercial.Creditos.ContratoRepositorio;
using System.ServiceModel;
using Dapper;

namespace Pacagroup.Comercial.Creditos.SqlRepositorio
{
    public class ClienteRepositorio:IClienteRepositorio
    {
        public Cliente obtenerClientes(string numerodocumento)
        {
            using (IDbConnection conexion = new SqlConnection(Conexion.obtenerCadenaConexion()))
            {
                conexion.Open();
                var parameter = new DynamicParameters();
                parameter.Add("numerodocumento", numerodocumento);

                var cliente = conexion.QuerySingle<Cliente>("dbo.sp_clientes_obtener", param: parameter, commandType: CommandType.StoredProcedure);
                return cliente;
            }
        }
        public IEnumerable<Cliente> listarClientes()
        {
            using(IDbConnection conexion = new SqlConnection(Conexion.obtenerCadenaConexion()))
            {
                conexion.Open();
                var cliente = conexion.Query<Cliente>("dbo.sp_clientes_listar", commandType: CommandType.StoredProcedure);
                return cliente;
            }
        }
    }
}
