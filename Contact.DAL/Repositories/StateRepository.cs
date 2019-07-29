﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact.DAL.Models;
using Contact.DAL.IRepositories;
namespace Contact.DAL.Repositories
{
    public class StateRepository : Repository<state>, IStateRepository
    {
        public StateRepository(DbContext context) : base(context)
        {
        }
    }
}