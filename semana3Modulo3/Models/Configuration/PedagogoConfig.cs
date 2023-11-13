using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabSchool.Models.Configuration;

public class PedagogoConfig : IEntityTypeConfiguration<Pedagogo>
{
    public void Configure(EntityTypeBuilder<Pedagogo> builder)
    {
        builder.HasKey(x => x.Codigo);

        builder.ToTable("Pedagogo");
    }
}
