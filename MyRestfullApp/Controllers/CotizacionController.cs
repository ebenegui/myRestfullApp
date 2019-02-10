using MyRestfullApp.Models;
using System.Threading.Tasks;
using System.Web.Http;

namespace MyRestfullApp.Controllers
{
    public class CotizacionController : ApiController
    {
        public async Task<IHttpActionResult> Get([FromUri] string moneda)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Moneda tipoCambio = new Moneda();
            
            switch (moneda.ToLower())
            {
                case ("dolar"):
                    tipoCambio.CotizacionMonedaDolar();
                    break;
                case ("pesos"):
                    tipoCambio.CotizacionMonedaPesos();
                    break;
                case ("real"):
                    tipoCambio.CotizacionMonedaReal();
                    break;
                default:
                    return BadRequest();
            }

            var response = tipoCambio.CotizarMoneda(moneda);

            return await Task.FromResult(response);
        }
    }
}
