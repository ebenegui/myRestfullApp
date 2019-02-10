using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

public class ObjectResult : IHttpActionResult
{
    HttpRequestMessage _request;

    HttpStatusCode _statusCode;

    public ObjectResult(HttpStatusCode statusCode, HttpRequestMessage request)
    {
        _request = request;

        _statusCode = statusCode;        
    }

    public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
    {
        var response = new HttpResponseMessage()
        {
            RequestMessage = _request,

            StatusCode = _statusCode
        };

        return Task.FromResult(response);
    }
}