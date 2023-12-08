using ecommerce_app.Data.Base;
using ecommerce_app.Models;

namespace ecommerce_app.Data.Services
{
    public class ProducersService: EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
            
        }
    }
}
