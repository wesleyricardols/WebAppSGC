using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC.ApplicationCore.Entity;

namespace SGC.Infrastructure.EntityConfig
{
    public class ProfissaoClienteMap : IEntityTypeConfiguration<ProfissaoCliente>
    {
        public void Configure(EntityTypeBuilder<ProfissaoCliente> builder)
        {
            builder.HasKey(__profissaoCliente => __profissaoCliente.Id);

            builder
                .HasOne(__profissaoCliente => __profissaoCliente.Cliente)
                .WithMany(__profissaoCliente => __profissaoCliente.ProfissoesClientes)
                .HasForeignKey(__profissaoCliente => __profissaoCliente.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(__profissaoCliente => __profissaoCliente.Profissao)
                .WithMany(__profissaoCliente => __profissaoCliente.ProfissoesClientes)
                .HasForeignKey(__profissaoCliente => __profissaoCliente.ProfissaoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
