using MyRestfullApp.Interfaces;
using System;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MyRestfullApp.Models
{
    public class CotizacionDolar : ITipoCotizacion
    {
        public IHttpActionResult CotizarMoneda(string moneda)
        {
            using (var client = new HttpClient())
            {
                Uri uri = new Uri("http://bancoprovincia.com.ar/Principal/Dolar");

                var request = new HttpRequestMessage();

                var responseTask = client.GetAsync(uri);

                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<string>();

                    readTask.Wait();

                    request.CreateResponse(readTask.Result);

                    return new ObjectResult(HttpStatusCode.OK,request);
                }
                else                
                    return new ObjectResult(HttpStatusCode.BadRequest, request);                
            }
        }
    }
}