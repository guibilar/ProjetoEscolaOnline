using AutoMapper;
using OnlineSchool.App.ViewModels;
using OnlineSchool.Busness.Academico.Models;
using OnlineSchool.Busness.Models;

namespace OnlineSchool.App.Automapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Carreira, CarreiraViewModel>().ReverseMap();
            CreateMap<Curso, CursoViewModel>().ReverseMap();
            CreateMap<MaterialDeApoio, MaterialDeApoioViewModel>().ReverseMap();
            CreateMap<Pessoa, PessoaViewModel>().ReverseMap();
        }
    }
}
