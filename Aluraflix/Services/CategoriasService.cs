using System;
using Aluraflix.Context;
using Aluraflix.DTOs;
using Aluraflix.Models;
using AutoMapper;

namespace Aluraflix.Services
{
	public class CategoriasService : ICategoriasService
	{
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

		public CategoriasService(AppDbContext context, IMapper mapper)
		{
            _context = context;
            _mapper = mapper;
		}

        public CategoriasDTO Add(CategoriasDTO entity)
        {
            var categoria = _mapper.Map<Categorias>(entity);
            _context.Categorias.Add(categoria);
            Commit();
            var categoriaDto = _mapper.Map<CategoriasDTO>(categoria);
            return categoriaDto;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Delete(long id)
        {
            var categoria = _context.Categorias.FirstOrDefault(c => c.Id == id);
            _context.Categorias.Remove(categoria);

        }

        public List<CategoriasDTO> GetAll(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public CategoriasDTO GetBYId(long id)
        {
            throw new NotImplementedException();
        }

        public CategoriasDTO Update(long id, CategoriasDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}

