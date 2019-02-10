using MyRestfullApp.Helpers;
using MyRestfullApp.Models;
using System;
using System.Web.Http;
using System.Web.Mvc;

namespace MyRestfullApp
{
    public class Moneda
    {
        private Contexto contexto;

        public Moneda()
        {
            contexto = new Contexto();
        }

        public void CotizacionMonedaPesos()
        {
            contexto.TipoCotizacion = new CotizacionPesos();
        }

        public void CotizacionMonedaReal()
        {
            contexto.TipoCotizacion = new CotizacionReal();
        }

        public void CotizacionMonedaDolar()
        {
            contexto.TipoCotizacion = new CotizacionDolar();
        }

        public IHttpActionResult CotizarMoneda(string moneda)
        {
            return contexto.CotizarMoneda(moneda);
        }
    }
}