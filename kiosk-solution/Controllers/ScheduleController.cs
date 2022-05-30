﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using kiosk_solution.Business.Services;
using kiosk_solution.Data.Responses;
using kiosk_solution.Data.ViewModels;
using kiosk_solution.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace kiosk_solution.Controllers
{
    [Route("api/v{version:apiVersion}/schedules")]
    [ApiController]
    [ApiVersion("1")]
    public class ScheduleController : Controller
    {
        private readonly IScheduleService _scheduleService;
        private readonly ILogger<ScheduleController> _logger;
        private IConfiguration _configuration;
        public ScheduleController(IScheduleService scheduleService, ILogger<ScheduleController> logger, IConfiguration configuration)
        {
            _scheduleService = scheduleService;
            _configuration = configuration;
            _logger = logger;
        }
        [Authorize(Roles = "Location Owner")]
        [HttpPost]
        [MapToApiVersion("1")]
        public async Task<IActionResult> CreateSchedule([FromBody] CreateScheduleViewModel model)
        {
            var request = Request;
            TokenViewModel token = HttpContextUtil.getTokenModelFromRequest(request, _configuration);
            var result = await _scheduleService.CreateSchedule(token.Id, model);
            _logger.LogInformation($"Create schedule {result.Name} by party {token.Mail}.");
            return Ok(new SuccessResponse<ScheduleViewModel>((int) HttpStatusCode.OK, "Create success.", result));
        }
        
        [Authorize(Roles = "Location Owner")]
        [HttpGet]
        [MapToApiVersion("1")]
        public async Task<IActionResult> GetAll()
        {
            var request = Request;
            TokenViewModel token = HttpContextUtil.getTokenModelFromRequest(request, _configuration);
            var result = await _scheduleService.GetAll(token.Id);
            _logger.LogInformation($"Get all schedule of party {token.Mail}.");
            return Ok(new SuccessResponse<List<ScheduleViewModel>>((int) HttpStatusCode.OK, "Create success.", result));
        }
    }
}