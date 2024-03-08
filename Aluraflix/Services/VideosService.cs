using Aluraflix.Context;
using Aluraflix.DTOs;
using Aluraflix.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Aluraflix.Services;

public class VideosService : IVideosService
	{

    private readonly IMapper _mapper;
    private AppDbContext _context;

		public VideosService(IMapper mapper, AppDbContext context)
		{
        _mapper = mapper;
        _context = context;
		}

    public VideosDTO Add(VideosDTO entity)
    {
        var video = _mapper.Map<Videos>(entity);
        if(video.CategoriaId == 0)
        {
            video.CategoriaId = 1;
        }
        _context.Add(video);
        Commit();
        var videoDto = _mapper.Map<VideosDTO>(video);
        return videoDto;
    }

    public void Commit()
    {
        _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public void Delete(long id)
    {
        var video = _context.Videos.Find(id);
        _context.Videos.Remove(video);
        Commit();
    }

    public IEnumerable<VideosDTO> GetAll(int skip, int take)
    {
        List<Videos> videos = _context.Videos.AsNoTracking().Skip(skip).Take(take).ToList();
        var videosDTO = _mapper.Map<List<VideosDTO>>(videos);
        return videosDTO;
    }

    public VideosDTO GetById(long id)
    {
        var video = _context.Videos.FirstOrDefault(e => e.Id == id);
        var videoDto = _mapper.Map<VideosDTO>(video);
        return videoDto;
    }

    public VideosDTO Update(long id, VideosDTO entity)
    {
        var video = _context.Videos.FirstOrDefault(e => e.Id == id);
        video = _mapper.Map<Videos>(entity);
        _context.Videos.Update(video);
        Commit();
        var videoDto = _mapper.Map<VideosDTO>(video);
        return videoDto;
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

