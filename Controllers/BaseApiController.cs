using AutoMapper;
using Digisegal.Uow;
using Digisegal.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Digisegal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        private IUnitOfWork _UnitOfWork;
        private IMapper _mapper;
        // private IMapper _mapper;
        //  private IConfiguration _Configuration;
        //  private readonly IHttpClientFactory _clientFactory;
        //  private IWebHostEnvironment _Environment;
        // private ISmsManager _SmsManager;
        // private IUnitOfWork unitOfWork;
        //  private IMapper mapper;
        //  private IWebHostEnvironment environment;
        //  private IHttpClientFactory clientFactory1;

        protected BaseApiController(IUnitOfWork unitOfWork,IMapper mapper /*IWebHostEnvironment Environment,*/
            /*ISmsManager smsManager,*/ /*IHttpClientFactory clientFactory*//*, IConfiguration Configuration*/)
        {
         //   _Environment = Environment;

            _UnitOfWork = unitOfWork;
            _mapper = mapper;

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
        protected IMapper Mapper => _mapper;

        // public ErrorDto Errors { get; set; }
        // protected IMapper Mapper => _mapper;
        // protected IMapper Mapper => _mapper;
        // // protected ISmsManager SmsManager => _SmsManager;
        //   protected IConfiguration Configuration => _Configuration;
        // protected IConfiguration Configuration => _Configuration;
        // protected IHttpClientFactory clientFactory => _clientFactory;
        //  protected IWebHostEnvironment Environment => _Environment;


        protected IActionResult ExceptionHandler(System.Exception ex)
        {
         
            ErrorDto error = new ErrorDto
            {
                ErrorMessages = new List<string>()
            };
            error.ErrorMessages.Add("خطایی سمت سرور رخ داده است.");
            return StatusCode(500, error);
        }

    }

}
