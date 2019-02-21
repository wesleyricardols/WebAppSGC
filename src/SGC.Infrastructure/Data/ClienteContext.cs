using Microsoft.EntityFrameworkCore;
using SGC.ApplicationCore.Entity;

namespace SGC.Infrastructure.Data
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
        {

        }


        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Contato>().ToTable("Contato");

            #region Configurações de Cliente

            modelBuilder.Entity<Cliente>().Property(__cliente => __cliente.CPF)
                .HasColumnType("VARCHAR(11)")
                .IsRequired();
            modelBuilder.Entity<Cliente>().Property(__cliente => __cliente.Nome)
                .HasColumnType("VARCHAR(200)")
                .IsRequired();

            #endregion
            
            #region Configurações de Contato

            modelBuilder.Entity<Contato>().Property(__contato => __contato.Nome)
                .HasColumnType("VARCHAR(200)")
                .IsRequired();
            modelBuilder.Entity<Contato>().Property(__contato => __contato.Email)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();
            modelBuilder.Entity<Contato>().Property(__contato => __contato.Telefone)
                .HasColumnType("VARCHAR(15)");

            #endregion
        }
    }
}
