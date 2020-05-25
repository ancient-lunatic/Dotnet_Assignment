using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TypeaheadLocation;

using ModelsRepository.Models.Profile;

using ModelsRepository;

namespace tryswagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IRestRepoApi _req;
        public ProfileController(IRestRepoApi restrequest)
        {
            _req = restrequest;
        }
        [HttpGet]
        [Route("userId/{userId}")]
        public IActionResult GetDPlanId(string userId)
        {
            var logonName = string.IsNullOrEmpty(HttpContext.Request.Query["logonName"]) ? "" : (string)HttpContext.Request.Query["logonName"];
            _req.RestRequestGet("api/v2/User/Profile");
            _req.AddPartnerId();
            if (logonName != "")
                _req.Addquerryparams("logonName", logonName);
            _req.Addquerryparams("userId", userId);
            ApiResultModel<List<ModelsRepository.Models.Profile.UserProfile>> result;
            try
            {
                result = _req.FetchgetRequest<ApiResultModel<List<ModelsRepository.Models.Profile.UserProfile>>>();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
            return new OkObjectResult(result);
        }
        [HttpGet]
        [Route("LogonName/{LogonName}")]
        public IActionResult UsigspecId(string LogonName)
        {
            var userId = string.IsNullOrEmpty(HttpContext.Request.Query["userId"]) ? "" : (string)HttpContext.Request.Query["userId"];
            _req.RestRequestGet("api/v2/User/Profile");
            _req.AddPartnerId();
            _req.Addquerryparams("LogonName", LogonName);
            if (userId != "")
                _req.Addquerryparams("planId", userId);
            ApiResultModel<List<ModelsRepository.Models.Profile.UserProfile>> result;
            try
            {
                result = _req.FetchgetRequest<ApiResultModel<List<ModelsRepository.Models.Profile.UserProfile>>>();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
            return new OkObjectResult(result);
        }
    }
}