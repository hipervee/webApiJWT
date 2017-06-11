using LetsJWT.Api.Core;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Web.Http;
using LetsJWT.Api.Filters;

namespace LetsJWT.Api.Controllers
{

    [CustomAuth]
    [RoutePrefix("api/books")]
    public class BooksController : ApiController
    {
        [HttpGet]
        [Route("all")]
        public async Task<IHttpActionResult> Get()
        {
            using (var context = new LetsJWTContext())
            {
                var books = await context.Books.ToListAsync();
                return Ok(books);
            }
        }
    }
}
