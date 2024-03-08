using System;
using System.ComponentModel.DataAnnotations;

namespace Aluraflix.DTOs
{
	public record CategoriasDTO(
		
		long id,
		[Required(ErrorMessage = "O campo Titulo é obrigatório")]
		[StringLength(100, MinimumLength = 5, ErrorMessage ="Titulo deve ter entre 5 e 100 caracteres")]
		string? titulo,
		[Required(ErrorMessage = "O campo Cor é obrigatório")]
		string? cor,

		List<VideosDTO> videos)
	{
		
	}
}

