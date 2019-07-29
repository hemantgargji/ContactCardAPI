using Contact.DataAccess.Models;
using Contact.DataAccess.IRepositories;
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
        private readonly IOrganisationRepository _userOrganisationRepository;
        private readonly IPositionRepository _userPositionRepository;
        private readonly IAddressRepository _userAddressRepository;
        public UserController( IUserRepository userrepository, IOrganisationRepository userOrganisationRepository,
        IPositionRepository userPositionRepository,
       IAddressRepository  userAddressRepository )
        {
            _userRepository = userrepository;
            _userOrganisationRepository = userOrganisationRepository;
            _userPositionRepository = userPositionRepository;
            _userAddressRepository = userAddressRepository;
        }


        [HttpGet]
        [Route("getUsers/{id}")]
        public  IHttpActionResult GetUsersByID( string id)
        {
                var users = _userRepository.GetByID(Convert.ToInt32(id));
                return Ok(users);
        }

        [HttpGet]
        [Route("getUsers")]
        public IHttpActionResult GetAllUsers()
        {
            var users = _userRepository.GetAll().ToList();
            var data = users.Select(x => new
            {
                Firstname = x.first_name

            });
            return Ok(data);
        }

        [HttpDelete]
        [Route("deleteUsers/{id}")]
        public IHttpActionResult DeleteUsers(string id)
        {
            _userRepository.Delete(Convert.ToInt32(id));
            return Ok(200);
        }


    }
}
