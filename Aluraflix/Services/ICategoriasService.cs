using System;
using Aluraflix.DTOs;

namespace Aluraflix.Services
{
	public interface ICategoriasService
	{
		List<CategoriasDTO> GetAll(int skip, int take);
		CategoriasDTO GetBYId(long id);
	    CategoriasDTO Add(CategoriasDTO entity);
		CategoriasDTO Update(long id, CategoriasDTO dto);
		void Delete(long id);
		void Commit();
	}
}

