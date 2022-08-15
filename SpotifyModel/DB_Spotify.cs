using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SpotifyModel
{
    public partial class DB_Spotify : DbContext
    {
        public DB_Spotify()
            : base("name=DB_Spotifys")
        {
        }

        public virtual DbSet<Album> Album { get; set; }
        public virtual DbSet<Authority> Authority { get; set; }
        public virtual DbSet<comment> comment { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Identity> Identity { get; set; }
        public virtual DbSet<Music> Music { get; set; }
        public virtual DbSet<MusicType> MusicType { get; set; }
        public virtual DbSet<Operation> Operation { get; set; }
        public virtual DbSet<PlaybackRecord> PlaybackRecord { get; set; }
        public virtual DbSet<PlayList> PlayList { get; set; }
        public virtual DbSet<PlayListDetails> PlayListDetails { get; set; }
        public virtual DbSet<Resources> Resources { get; set; }
        public virtual DbSet<Singer> Singer { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<VipRecord> VipRecord { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>()
                .Property(e => e.AlbumContent)
                .IsUnicode(false);

            modelBuilder.Entity<Album>()
                .HasMany(e => e.Music)
                .WithRequired(e => e.Album)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Authority>()
                .Property(e => e.Authority1)
                .IsFixedLength();

            modelBuilder.Entity<comment>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Genre>()
                .Property(e => e.GenreContent)
                .IsUnicode(false);

            modelBuilder.Entity<Identity>()
                .HasMany(e => e.Authority)
                .WithRequired(e => e.Identity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Music>()
                .Property(e => e.Lyric)
                .IsUnicode(false);

            modelBuilder.Entity<Music>()
                .Property(e => e.VipMusic)
                .IsFixedLength();

            modelBuilder.Entity<Music>()
                .HasMany(e => e.MusicType)
                .WithRequired(e => e.Music)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Music>()
                .HasMany(e => e.PlaybackRecord)
                .WithRequired(e => e.Music)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Music>()
                .HasMany(e => e.PlayListDetails)
                .WithRequired(e => e.Music)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MusicType>()
                .Property(e => e.MusicFile)
                .IsUnicode(false);

            modelBuilder.Entity<Operation>()
                .HasMany(e => e.Authority)
                .WithRequired(e => e.Operation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PlayList>()
                .Property(e => e.ListContent)
                .IsUnicode(false);

            modelBuilder.Entity<PlayList>()
                .HasMany(e => e.PlayListDetails)
                .WithRequired(e => e.PlayList)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resources>()
                .HasMany(e => e.Authority)
                .WithRequired(e => e.Resources)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Singer>()
                .HasMany(e => e.Album)
                .WithRequired(e => e.Singer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Singer>()
                .HasMany(e => e.Music)
                .WithRequired(e => e.Singer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Telephone)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .HasMany(e => e.PlaybackRecord)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.PlayList)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.VipRecord)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
