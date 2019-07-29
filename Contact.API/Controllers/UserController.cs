using Contact.DAL.Models;
using Contact.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;


namespace Contact.WebAPI.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserRepository _userRepository;
        public UserController()
        {
            
        }

        [HttpGet]
        [Route("getUsers")]
        public async Task<IHttpActionResult> GetUsers()
        {
            var users = _userRepository.GetAll().ToList();
            return Ok(users);
        }

        [HttpPost]
        [Route("addUser")]
        public async Task<IHttpActionResult> AddUser()
        {
            return Ok(200);
        }
    }
}
