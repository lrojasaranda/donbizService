using System;
namespace pe.donbiz.service.webAPI.Models.DataPersistence
{
    public class DB
    {
        public class StoreProcedure
        {
            #region DOCUMENTO
            public static string ListarMaestraPorNombre = "SP_SEL_MAESTRA_POR_NOMBRE";
            #endregion
        }
        public class Parameter
        {
            /// <summary>
            /// @ovMensajeError
            /// </summary>
            public static string MensajeError = "@ovMensajeError";

            /// <summary>
            /// @oiNumeroError
            /// </summary>
            public static string NumeroError = "@oiNumeroError";
        }
    }
}
