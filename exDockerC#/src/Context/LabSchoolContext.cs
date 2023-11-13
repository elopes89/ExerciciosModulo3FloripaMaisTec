using LabSchool.Models;
using LabSchool.Models.Configuration;
using Microsoft.EntityFrameworkCore;

namespace LabSchool.Context;

public class LabSchoolContext : DbContext
{
    public LabSchoolContext(DbContextOptions<LabSchoolContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AlunoConfig());

        //Alunos
        modelBuilder.Entity<Aluno>().HasData(
                new Aluno
                {
                    Codigo = 1,
                    Nome = "Bart Simpson",
                    DataDeNascimento = new DateTime(1979, 10, 10),
                    Email = "manu@gmail.com"

                },
                new Aluno
                {
                    Codigo = 2,
                    Nome = "Lisa Simpson",
                    DataDeNascimento = new DateTime(1981, 07, 10),
                    Email = "JonasManu@gmail.com"


                },
                new Aluno
                {
                    Codigo = 3,
                    Nome = "Marge Simpson",
                    DataDeNascimento = new DateTime(1965, 08, 11),
                    Email = "manuzinho@gmail.com"


                }, new Aluno
                {
                    Codigo = 4,
                    Nome = "Milhouse Van Houten",
                    DataDeNascimento = new DateTime(1981, 05, 30),
                    Email = "EuMesmo@gmail.com"

                }, new Aluno
                {
                    Codigo = 5,
                    Nome = "Nelson Muntz",
                    DataDeNascimento = new DateTime(1975, 12, 10),
                    Email = "manu@gmail.com"

                }
            );
    }

    public DbSet<Aluno>? Alunos { get; set; }
}
