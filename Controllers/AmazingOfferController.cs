using AutoMapper;
using Digisegal.Uow;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Digisegal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmazingOfferController : BaseApiController
    {
        public AmazingOfferController(IUnitOfWork unitOfWork,IMapper mapper)
                 : base(unitOfWork,mapper)
        {
        }
        [HttpGet]
        [Route("GetAmazingOffer")]
        public IActionResult GetAmazingOffer(int AmazingOfferId)
        {
            var Offers = UnitOfWork.ProductRepository.entity().Where(n => n.AmazingOfferId == AmazingOfferId);
            return Ok(Offers);
        }
    }
}
