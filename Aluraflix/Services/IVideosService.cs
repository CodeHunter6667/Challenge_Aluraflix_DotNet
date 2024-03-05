using System;
using System.Linq.Expressions;
using Aluraflix.Models;
using Aluraflix.Repository;

namespace Aluraflix.Services
{
	public interface IVideosService
	{
		IQueryable<Videos> GetAll();
		Task<Videos> GetById(Expression<Func<Videos, bool>> predicate);
		void Add(Videos entity);
		void Update(Videos entity);
		void Delete(Videos entity);
		Task Commit();
		IVideosRepository VideosRepository { get; }
	}
}

