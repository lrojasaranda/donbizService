using System;
using pe.donbiz.service.webAPI.Models.Application;
using pe.donbiz.service.webAPI.Models.CrossCutting.Common.Configuration;
namespace pe.donbiz.service.webAPI.Models.DataPersistence.Entity
{
    public class MaestraEntity
    {
        [Column("yMaestraId")]
        public int MaestraId { get; set; }

        [Column("vTabla")]
        public string Tabla { get; set; }

        [Column("vDescripcion")]
        public string Descripcion { get; set; }

        [Column("yOrden")]
        public int Orden { get; set; }

        [Column("vContenido")]
        public string Contenido { get; set; }

        [Column("xEncriptado")]
        public bool Encriptado { get; set; }

        [Column("vCodigo")]
        public string Codigo { get; set; }



        #region Mapper
        public static MaestraDto ToDto(MaestraEntity table)
        {
            return new MaestraDto()
            {
                MaestraId = table.MaestraId,
                Tabla = table.Tabla,
                Descripcion = table.Descripcion,
                Orden = table.Orden,
                Contenido = table.Contenido,
                Encriptado = table.Encriptado,
                Codigo = table.Codigo
            };
        }
        #endregion
    }
}
