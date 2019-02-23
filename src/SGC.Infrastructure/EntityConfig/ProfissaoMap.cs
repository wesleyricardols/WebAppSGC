using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC.ApplicationCore.Entity;

namespace SGC.Infrastructure.EntityConfig
{
    public class ProfissaoMap : IEntityTypeConfiguration<Profissao>
    {
        public void Configure(EntityTypeBuilder<Profissao> builder)
        {
            builder
                .Property(__profissao => __profissao.Nome)
                .HasColumnType("varchar(400)")
                .IsRequired();

            builder.Property(__profissao => __profissao.CBO)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder
                .Property(__profissao => __profissao.Descrição)
                .HasColumnType("varchar(1000)")
                .IsRequired();
        }
    }
}
