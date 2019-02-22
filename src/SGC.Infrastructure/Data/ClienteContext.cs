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
            modelBuilder.Entity<Endereco>().ToTable("Endereco");
            modelBuilder.Entity<Profissao>().ToTable("Profissao");
            modelBuilder.Entity<ProfissaoCliente>().ToTable("ProfissaoCliente");

            #region Configurações de Cliente

            modelBuilder.Entity<Cliente>()
                .HasKey(__cliente => __cliente.ClienteId);

            modelBuilder.Entity<Cliente>()
                .HasMany(__cliente => __cliente.Contatos)
                .WithOne(__cliente => __cliente.Cliente)
                .HasForeignKey(__cliente => __cliente.ClienteId)
                .HasPrincipalKey(__cliente => __cliente.ClienteId) ;

            modelBuilder.Entity<Cliente>().Property(__cliente => __cliente.CPF)
                .HasColumnType("VARCHAR(11)")
                .IsRequired();

            modelBuilder.Entity<Cliente>().Property(__cliente => __cliente.Nome)
                .HasColumnType("VARCHAR(200)")
                .IsRequired();

            #endregion

            #region Configurações de Contato

            modelBuilder.Entity<Contato>()
                .HasOne(__contato => __contato.Cliente)
                .WithMany(__contato => __contato.Contatos)
                .HasForeignKey(__contato => __contato.ClienteId)
                .HasPrincipalKey(__contato => __contato.ClienteId);

            modelBuilder.Entity<Contato>().Property(__contato => __contato.Nome)
                .HasColumnType("VARCHAR(200)")
                .IsRequired();

            modelBuilder.Entity<Contato>().Property(__contato => __contato.Email)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();

            modelBuilder.Entity<Contato>().Property(__contato => __contato.Telefone)
                .HasColumnType("VARCHAR(15)");

            #endregion

            #region Configurações de Profissão

            modelBuilder.Entity<Profissao>().Property(__profissao => __profissao.Nome)
                .HasColumnType("varchar(400)")
                .IsRequired();

            modelBuilder.Entity<Profissao>().Property(__profissao => __profissao.CBO)
                .HasColumnType("varchar(10)")
                .IsRequired();

            modelBuilder.Entity<Profissao>().Property(__profissao => __profissao.Descrição)
                .HasColumnType("varchar(1000)")
                .IsRequired();

            #endregion

            #region Configurações de Endereço

            modelBuilder.Entity<Endereco>().Property(__endereco => __endereco.Bairro)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Endereco>().Property(__endereco => __endereco.Bairro)
                .HasColumnType("varchar(15)")
                .IsRequired();

            modelBuilder.Entity<Endereco>().Property(__endereco => __endereco.Logradouro)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Endereco>().Property(__endereco => __endereco.Referencia)
                .HasColumnType("varchar(400)");

            #endregion

            #region Configurações Profissão Cliente

            modelBuilder.Entity<ProfissaoCliente>()
                .HasKey(__profissaoCliente => __profissaoCliente.Id);

            modelBuilder.Entity<ProfissaoCliente>()
                .HasOne(__profissaoCliente => __profissaoCliente.Cliente)
                .WithMany(__profissaoCliente => __profissaoCliente.ProfissoesClientes)
                .HasForeignKey(__profissaoCliente => __profissaoCliente.ClienteId);

            modelBuilder.Entity<ProfissaoCliente>()
                .HasOne(__profissaoCliente => __profissaoCliente.Profissao)
                .WithMany(__profissaoCliente => __profissaoCliente.ProfissoesClientes)
                .HasForeignKey(__profissaoCliente => __profissaoCliente.ProfissaoId);

            #endregion

            #region Configurações Menu

            modelBuilder.Entity<Menu>()
                .HasMany(__menu => __menu.SubMenus)
                .WithOne()
                .HasForeignKey(__menu => __menu.MenuId);

            #endregion
        }
    }
}
