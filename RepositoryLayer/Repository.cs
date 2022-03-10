using DomainLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _con;
        private DbSet<T> entities;
        public Repository(AppDbContext con)
        {
            _con = con;
            entities = _con.Set<T>();
        }
        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity");
            }
            entities.Remove(entity);
            _con.SaveChanges();

        }

        public IEnumerable<T> Getall()
        {
            return entities.AsEnumerable();
        }

        public T Get(int id)
        {
            return entities.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(T entity)
        {

            if (entity == null)
            {
                throw new ArgumentNullException("Entity");
            }
            entities.Add(entity);
            _con.SaveChanges();
        }

        public void Remove(T entity)
        {

            if (entity == null)
            {
                throw new ArgumentNullException("Entity");
            }
            entities.Remove(entity);
        }

        public void SaveChanges()
        {
            _con.SaveChanges();
        }

        public void Update(T entity)
        {

            if (entity == null)
            {
                throw new ArgumentNullException("Entity");
            }
            entities.Update(entity);
            _con.SaveChanges();
        }
    }
}
