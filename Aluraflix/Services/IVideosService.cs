using System;
using System.Linq.Expressions;
using Aluraflix.DTOs;

namespace Aluraflix.Services
{
	public interface IVideosService
	{
		IEnumerable<VideosDTO> GetAll(int skip, int take);
		VideosDTO GetById(long id);
		VideosDTO Add(VideosDTO entity);
		VideosDTO Update(long id, VideosDTO entity);
		void Delete(long id);
		void Commit();
	}
}

