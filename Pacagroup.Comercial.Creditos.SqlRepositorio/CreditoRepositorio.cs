using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Pacagroup.Comercial.Creditos.Dominio;
using Pacagroup.Comercial.Creditos.ContratoRepositorio;
using Pacagroup.Comercial.Creditos.SqlRepositorio;

namespace Pacagroup.Comercial.Creditos.SqlRepositorio
{
    public class CreditoRepositorio : ICreditoRepositorio
    {
        public Credito actualizarCredito(Credito credito)
        {
            using (IDbConnection conexion = new SqlConnection(Conexion.obtenerCadenaConexion()))
            {
                conexion.Open();
                var parameter = new DynamicParameters();

                parameter.Add("IdCredito", credito.IdCredito);
                parameter.Add("TipoCredito", credito.TipoCredito);
                parameter.Add("IdCliente", credito.IdCliente);
                parameter.Add("Fecha", credito.Fecha);
                parameter.Add("Monto", credito.Monto);
                parameter.Add("DiaPago", credito.DiaPago);
                parameter.Add("Tasa", credito.Tasa);
                parameter.Add("Comision", credito.Comision);

                var cliente = conexion.Execute("dbo.sp_credito_actualizar", param: parameter, commandType: CommandType.StoredProcedure);
                return cliente>0 ? credito : new Credito();
            }
        }

        public bool eliminarCredito(string idCredito)
        {
            using(IDbConnection conexion = new SqlConnection(Conexion.obtenerCadenaConexion()))
            {
                conexion.Open();
                var parameter = new DynamicParameters();
                parameter.Add("IdCredito", idCredito);
                var result = conexion.Execute("dbo.sp_credito_eliminar", param:parameter, commandType: CommandType.StoredProcedure);
                return result>0;
            }
        }

        public IEnumerable<Credito> listarCreditos()
        {
            using (IDbConnection conexion = new SqlConnection(Conexion.obtenerCadenaConexion()))
            {
                conexion.Open();
                var cliente = conexion.Query<Credito>("dbo.sp_credito_listar", commandType: CommandType.StoredProcedure);
                return cliente;
            }
        }
        public Credito obtenerCredito(string idCredito)
        {
            using (IDbConnection conexion = new SqlConnection(Conexion.obtenerCadenaConexion()))
            {
                conexion.Open();
                var parameter = new DynamicParameters();
                parameter.Add("pIdCredito", idCredito);

                var cliente = conexion.QuerySingle<Credito>("dbo.sp_credito_obtener", param: parameter, commandType: CommandType.StoredProcedure);
                return cliente;
            }
        }

        public Credito registrarCredito(Credito credito)
        {
            using (IDbConnection conexion = new SqlConnection(Conexion.obtenerCadenaConexion()))
            {
                conexion.Open();
                var parameter = new DynamicParameters();
                
                parameter.Add("TipoCredito", credito.TipoCredito);
                parameter.Add("IdCliente", credito.IdCliente);
                parameter.Add("Fecha", credito.Fecha);
                parameter.Add("Monto", credito.Monto);
                parameter.Add("DiaPago", credito.DiaPago);
                parameter.Add("Tasa", credito.Tasa);
                parameter.Add("Comision", credito.Comision);
                parameter.Add("IdCredito", credito.IdCredito, DbType.Int32, ParameterDirection.Output);

                var result = conexion.Execute("dbo.sp_credito_registrar", param: parameter, commandType: CommandType.StoredProcedure);
                var pIdCredito = parameter.Get<Int32>("IdCredito");
                credito.IdCredito = pIdCredito;
                return credito;
            }
        }
    }
}
