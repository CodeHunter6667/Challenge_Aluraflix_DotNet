using System;
using AutoMapper;

namespace Aluraflix.DTOs.Mappings
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<VideosDTO, Models.Videos>().ReverseMap();
		}
	}
}

