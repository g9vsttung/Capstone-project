﻿using kiosk_solution.Business.Services;
using kiosk_solution.Data.Responses;
using kiosk_solution.Data.ViewModels;
using kiosk_solution.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace kiosk_solution.Controllers
{
    [Route("api/v{version:apiVersion}/catePositions")]
    [ApiController]
    [ApiVersion("1")]
    public class AppCategoryPositionController : Controller
    {
        private readonly IAppCategoryPositionService _appCategoryPositionService;
        private readonly ILogger<AppCategoryPositionController> _logger;
        private IConfiguration _configuration;
        public AppCategoryPositionController(IAppCategoryPositionService appCategoryPositionService, ILogger<AppCategoryPositionController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _appCategoryPositionService = appCategoryPositionService;
            _configuration = configuration;
        }

        [Authorize(Roles = "Location Owner")]
        [HttpPost]
        [MapToApiVersion("1")]
        public async Task<IActionResult> Create([FromBody] AppCategoryPositionCreateViewModel model)
        {
            var request = Request;
            TokenViewModel token = HttpContextUtil.getTokenModelFromRequest(request, _configuration);
            var result = await _appCategoryPositionService.Create(token.Id ,model);
            _logger.LogInformation($"Take category {result.AppCategoryName} to template {result.TemplateName} by party {token.Mail}");
            return Ok(new SuccessResponse<AppCategoryPositionViewModel>((int)HttpStatusCode.OK, "Take success.", result));
        }
    }
}
