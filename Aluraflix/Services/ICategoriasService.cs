using System;
using Aluraflix.DTOs;

namespace Aluraflix.Services
{
	public interface ICategoriasService
	{
		List<CategoriasMinDTO> GetAll(int skip, int take);
		CategoriasDTO GetBYId(long id);
	    CategoriasMinDTO Add(CategoriasMinDTO entity);
		CategoriasMinDTO Update(long id, CategoriasMinDTO dto);
		void Delete(long id);
		void Commit();
	}
}

