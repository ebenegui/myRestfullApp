using MyRestfullApp.Interfaces;
using System.Web.Http;
using System.Web.Mvc;

namespace MyRestfullApp.Helpers
{
    public class Contexto
    {
        private ITipoCotizacion tipoCotizacion;

        public ITipoCotizacion TipoCotizacion
        {
            get { return tipoCotizacion; }
            set { tipoCotizacion = value; }
        }

        public IHttpActionResult CotizarMoneda(string moneda)
        {
            return tipoCotizacion.CotizarMoneda(moneda);
        }
    }
}