using MyRestfullApp.Interfaces;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace MyRestfullApp.Models
{
    public class CotizacionReal : ITipoCotizacion
    {
        public IHttpActionResult CotizarMoneda(string moneda)
        {
            var request = new HttpRequestMessage();

            return new ObjectResult(HttpStatusCode.Unauthorized,request);
        }
    }
}