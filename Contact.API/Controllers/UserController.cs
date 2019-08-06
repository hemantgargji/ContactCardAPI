using Contact.DataAccess.Models;
using Contact.DataAccess.IRepositories;
using Contact.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Contact.WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserController : ApiController, IContact
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
            try
            {
                var users = _userRepository.GetByID(Convert.ToInt32(id));
                var data = new user();
                data.id = users.id;
                data.first_name = users.first_name;
                data.last_name = users.last_name;
                data.isDeleted = users.isDeleted;
                data.mob_no = users.mob_no;
                data.organisation_id = users.organisation_id;
                data.position_id = users.position_id;
                data.alt_mob_no = users.alt_mob_no;
                data.email = users.email;
                data.address_id = users.address_id;
                return Ok(data);
            }
            catch
            {
                return NotFound();
            }
               
        }

        [HttpGet]
        [Route("getAllUsers")]
        public IHttpActionResult GetAllUsers()
        {
            try
            {
                var users = _userRepository.GetAll().ToList();
                var data = users.Where(x=>x.isDeleted == null || x.isDeleted == false).Select(x => new
                {
                    Id = x.id,
                    FirstName = x.first_name,
                    LastName = x.last_name,
                    isDeleted = x.isDeleted,
                    MobileNo = x.mob_no,
                    OrgansationID = x.organisation_id,
                    PositionID = x.position_id,
                    Alt_MobileNO = x.alt_mob_no,
                    Email = x.email,
                    AddressID = x.address_id

                }).ToList();
                return Ok(data);
            }
            catch
            {
                return NotFound();
            }
           
        }

        [HttpDelete]
        [Route("deleteUsers/{id}")]
        public IHttpActionResult DeleteUsers(string id)
        {
            try
            {
                _userRepository.Delete(Convert.ToInt32(id));
                return Ok(200);
            }
            catch
            {
              return  NotFound();
            }
            
        }
        [HttpPost]
        [Route("createUser")]
        public IHttpActionResult CreateUsers([FromBody]user user)
        {
            try
            {                
                _userRepository.Save(user);
                return Ok(200);
            }
            catch(Exception ex)
            {
                return NotFound();
            }

        }
        [HttpPut]
        [Route("updateUser")]
        public IHttpActionResult UpdateUsers([FromBody]user user,string id)
        {
            try
            {
               
                _userRepository.Update(user, Convert.ToInt32(id));
                return Ok(200);
            }
            catch (Exception ex)
            {
                return NotFound();
            }

        }
    }
}
