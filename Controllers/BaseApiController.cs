using Digisegal.Uow;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Digisegal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        private IUnitOfWork _UnitOfWork;
       // private IMapper _mapper;
      //  private IConfiguration _Configuration;
      //  private readonly IHttpClientFactory _clientFactory;
      //  private IWebHostEnvironment _Environment;
        // private ISmsManager _SmsManager;
       // private IUnitOfWork unitOfWork;
      //  private IMapper mapper;
      //  private IWebHostEnvironment environment;
      //  private IHttpClientFactory clientFactory1;

        protected BaseApiController(IUnitOfWork unitOfWork/*IMapper mapper,*/ /*IWebHostEnvironment Environment,*/
            /*ISmsManager smsManager,*/ /*IHttpClientFactory clientFactory*//*, IConfiguration Configuration*/)
        {
         //   _Environment = Environment;

            _UnitOfWork = unitOfWork;

          //  _mapper = mapper;

            //  _SmsManager = smsManager;

          //  _clientFactory = clientFactory;

          //  _Configuration = Configuration;

            //Errors = new ErrorDto()
            //{
            //    ErrorMessages = new List<string>()
            //};

           //// _Configuration = Configuration;
        }

         protected IUnitOfWork UnitOfWork => _UnitOfWork;

        // public ErrorDto Errors { get; set; }
        // protected IMapper Mapper => _mapper;
        // protected IMapper Mapper => _mapper;
        // // protected ISmsManager SmsManager => _SmsManager;
     //   protected IConfiguration Configuration => _Configuration;
        // protected IConfiguration Configuration => _Configuration;
       // protected IHttpClientFactory clientFactory => _clientFactory;
      //  protected IWebHostEnvironment Environment => _Environment;

    }
}
