using AutoMapper;
using Digisegal.Models;
using Digisegal.Uow;
using Digisegal.ViewModels.UserDto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Digisegal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseApiController
    {
        public UserController(IUnitOfWork unitOfWork, IMapper mapper)
        : base(unitOfWork, mapper)
        {
        }

        //[HttpPost]
        //[Route("CreateUser")]
        //public IActionResult CreateUser([FromBody] CreateUserDto user)
        // {
        //     //CreateUserDto createUserDto = new CreateUserDto();
        //     User uSer = new User();
        //     uSer.Name = user.Name;
        //     uSer.Family = user.Family;
        //     uSer.UserName = user.UserName;
        //     uSer.Nationalcode = user.Nationalcode;
        //     uSer.Password = user.Password;
        //     uSer.Email = user.Email;
        //     uSer.MobileNumber = user.MobileNumber;
        //     uSer.Address = user.Address;
        //     uSer.RegisterDate = DateTime.Now;
        //     UnitOfWork.UserRepository.Add(uSer);
        //     UnitOfWork.Complete();
        //     return Ok (uSer);
        // }

        [HttpPost]
        [Route("CreateUser")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserDto user)
        {
            try
            {
                var User = Mapper.Map<User>(user);
                var usertest = UnitOfWork.UserRepository.GetAll().Where(n => n.MobileNumber == user.MobileNumber).FirstOrDefault();
                if (usertest == null)
                {
                    await UnitOfWork.UserRepository.Add(User);
                    UnitOfWork.Complete();
                    return Ok(user);
                }
                else
                {
                    return Ok(".کاربری قبلا با این شماره ثبت شده است");
                }
            }
            catch(Exception error)
            {
                return Ok(error);
            }
        }

        [HttpGet]
        [Route("GetUser")]
        public IActionResult GetUser(string UserName, string Password)
        {
            try
            {
                var user = UnitOfWork.UserRepository.entity().Where(n => n.UserName == UserName && n.Password == Password).FirstOrDefault();
                if (user.Status == "Removed"||user ==null)
                {
                    return NotFound("Not Found ...");
                }
                else
                {
                    return Ok(user);
                }
            }
            catch(Exception ex)
            {
                return ExceptionHandler(ex);
            }
        }

        [HttpGet]
        [Route("GetAllUser")]
        public IActionResult GetAllUser()
        {
            try
            {
                var Users = UnitOfWork.UserRepository.GetAll().Where(n => n.Status != "Removed");
                return Ok(Users);
            }
            catch
            {
                string Error = ".خطایی رخ داده با پشتیبانی تماس بگیرید";
                return Ok(Error);
            }
        }

        [HttpPut]
        [Route("UpdateUser")]
        public IActionResult UpdateUser(User user)
        {
            try
            {
                UnitOfWork.UserRepository.Update(user);
                UnitOfWork.Complete();
                return Ok(user);
            }
            catch
            {
                string Error = ".خطایی رخ داده با پشتیبانی تماس بگیرید";
                return Ok(Error);
            }
        }

        [HttpDelete]
        [Route("DeleteUser")]
        public IActionResult DeleteUser(int Id)
        {
            try
            {
                var user = UnitOfWork.UserRepository.entity().Where(x => x.Id == Id).FirstOrDefault();
                user.Status = "Removed";
                user.RemoveDate = DateTime.Now;
                UnitOfWork.Complete();
                return Ok(user);
            }
            catch
            {
                string Error = ".خطایی رخ داده با پشتیبانی تماس بگیرید";
                return Ok(Error);
            }
        }

        //[HttpDelete]
        //[Route("DeleteUserForCustomer")]
        //public IActionResult DeleteUserForCustomer(int Id)
        //{
        //    var User = UnitOfWork.UserRepository.Get(Id);
        //    UnitOfWork.UserRepository.Remove(User);
        //    UnitOfWork.Complete();
        //    return Ok(User);
        //}
    }
}
