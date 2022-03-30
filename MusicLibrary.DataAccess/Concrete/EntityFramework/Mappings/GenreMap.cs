using MusicLibrary.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicLibrary.DataAccess.Concrete.EntityFramework.Mappings
{
    public class GenreMap : EntityTypeConfiguration<Genre>
    {
        public GenreMap()
        {
            ToTable("Genres");
            HasKey(g => g.Id);

            Property(g => g.Name).HasColumnName("Name");
            Property(g => g.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}
