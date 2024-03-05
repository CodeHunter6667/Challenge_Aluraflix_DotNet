using System;
using System.ComponentModel.DataAnnotations;

namespace Aluraflix.DTOs
{
	public record VideosDTO(
		long id,
		[Required(ErrorMessage = "O campo Titulo é obrigatório")]
		[StringLength(100, MinimumLength = 5, ErrorMessage = "O Titulo deve ter entre 5 e 100 caracteres")]
		string titulo,
		[Required(ErrorMessage = "O campo Descricao é obrigatório")]
		[StringLength(150, MinimumLength = 5, ErrorMessage = "A Descricao deve ter entre 5 e 150 caracteres")]
		string descricao,
		[Required(ErrorMessage = "O campo Url é obrigatório")]
		[StringLength(300, MinimumLength = 5, ErrorMessage = "A Url deve ter entre 5 e 300 caracteres")]
		string url)
	{
		
	}
}

