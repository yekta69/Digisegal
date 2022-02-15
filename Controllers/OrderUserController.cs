using AutoMapper;
using Digisegal.Uow;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digisegal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderUserController : BaseApiController
    {
        public OrderUserController(IUnitOfWork unitOfWork, IMapper mapper)
        : base(unitOfWork, mapper)
        {
        }
        
        [HttpGet]
        [Route("GetOrder")]
        public IActionResult GetOrder(int UserId)
        {
            var User = UnitOfWork.OrdersRepository.GetAll().Where(n => n.UserId == UserId);
            return Ok(User);
        }
    }
}
