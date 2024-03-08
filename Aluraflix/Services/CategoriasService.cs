using System;
using Aluraflix.Context;
using Aluraflix.DTOs;
using Aluraflix.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

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

        public CategoriasMinDTO Add(CategoriasMinDTO entity)
        {
            var categoria = _mapper.Map<Categorias>(entity);
            _context.Categorias.Add(categoria);
            Commit();
            var categoriaDto = _mapper.Map<CategoriasMinDTO>(categoria);
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
            Commit();
        }

        public List<CategoriasMinDTO> GetAll(int skip, int take)
        {
            List<Categorias> categorias = _context.Categorias.AsNoTracking().Skip(skip).Take(take).ToList();
            var categoriasDto = _mapper.Map<List<CategoriasMinDTO>>(categorias);
            return categoriasDto;
        }

        public CategoriasDTO GetBYId(long id)
        {
            var categoria = _context.Categorias.FirstOrDefault(c => c.Id == id);
            var categoriaDto = _mapper.Map<CategoriasDTO>(categoria);
            return categoriaDto;
        }

        public CategoriasMinDTO Update(long id, CategoriasMinDTO dto)
        {
            var categoria = _context.Categorias.FirstOrDefault(c => c.Id == id);
            categoria = _mapper.Map<Categorias>(dto);
            _context.Categorias.Update(categoria);
            Commit();
            var categoriaDto = _mapper.Map<CategoriasMinDTO>(categoria);
            return categoriaDto;
        }

        public IEnumerable<VideosDTO> GetVideosByCategoria(long id)
        {
            var videosQuery =
                from Videos in _context.Videos
                where Videos.CategoriaId == id
                select Videos;

            var videosDto = _mapper.Map<List<VideosDTO>>(videosQuery.ToList());
            return videosDto;
        }
    }
}

