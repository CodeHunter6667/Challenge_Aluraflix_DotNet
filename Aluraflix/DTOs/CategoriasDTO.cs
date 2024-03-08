using System;
using System.ComponentModel.DataAnnotations;

namespace Aluraflix.DTOs
{
	public record CategoriasDTO(long id, string? titulo, string? cor, List<VideosDTO> videos)
	{
		
	}
}

