using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC.ApplicationCore.Entity;

namespace SGC.Infrastructure.EntityConfig
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(__cliente => __cliente.ClienteId);

            builder
                .HasMany(__cliente => __cliente.Contatos)
                .WithOne(__cliente => __cliente.Cliente)
                .HasForeignKey(__cliente => __cliente.ClienteId)
                .HasPrincipalKey(__cliente => __cliente.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(__cliente => __cliente.Endereco)
                .WithOne(__cliente => __cliente.Cliente)
                .HasForeignKey<Endereco>(__cliente => __cliente.ClienteId);

            builder.
                Property(__cliente => __cliente.CPF)
                .HasColumnType("VARCHAR(11)")
                .IsRequired();

            builder.
                Property(__cliente => __cliente.Nome)
                .HasColumnType("VARCHAR(200)")
                .IsRequired();
        }
    }
}
