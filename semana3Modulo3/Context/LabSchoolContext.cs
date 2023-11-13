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
        modelBuilder.ApplyConfiguration(new PedagogoConfig());
        modelBuilder.ApplyConfiguration(new ProfessorConfig());

        //Alunos
        modelBuilder.Entity<Aluno>().HasData(
                new Aluno
                {
                    Codigo = 1,
                    Nome = "Bart Simpson",
                    Telefone = "11-11111-1212",
                    CPF = "01234567890",
                    Situacao = "Irregular",
                    Nota = 3.5f,
                    QtdAtendimento = 0,
                    DataDeNascimento = new DateTime (1979,10,10)

                },   
                new Aluno
                {
                    Codigo = 2,
                    Nome = "Lisa Simpson",
                    Telefone = "11-2222-1212",
                    CPF = "01234566844",
                    Situacao = "Ativo",
                    Nota = 10,
                    QtdAtendimento = 0,
                    DataDeNascimento = new DateTime (1981,07,10)

                },
                new Aluno
                {
                    Codigo = 3,
                    Nome = "Marge Simpson",
                    Telefone = "12-7658-1292",
                    CPF = "01268785409",
                    Situacao = "Ativo",
                    Nota = 9,
                    QtdAtendimento = 0,
                    DataDeNascimento = new DateTime (1965,08,11)                   

                }, new Aluno
                {
                    Codigo = 4,
                    Nome = "Milhouse Van Houten",
                    Telefone = "12-7658-4444",
                    CPF = "01268788888",
                    Situacao = "Ativo",
                    Nota = 8,
                    QtdAtendimento = 0,
                    DataDeNascimento = new DateTime (1981,05,30)
                }, new Aluno
                {
                    Codigo = 5,
                    Nome = "Nelson Muntz",
                    Telefone = "14-7777-1292",
                    CPF = "04444485409",
                    Situacao = "Inativo",
                    Nota = 2,
                    QtdAtendimento = 0,
                    DataDeNascimento = new DateTime (1975,12,10)
                }
            );

        modelBuilder.Entity<Professor>().HasData(
                new Professor
                {
                    Codigo = 1,
                    Nome = "Walter White",
                    Telefone = "11-11111-1212",
                    CPF = "4053901190",
                    Estado = "Ativo",
                    Experiencia = "FullStack",
                    FormacaoAcademica = "Mestrado",
                    DataDeNascimento = new DateTime (1982,10,30)
                },  new Professor               
                {
                    Codigo = 2,
                    Nome = "Jesse Pinkman",
                    Telefone = "44-12311-1212",
                    CPF = "4053909990",
                    Estado = "Ativo",
                    Experiencia = "BackEnd",
                    FormacaoAcademica = "Graduação Incompleta",
                    DataDeNascimento = new DateTime (1997,10,30)
                },  new Professor
                {
                    Codigo = 3,
                    Nome = "Hank Schrader",
                    Telefone = "11-99999-1212",
                    CPF = "8883901190",
                    Estado = "Ativo",
                    Experiencia = "FullStack",
                    FormacaoAcademica = "Mestrado",
                    DataDeNascimento = new DateTime (1984,03,31)
                },  new Professor
                {
                    Codigo = 4,
                    Nome = "Gustavo Fring",
                    Telefone = "11-11111-8888",
                    CPF = "4012301190",
                    Estado = "Inativo",
                    Experiencia = "FullStack",
                    FormacaoAcademica = "Doutorado",
                    DataDeNascimento = new DateTime (1980,09,10)
                },  new Professor
                {
                    Codigo = 5,
                    Nome = "Saul Goodman",
                    Telefone = "44-19999-1212",
                    CPF = "4053909990",
                    Estado = "Ativo",
                    Experiencia = "FullStack",
                    FormacaoAcademica = "Mestrado",
                    DataDeNascimento = new DateTime (1988,03,04)
                }
            );

             modelBuilder.Entity<Pedagogo>().HasData(
                new Pedagogo
                {
                    Codigo = 1,
                    Nome = "John Snow",
                    Telefone = "11-67333-4454",
                    CPF = "4053901190",
                    QtdAtendimento = 0,
                    DataDeNascimento = new DateTime (2000,07,10)
                   
                }, new Pedagogo  {
                    Codigo = 2,
                    Nome = "Sansa Stark",
                    Telefone = "22-22333-3454",
                    CPF = "767659875965",
                    QtdAtendimento = 0,
                    DataDeNascimento = new DateTime (1981,07,10)
                   
                }, new Pedagogo  {
                    Codigo = 3,
                    Nome = "Tyrion Lannister",
                    Telefone = "33-77333-3454",
                    CPF = "09678646347",
                    QtdAtendimento = 0,
                    DataDeNascimento = new DateTime (2001,04,10)
                   
                }, new Pedagogo  {
                    Codigo = 4,
                    Nome = "Sandor Clegane",
                    Telefone = "44-22433-3004",
                    CPF = "76768887905",
                    QtdAtendimento = 0,
                    DataDeNascimento = new DateTime (2002,12,22)  
                }
            );

    }

    public DbSet<Aluno>? Alunos { get; set; }
    public DbSet<Pedagogo>? Pedagogos { get; set; }
    public DbSet<Professor>? Professores { get; set; }
}
