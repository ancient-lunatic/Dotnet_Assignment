using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TypeaheadLocation;
using ModelsRepository.Models.Profile;
using ModelsRepository;

namespace tryswagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCreateController : ControllerBase
    {
        private readonly IRestRepoApi _req;
        public UserCreateController(IRestRepoApi restrequest)
        {
            _req = restrequest;
        }
        [HttpPost]
        public IActionResult InsertUser([FromBody] UserProfile body)
        {
            _req.RestRequestPost("api/v2/User/Create");
             body.PartnerId = (_req.AddPartnerIdInObject());
            _req.AddobjectBody<UserProfile>(body);
            ApiResultModel<Boolean> result;
            try
            {
                result = _req.FetchPost<ApiResultModel<Boolean>>();
            }
            catch(Exception e )
            {
                return BadRequest(e);
            }
            if(result.Result)
                 return Ok();
            return BadRequest(result.ErrorMessage);
        }

    }
}