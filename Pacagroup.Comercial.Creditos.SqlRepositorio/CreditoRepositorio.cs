using Pacagroup.Comercial.Creditos.Dominio;
using Pacagroup.Comercial.Creditos.ContratoRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;

namespace Pacagroup.Comercial.Creditos.SqlRepositorio {
    public class CreditoRepositorio :ICreditoRepositorio {
        public Credito ActualizarCredito (Credito pCredito) {
            using(IDbConnection conexion = new SqlConnection(ConexionRepositorio.ObtenerCadenaConexion())) {
                conexion.Open();
                var parametros = new DynamicParameters();

                parametros.Add("idCredito", pCredito.IdCredito);
                parametros.Add("TipoCredito", pCredito.TipoCredito);
                parametros.Add("IdCliente", pCredito.IdCliente);
                parametros.Add("Fecha", pCredito.Fecha);
                parametros.Add("Monto", pCredito.Monto);
                parametros.Add("DiaPago", pCredito.DiaPago);
                parametros.Add("Tasa", pCredito.Tasa);
                parametros.Add("Comision", pCredito.Comision);

                var result = conexion.Execute("dbo.sp_credito_actualizar", param: parametros, commandType: CommandType.StoredProcedure);

                return result>0 ? pCredito : new Credito();
            }
        }

        public bool EliminarCredito (string idCredito) {
            using(IDbConnection conexion = new SqlConnection(ConexionRepositorio.ObtenerCadenaConexion())) {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("idCredito", idCredito);
                var result = conexion.Execute("dbo.sp_credito_eliminar", param: parametros, commandType: CommandType.StoredProcedure);
                return result>0;
            }
        }


        public IEnumerable<Credito> ListarCredito () {
            using(IDbConnection conexion = new SqlConnection(ConexionRepositorio.ObtenerCadenaConexion())) {
                conexion.Open();
                var coleccion = conexion.Query<Credito>("dbo.sp_credito_listar", commandType: CommandType.StoredProcedure);
                return coleccion;
            }
        }

        Credito ICreditoRepositorio.RegistrarCredito (Credito pCredito) {
            using(IDbConnection conexion = new SqlConnection(ConexionRepositorio.ObtenerCadenaConexion())) {
                conexion.Open();
                var parametros = new DynamicParameters();

                parametros.Add("TipoCredito", pCredito.TipoCredito);
                parametros.Add("IdCliente", pCredito.IdCliente);
                parametros.Add("Fecha", pCredito.Fecha);
                parametros.Add("Monto", pCredito.Monto);
                parametros.Add("DiaPago", pCredito.DiaPago);
                parametros.Add("Tasa", pCredito.Tasa);
                parametros.Add("Comision", pCredito.Comision);
                parametros.Add("idCredito", pCredito.IdCredito, DbType.Int32, ParameterDirection.Output);

                var result = conexion.ExecuteScalar("dbo.sp_credito_registrar", param: parametros, commandType: CommandType.StoredProcedure);
                var pIdCredito = parametros.Get<Int32>("idCredito");

                pCredito.IdCredito=pIdCredito;
                return pCredito;
            }
        }
    }//EndClass
}//EdnNamespace

