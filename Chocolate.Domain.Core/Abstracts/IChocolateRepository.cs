using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolate.Domain.Core.Abstracts
{
    public interface IChocolateRepository
    {
        T Add<T>(T entity) where T : class;

        T Find<T>(int id) where T : class;

        IQueryable<T> Query<T>() where T : class;

        void Remove<T>(T entity) where T : class;

        void SaveChanges();

        Task SaveChangesAsync();
    }
}
