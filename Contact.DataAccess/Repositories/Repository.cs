using Contact.DataAccess.IRepositories;
using Contact.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contact.DataAccess.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        internal DbContext _context;
        internal DbSet<TEntity> _dbSet;
        internal DbSet<user> _dbsetuser;
        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
            _dbsetuser= context.Set<user>();
        }

        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }
        public virtual TEntity GetByID(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Delete(int id)
        {
            TEntity entityToDelete = _dbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
        //    if (_context.Entry(entityToDelete).State == EntityState.Detached)
        //    {
            //    _dbSet.Attach(entityToDelete);
          //  }
            _dbSet.Remove(entityToDelete);
            _context.SaveChanges();
        }

        public virtual void Save(user entity)
        {
            if (entity != null)
            {
                var Useraddress = new address()
                {
                    id = entity.address.id,
                    address_type = entity.address.address_type,
                    state_id = entity.address.state_id,
                    pincode = entity.address.pincode,
                    street = entity.address.street,
                    street_2 = entity.address.street_2
                };
                var user1 = new user()
                {
                    first_name = entity.first_name,
                    last_name = entity.last_name,
                    address_id = entity.address_id,
                    position_id = entity.position_id,
                    organisation_id = entity.organisation_id,
                    mob_no = entity.mob_no,
                    alt_mob_no = entity.alt_mob_no,
                    email = entity.email,
                    address = Useraddress
                };
                _dbsetuser.Add(entity);
                _context.SaveChanges();
            }       
        }
        public virtual void Update(user entity,int id)
        {
          var user= _dbsetuser.Find(id);
           
            if (entity != null)
            {               
                user.address.address_type = entity.address.address_type;
                user.address.state_id = entity.address.state_id;
                user.address.pincode = entity.address.pincode;
                user.address.street = entity.address.street;
                user.address.street_2 = entity.address.street_2;

                user.first_name = entity.first_name;
                user.last_name = entity.last_name;
                //user.address_id = entity.address_id;
                user.position_id = entity.position_id;
                user.organisation_id = entity.organisation_id;
                user.mob_no = entity.mob_no;
                user.alt_mob_no = entity.alt_mob_no;
                user.email = entity.email;
                

                _context.SaveChanges();
            }



        }
    }
}
