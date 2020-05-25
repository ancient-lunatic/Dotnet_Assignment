using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsRepository;
using ModelsRepository.Models.HomeDetailApi;
using TypeaheadLocation;


namespace tryswagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeDetailController : ControllerBase
    {
        private readonly IRestRepoApi _req;
        public HomeDetailController(IRestRepoApi restrequest)
        {
            _req = restrequest;
        }


        [HttpGet]
        [Route("plan/{planId}")]
        public IActionResult GetDPlanId(string planId )
        {
            var specID = string.IsNullOrEmpty(HttpContext.Request.Query["specId"]) ? "" : (string)HttpContext.Request.Query["specId"];
            _req.RestRequestGet("api/v2/Detail/Home");
            _req.AddPartnerId();
            if (specID != "")
                _req.Addquerryparams("specId", specID);
            _req.Addquerryparams("planId", planId);
            ApiHomeDetails result;
            try
            {
                result = _req.FetchgetRequest<ApiHomeDetails>();
            }
            catch(Exception e)
            {
                return BadRequest(e);
            }
            return new OkObjectResult(result);
        }
        [HttpGet]
        [Route("specs/{specId}")]
        public IActionResult UsigspecId(string specId)
        {
            var planId = string.IsNullOrEmpty(HttpContext.Request.Query["planId"]) ? "" : (string)HttpContext.Request.Query["planId"];
            _req.RestRequestGet("api/v2/Detail/Home");
            _req.AddPartnerId();
            if (planId != "")
                _req.Addquerryparams("planId", planId);
            _req.Addquerryparams("specId", specId);
            ApiHomeDetails result;
            try
            {
                result = _req.FetchgetRequest<ApiHomeDetails>();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
            return new OkObjectResult(result);
        }
       
    }
}