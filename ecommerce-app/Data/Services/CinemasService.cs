using ecommerce_app.Data.Base;
using ecommerce_app.Models;

namespace ecommerce_app.Data.Services
{
    public class CinemasService:EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context) 
        {

        }

    }
}
