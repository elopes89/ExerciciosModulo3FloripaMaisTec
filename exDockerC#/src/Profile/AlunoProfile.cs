namespace LabSchool.Profile;
using AutoMapper;
using LabSchool.Dtos;
using LabSchool.Models;

public class AlunoProfile : Profile
{

    public AlunoProfile()
    {

        CreateMap<AlunoCreateDto, Aluno>()
                .ForMember(
                    dest => dest.Nome,
                    opt => opt.MapFrom(src => src.Nome)
                ).ForMember(
                    dest => dest.DataDeNascimento,
                    opt => opt.MapFrom(src => src.DataDeNascimento) 
                ).ForMember(
                    dest => dest.Email,
                    opt => opt.MapFrom(src => src.Email) 
                );

        CreateMap<Aluno, AlunoSaidaDto>()
            .ForMember(
                dest => dest.Codigo,
                opt => opt.MapFrom(src => src.Codigo)
            ).ForMember(
                d => d.Nome,
                opt => opt.MapFrom(src => src.Nome)
               );

    }

}