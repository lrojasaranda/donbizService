using System;
using System.Configuration;
namespace pe.donbiz.service.webAPI.Models.CrossCutting.Keys
{
    public class Keys
    {
        #region Conexion
        public static string GetSqlConexion()
        {
            return ConfigurationManager.ConnectionStrings["SqlCn"].ConnectionString;
        }
        #endregion
        public static string GetValueAppSetting(string name)
        {
            var n = ConfigurationManager.AppSettings[name];
            return ConfigurationManager.AppSettings[name];
        }
    }
}
