using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TypeaheadLocation;
using ModelsRepository;
using ModelsRepository.Models.Profile;

namespace tryswagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase 
    {
        private readonly IRestRepoApi _req;
        public LocationController(IRestRepoApi restrequest)
        {
            _req = restrequest;
        }
        [HttpGet]
        public string ParamsRequired()
            {
            return "location parameter required";
            }

        [HttpGet]
        [Route("typeahead/{location}")]
        public IActionResult GetLoc(string location)
        {
            _req.RestRequestGet("api/v2/Typeahead/Locations");
            _req.AddPartnerId();
            _req.Addquerryparams("searchTerm", location);
            if (!string.IsNullOrEmpty(HttpContext.Request.Query["type   "]))
                _req.Addquerryparams("types" ,(string)HttpContext.Request.Query["type"]);
            return new OkObjectResult(_req.FetchgetRequest<List<Location>>());
        
        }
    }

} 