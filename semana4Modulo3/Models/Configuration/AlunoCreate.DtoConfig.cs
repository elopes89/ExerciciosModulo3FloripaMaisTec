using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabSchool.Models.Configuration;

public class AlunoCreateDtoConfig : IEntityTypeConfiguration<Aluno>
{
    public void Configure(EntityTypeBuilder<Aluno> builder)
    {
        builder.Property(x => x.Telefone)
        .HasColumnType("varchar(20)");

        builder.Property(x => x.Nome)
        .HasColumnType("varchar(50)")
        .HasMaxLength(50)
        .IsRequired();

        builder.HasIndex(x => x.CPF)
        .IsUnique();
        builder.Property(x => x.CPF)
        .IsRequired();

        builder.Property(x => x.Nota)
        .IsRequired();

        builder.Property(x => x.DataDeNascimento)
        .IsRequired();
        
    }
}

