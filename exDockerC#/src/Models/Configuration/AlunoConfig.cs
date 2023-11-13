using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabSchool.Models.Configuration;

public class AlunoConfig : IEntityTypeConfiguration<Aluno>
{
    public void Configure(EntityTypeBuilder<Aluno> builder)
    {

        builder.HasKey(x => x.Codigo);
        builder.Property(x => x.Nome)
        .HasColumnType("varchar(50)")
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(x => x.DataDeNascimento)
        .IsRequired();

        builder.ToTable("Aluno");
    }
}

