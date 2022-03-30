using Core.Entities.Abstract;
using System.Data.Entity;

namespace MusicLibrary.DataAccess.Extensions
{
    public static class DbSetExtensions
    {
        public static void Clear<T>(this DbSet<T> dbSet) where T : class, IEntity, new()
        {
            dbSet.RemoveRange(dbSet);
        }
    }
}
