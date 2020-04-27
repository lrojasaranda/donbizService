using System;
namespace pe.donbiz.service.webAPI.Models.Application
{
    public class MaestraDto
    {
        public int MaestraId { get; set; }
        public string Tabla { get; set; }
        public string Descripcion { get; set; }
        public int Orden { get; set; }
        public string Contenido { get; set; }
        public bool Encriptado { get; set; }
        public string Codigo { get; set; }
    }
}
