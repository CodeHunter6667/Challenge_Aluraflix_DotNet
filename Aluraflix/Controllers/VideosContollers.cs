using System;
using Aluraflix.DTOs;
using Aluraflix.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Aluraflix.Controllers
{
	[ApiController]
	[Route("/videos")]
	public class VideosContollers : ControllerBase
	{
		private readonly IMapper _mapper;
		private readonly IVideosService _service;

		public VideosContollers(IMapper mapper, IVideosService service)
		{
			_mapper = mapper;
			_service = service;
		}

		[HttpGet]
		public ActionResult<IEnumerable<VideosDTO>> GetAll([FromQuery] int skip = 0,[FromQuery] int take = 5)
		{
			var videos = _service.GetAll(skip, take);
			return Ok(videos);
		}

		[HttpGet("{id:long}")]
		public ActionResult<VideosDTO> GetById(long id)
		{
			var video = _service.GetById(id);
			if(video == null)
			{
				NotFound();
			}
			return Ok(video);
		}

		[HttpPost]
		public ActionResult<VideosDTO> Post([FromBody] VideosDTO dto)
		{
			if(dto == null)
			{
				return BadRequest();
			}

			var video = dto;
			_service.Add(video);

			return CreatedAtAction(nameof(GetById), new { video.id }, video);
		}

		[HttpPut("{id:long}")]
		public ActionResult<VideosDTO> Post(long id, VideosDTO dto)
		{
			var video = _service.GetById(id);
			if(video == null)
			{
				return NotFound();
			} else if(dto == null)
			{
				return BadRequest();
			}
			var videoDto = _service.Update(id, dto);
			return Ok(videoDto);
		}

		[HttpDelete("{id:long}")]
		public ActionResult Delete(long id)
		{
			var video = _service.GetById(id);
			if(video == null)
			{
				return NotFound();
			}
			_service.Delete(id);
			return NoContent();
		}
	}
}

