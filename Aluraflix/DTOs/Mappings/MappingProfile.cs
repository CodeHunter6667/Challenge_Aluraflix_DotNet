using System;
using Aluraflix.Models;
using AutoMapper;

namespace Aluraflix.DTOs.Mappings
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<VideosDTO, Videos>().ReverseMap();
			CreateMap<CategoriasDTO, Categorias>().ReverseMap();
			CreateMap<CategoriasMinDTO, Categorias>().ReverseMap();
		}
	}
}

