using System;
using System.Linq.Expressions;
using Aluraflix.Context;
using Aluraflix.Models;
using Aluraflix.Repository;
using AutoMapper;

namespace Aluraflix.Services
{
	public class VideosService : IVideosService
	{
        private readonly IMapper _mapper;
        private VideosRepository _repository;
        private AppDbContext _context;

        public IVideosRepository VideosRepository
        {
            get
            {
                return _repository = _repository ?? new VideosRepository(_context);
            }
        }

		public VideosService(IMapper mapper, AppDbContext context)
		{
            _mapper = mapper;
            _context = context;
		}

        public void Add(Videos entity)
        {
            throw new NotImplementedException();
        }

        public Task Commit()
        {
            throw new NotImplementedException();
        }

        public void Delete(Videos entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Videos> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Videos> GetById(Expression<Func<Videos, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(Videos entity)
        {
            throw new NotImplementedException();
        }
    }
}

