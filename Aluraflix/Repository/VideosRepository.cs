using System;
using Aluraflix.Context;
using Aluraflix.Models;

namespace Aluraflix.Repository
{
	public class VideosRepository : Repository<Videos>, IVideosRepository
	{
		public VideosRepository(AppDbContext context) : base(context)
		{
		}
	}
}

