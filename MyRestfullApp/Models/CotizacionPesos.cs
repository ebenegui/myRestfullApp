using MyRestfullApp.Interfaces;
using System.Web.Mvc;
using System;
using System.Web.Http;
using System.Net.Http;
using System.Net;

namespace MyRestfullApp.Models
{
    public class CotizacionPesos : ITipoCotizacion
    {
        public IHttpActionResult CotizarMoneda(string moneda)
        {
            var request = new HttpRequestMessage();            

            return new ObjectResult(HttpStatusCode.Unauthorized, request);
        }
    }
}