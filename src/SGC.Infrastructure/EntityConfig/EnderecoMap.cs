using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC.ApplicationCore.Entity;

namespace SGC.Infrastructure.EntityConfig
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder
                .Property(__endereco => __endereco.Bairro)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder
                .Property(__endereco => __endereco.Bairro)
                .HasColumnType("varchar(15)")
                .IsRequired();

            builder
                .Property(__endereco => __endereco.Logradouro)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder
                .Property(__endereco => __endereco.Referencia)
                .HasColumnType("varchar(400)");
        }
    }
}
