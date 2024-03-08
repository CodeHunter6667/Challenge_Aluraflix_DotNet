using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aluraflix.Models;

[Table("tb_categorias")]
public class Categorias
{
	[Key]
	public long Id { get; set; }
	public string? Titulo { get; set; }
	public string? Cor { get; set; }
	public List<Videos> Videos { get; set; }

	public Categorias()
	{
		Videos = new List<Videos>();
	}
}

