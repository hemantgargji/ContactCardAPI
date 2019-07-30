using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Contact.API.Interfaces
{
    interface IContactMethods
    {
        IHttpActionResult GetUsersByID(string id);
        IHttpActionResult GetAllUsers();
        IHttpActionResult DeleteUsers(string id);
    }
}
