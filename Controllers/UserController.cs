using Digisegal.Models.Segal_DbContext;
using Digisegal.Uow;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Digisegal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController :BaseApiController
    {
        public UserController(IUnitOfWork unitOfWork)
        : base(unitOfWork)
        {

        }
     



        [HttpGet]
        [Route("Getuser")]
        public IActionResult GetUser( int id)
        {
            var user = UnitOfWork.UserRepository.Get(id);
            var tr = "test";
            var op = "dddddddd";
            return Ok(user);
        }

    }
}
