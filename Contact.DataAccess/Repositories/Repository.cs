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

        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
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

        public virtual void Save(TEntity entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }
        public virtual void Update(UserViewModel entity,int id)
        {

            using (ContactBusinessCardEntities db = new ContactBusinessCardEntities())
            {
                var existinguser = db.users.FirstOrDefault(e => e.id == id);
                if (existinguser != null)
                {
                    existinguser.first_name = entity.first_name;
                    existinguser.last_name = entity.last_name;
                    existinguser.address_id = entity.address_id;
                    existinguser.position_id = entity.position_id;
                    existinguser.organisation_id = entity.organisation_id;
                    existinguser.mob_no = entity.mob_no;
                    existinguser.alt_mob_no = entity.alt_mob_no;
                    existinguser.email = entity.email;
                    
                    db.SaveChanges();

                }


            }
        }
    }
}
