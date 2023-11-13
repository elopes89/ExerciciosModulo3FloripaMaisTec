namespace LabSchool.Profile;
using AutoMapper;
using LabSchool.Dtos;
using LabSchool.Models;

public class AlunoProfile : Profile {

    public AlunoProfile(){

        CreateMap<AlunoCreateDto, Aluno>()
                .ForMember(
                    dest => dest.Nome,
                    opt => opt.MapFrom(src => src.Nome)
                )
                .ForMember(
                    dest => dest.Telefone,
                    opt => opt.MapFrom(src => src.Telefone)
                ).ForMember(
                    dest => dest.DataDeNascimento,
                    opt => opt.MapFrom(src => src.DataDeNascimento)                    
                ).ForMember(
                    a => a.CPF,
                    opt => opt.MapFrom(b => b.CPF)
                ).ForMember(
                    a => a.Nota,
                    opt => opt.MapFrom(b => b.Nota)
                ).ForMember(
                    a => a.Situacao,
                    opt => opt.MapFrom(b => b.Situacao)
                );

                CreateMap<Aluno, AlunoSaidaDto>()
                    .ForMember(
                        dest => dest.Codigo,
                        opt => opt.MapFrom(src => src.Codigo)
                    ).ForMember(
                        d => d.Nome,
                        opt => opt.MapFrom(src => src.Nome)
                    ).ForMember(
                        dest => dest.Telefone,
                        opt => opt.MapFrom(src => src.Telefone)
                    ).ForMember(
                        dest => dest.DataDeNascimento,
                        opt => opt.MapFrom(src => src.DataDeNascimento)                    
                    ).ForMember(
                         a => a.CPF,
                         opt => opt.MapFrom(b => b.CPF)
                     ).ForMember(
                         a => a.Nota,
                         opt => opt.MapFrom(b => b.Nota)
                     ).ForMember(
                         a => a.Situacao,
                         opt => opt.MapFrom(b => b.Situacao)
                     ).ForMember(
                         d => d.QtdAtendimento,
                        opt => opt.MapFrom(src => src.QtdAtendimento)
                );
                
    }
    
}