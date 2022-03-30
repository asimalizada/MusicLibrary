using MusicLibrary.Entities.Concrete;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicLibrary.DataAccess.Concrete.EntityFramework.Mappings
{
    public class MusicMap : EntityTypeConfiguration<Music>
    {
        public MusicMap()
        {
            ToTable("Musics");
            HasKey(m => m.Id);

            Property(m => m.Name).HasColumnName("Name");
            Property(m => m.GenreId).HasColumnName("GenreId");
            Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}
