using TrabalhoFinalAndrew.Models;
using Microsoft.EntityFrameworkCore;

namespace TrabalhoFinalAndrew
{
    public class Context : DbContext
    {
        public DbSet<Album> Album { get; set; }

        public DbSet<Fotos> Fotos { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }

        public DbSet<Pessoa_Fotos> Pessoas_Fotos { get; set; }

        public Context(DbContextOptions<Context> opt) : base(opt)
        {
        }
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder
                .Entity<Pessoas_Fotos>()
                .HasKey(f => f.Fotos)
                .HasKey(p => p.Pessoas)
                .On
                /*.HasAlternateKey(x => x.Fotos)
                .HasOne(e => e.Pessoa)
                .WithMany(e => e.Fotos)
                .OnUpdate(up)
                .OnDelete(DeleteBehavior.ClientCascade);*/

        internal void SavedChanges() => throw new NotImplementedException();
}
}
