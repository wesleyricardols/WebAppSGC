using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC.ApplicationCore.Entity;

namespace SGC.Infrastructure.EntityConfig
{
    public class ContatoMap : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder
                .HasOne(__contato => __contato.Cliente)
                .WithMany(__contato => __contato.Contatos)
                .HasForeignKey(__contato => __contato.ClienteId)
                .HasPrincipalKey(__contato => __contato.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(__contato => __contato.Nome)
                .HasColumnType("VARCHAR(200)")
                .IsRequired();

            builder
                .Property(__contato => __contato.Email)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();

            builder
                .Property(__contato => __contato.Telefone)
                .HasColumnType("VARCHAR(15)");
        }
    }
}
