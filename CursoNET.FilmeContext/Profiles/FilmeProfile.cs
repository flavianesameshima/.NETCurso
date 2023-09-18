using AutoMapper;
using CursoNET.FilmeContext.Model;
using FilmesApi.Domain;

namespace CursoNET.FilmeContext.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<FilmeDTO, Filme>();
        }
    }
}
