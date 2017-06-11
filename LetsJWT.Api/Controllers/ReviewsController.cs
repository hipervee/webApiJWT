using LetsJWT.Api.Core;
using LetsJWT.Api.Models;
using LetsJWT.Api.ViewModels;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Web.Http;

namespace LetsJWT.Api.Controllers
{
    public class ReviewsController : ApiController
    {
        [HttpPost]
        public async Task<IHttpActionResult> Post([FromBody] ReviewViewModel review)
        {
            using (var context = new LetsJWTContext())
            {
                var book = await context.Books.FirstOrDefaultAsync(b => b.Id == review.BookId);
                if (book == null)
                {
                    return NotFound();
                }

                var newReview = context.Reviews.Add(new Review
                {
                    BookId = book.Id,
                    Description = review.Description,
                    Rating = review.Rating
                });

                await context.SaveChangesAsync();
                return Ok(new ReviewViewModel(newReview));
            }
        }

        [HttpDelete]
        public async Task<IHttpActionResult> Delete(int id)
        {
            using (var context = new LetsJWTContext())
            {
                var review = await context.Reviews.FirstOrDefaultAsync(r => r.Id == id);
                if (review == null)
                {
                    return NotFound();
                }

                context.Reviews.Remove(review);
                await context.SaveChangesAsync();
            }
            return Ok();
        }
    }
}

