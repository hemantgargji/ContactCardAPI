using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact.DAL.Models;
using Contact.DAL.IRepositories;
namespace Contact.DAL.Repositories
{
    public class OrganisationRepository : Repository<organisation>, IOrganisationRepository
    {
        public OrganisationRepository(DbContext context) : base(context)
        {
        }
    }
}
