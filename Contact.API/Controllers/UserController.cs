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
        public UserController()
        {

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
            return Ok(users);
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
