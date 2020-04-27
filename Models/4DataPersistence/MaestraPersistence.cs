using System;
using Dapper;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using pe.donbiz.service.webAPI.Models.Application;
using pe.donbiz.service.webAPI.Models.DataPersistence.Entity;
using pe.donbiz.service.webAPI.Models.CrossCutting.Common.Configuration;
using pe.donbiz.service.webAPI.Models.CrossCutting.Keys;
namespace pe.donbiz.service.webAPI.Models.DataPersistence
{
    public class MaestraPersistence
    {
        public MaestraPersistence()
        {
            SqlMapper.SetTypeMap(typeof(MaestraEntity), new DapperColumnAttributeTypeMapper<MaestraEntity>());

        }
        public IEnumerable<MaestraDto> ObtenerPorNombreTabla(string nombreTabla)
        {
            using (IDbConnection cnn = new SqlConnection(Keys.GetSqlConexion()))
            {
                cnn.Open();
                var p = new DynamicParameters();
                p.Add("@ivTabla", nombreTabla, DbType.String);
                p.Add(DB.Parameter.NumeroError, null, DbType.Int16, ParameterDirection.Output);
                p.Add(DB.Parameter.MensajeError, null, DbType.String, ParameterDirection.Output, 2000);
                var list = cnn.Query<MaestraEntity>(DB.StoreProcedure.ListarMaestraPorNombre, p, commandType: CommandType.StoredProcedure);
                cnn.Close();
                return from item in list select MaestraEntity.ToDto(item);

            }
        }
    }
}
