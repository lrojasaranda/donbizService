
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System;
using pe.donbiz.service.webAPI.Models.CrossCutting.Caching;
using pe.donbiz.service.webAPI.Models.CrossCutting.Keys;
using pe.donbiz.service.webAPI.Models.Application;
using pe.donbiz.service.webAPI.Models.DataPersistence;
namespace pe.donbiz.service.webAPI.Models.Domain
{
    public class MaestraDomain
    {
        #region TipoListaNegra
        public static IEnumerable<MaestraDto> GetByTableName(string tableName)
        {
            var list = CacheDomain.Get<IEnumerable<MaestraDto>>(tableName);
            if (list == null)
            {
                list = new MaestraPersistence().ObtenerPorNombreTabla(tableName);
                CacheDomain.Add(list.ToList(), tableName);
            }
            return list;
        }
        public IEnumerable<KeyValuePair<int, string>> GetTable(string tableName)
        {
            return GetByTableName(tableName).Select(s => new KeyValuePair<int, string>(s.MaestraId, s.Descripcion));
        }

        public int GetIdTable(string tableName,int orden)
        {
            var list = GetByTableName(tableName);
            return list.Where(w => w.Orden == orden).Select(s => s.MaestraId).First();
        }
        #endregion
        public MaestraDomain()
        {
        }
    }
}
