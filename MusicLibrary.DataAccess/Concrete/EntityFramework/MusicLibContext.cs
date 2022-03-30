using MusicLibrary.DataAccess.Concrete.EntityFramework.Mappings;
using MusicLibrary.Entities.Concrete;
using System.Data.Entity;

namespace MusicLibrary.DataAccess.Concrete.EntityFramework
{
    public class MusicLibContext : DbContext
    {
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Music> Musics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GenreMap());
            modelBuilder.Configurations.Add(new MusicMap());
        }
    }
}
