using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using pe.donbiz.service.webAPI.Models.Domain;

namespace pe.donbiz.service.webAPI.Controllers
{
    public class MaestraController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Index(string id)
        {
            try
            {
                var result = Request.CreateResponse(HttpStatusCode.OK, new MaestraDomain().GetTable(id));
                return result;
            }
            catch (Exception ex)
            {
                //logger.TraceError($"{puestoExpRango} | {numero}", $"{typeof(InvoiceController).Name} | { System.Reflection.MethodBase.GetCurrentMethod().Name}", ex.Message, ex.StackTrace);
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}