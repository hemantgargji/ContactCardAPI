using Contact.DataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Contact.DataAccess.Models;

namespace Contact.DataAccess.Repositories
{
    public class AddressRepository : Repository<address>, IAddressRepository
    {
        public AddressRepository(DbContext context) : base(context)
        {
        }
    }
}
