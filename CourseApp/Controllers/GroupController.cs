using System;
using Serilog;
using AutoMapper;
using Service.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Service.DTOs.Group;
using Domain.Entity;

namespace CourseApp.Controllers
{
	public class GroupController : BaseController
	{
		private readonly IGroupService _groupService;
		private readonly IMapper _mapper;
		public GroupController(IGroupService groupService,
			IMapper mapper)
		{
			_groupService = groupService;
			_mapper = mapper;
		}

		[HttpPost]
		public async Task<IActionResult> Create([FromForm]GroupCreateDto request)
		{
			if (!ModelState.IsValid) return BadRequest(ModelState);
			var mappedGroup = _mapper.Map<Group>(request);
			await _groupService.Create(mappedGroup);
			return CreatedAtAction(nameof(Create), request);
		}
	}
}

