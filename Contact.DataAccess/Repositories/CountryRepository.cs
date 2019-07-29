using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact.DataAccess.Models;
using Contact.DataAccess.IRepositories;
namespace Contact.DataAccess.Repositories
{
    public class CountryRepository : Repository<country>, ICountryRepository
    {
        public CountryRepository(DbContext context) : base(context)
        {
        }
    }
}
