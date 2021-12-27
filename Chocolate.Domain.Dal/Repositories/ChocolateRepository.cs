using Chocolate.Domain.Core.Abstracts;
using Chocolate.Domain.Dal.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolate.Domain.Dal.Repositories
{
    public class ChocolateRepository : IChocolateRepository
    {
        private readonly ChocolateDataContext _context;

        public ChocolateRepository(ChocolateDataContext context)
        {
            _context = context;
        }

        public T Add<T>(T entity) where T : class =>
         _context.Set<T>().Add(entity).Entity;

        public T Find<T>(int id) where T : class =>
            _context.Set<T>().Find(id);

        public IQueryable<T> Query<T>() where T : class =>
            _context.Set<T>();

        public void Remove<T>(T entity) where T : class =>
            _context.Set<T>().Remove(entity);

        public Task SaveChangesAsync() =>
            _context.SaveChangesAsync();

        public void SaveChanges() =>
            _context.SaveChanges();
    }
}
