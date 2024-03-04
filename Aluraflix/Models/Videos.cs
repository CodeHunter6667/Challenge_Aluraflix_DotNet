using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aluraflix.Models;

[Table("tb_videos")]
public class Videos
{
    public long Id { get; set; }
    public string? Titulo { get; set; }
    public string? Descricao { get; set; }
    public string? Url { get; set; }

    public Videos()
    {

    }
}