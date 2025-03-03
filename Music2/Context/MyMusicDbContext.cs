using Music2.Models.Auth;
using System.Collections.Generic;
using System.Reflection.Emit;
using MyMusic.Core.Models;
using MyMusic.Core.Models.Auth;
using MyMusic.Data.Configurations;

namespace Music2.Context
{
    public class MyMusicDbContext : IdentityDbContext<User, Role, Guid>
    {
        public DbSet<Music> Musics { get; set; }
        public DbSet<Artist> Artists { get; set; }

        public MyMusicDbContext(DbContextOptions<MyMusicDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder
                .ApplyConfiguration(new MusicConfiguration());

            builder
                .ApplyConfiguration(new ArtistConfiguration());
        }
    }
}
