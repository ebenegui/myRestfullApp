using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace MyRestfullApp.Interfaces
{
    public interface ITipoCotizacion
    {
        IHttpActionResult CotizarMoneda(string moneda);
    }
}
