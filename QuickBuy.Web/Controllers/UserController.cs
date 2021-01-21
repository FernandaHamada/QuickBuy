
using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Contracts;
using QuickBuy.Dominio.Entities;
using System;

namespace QuickBuy.Web.Controllers
{
    [Route("api/[Controller]")]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok();
            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPost("VerifyUser")]
        public ActionResult VerifyUser([FromBody] User user)
        {
            try
            {
                var returnUser = _userRepository.GetAll(user.Email, user.Password);
                if(returnUser != null)
                {
                    return Ok(returnUser);
                }
                return BadRequest("Invalid username or password");
            }catch(Exception ex){
                return BadRequest(ex.ToString());
            }
        }


        [HttpPost]
        public ActionResult Post()
        {
            try
            {
                return Ok();
            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
