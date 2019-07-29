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
    public class PositionRepository : Repository<position>, IPositionRepository
    {
        public PositionRepository(DbContext context) : base(context)
        {
        }
    }
}
