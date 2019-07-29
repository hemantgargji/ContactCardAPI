using Contact.DataAccess.Models;
using Contact.DataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.DataAccess.Repositories
{
    public class UserRepository : Repository<user>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {

        }
    }
}
