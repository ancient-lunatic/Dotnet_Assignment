using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsRepository.Models.Bookmark;
using ModelsRepository.Models.Profile;
using TypeaheadLocation;

namespace tryswagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookmarkController : ControllerBase
    {
              
            private readonly IRestRepoApi _req;
            public BookmarkController(IRestRepoApi restrequest)
            {
                _req = restrequest;
            }
            [HttpGet]
            [Route("userId/{userId}")]
            public IActionResult GetDPlanId(string userId)
            {
                var Likes = string.IsNullOrEmpty(HttpContext.Request.Query["showLikes"]) ? "" : (string)HttpContext.Request.Query["showLikes"];
                var Notes = string.IsNullOrEmpty(HttpContext.Request.Query["showNotes"]) ? "" : (string)HttpContext.Request.Query["showNotes"];
                var ImageInfo = string.IsNullOrEmpty(HttpContext.Request.Query["showImageInfo"]) ? "" : (string)HttpContext.Request.Query["showImageInfo"];
                var UserAction = string.IsNullOrEmpty(HttpContext.Request.Query["showUserActions"]) ? "" : (string)HttpContext.Request.Query["showUserActions"];
                var HomeInfo = string.IsNullOrEmpty(HttpContext.Request.Query["showHomeInfo"]) ? "" : (string)HttpContext.Request.Query["showHomeInfo"];
               // var bookmarkIds = string.IsNullOrEmpty(HttpContext.Request.Query["bookmarkIds"]) ? "" : (string)HttpContext.Request.Query["bookmarkIds"];
                var bookmarkId = string.IsNullOrEmpty(HttpContext.Request.Query["bookmarkId"]) ? "" : (string)HttpContext.Request.Query["bookmarkId"];
                var templateId = string.IsNullOrEmpty(HttpContext.Request.Query["templateId"]) ? "" : (string)HttpContext.Request.Query["templateId"];
                _req.RestRequestGet("api/v2/User/BookmarkData");
                _req.AddPartnerId();
                _req.Addquerryparams("userId", userId);
                if (Likes == "true" )
                    _req.Addquerryparams("showLikes", Likes);
                if (Notes == "true")
                    _req.Addquerryparams("showNotes", Notes);
                if (ImageInfo == "true")
                    _req.Addquerryparams("showImageInfo", ImageInfo);
                if (UserAction == "true")
                    _req.Addquerryparams("showUserActions", UserAction);
                if (HomeInfo == "true")
                    _req.Addquerryparams("showHomeInfo", HomeInfo);
                if(bookmarkId!= "")
                    _req.Addquerryparams("bookmarkId", bookmarkId);
                if (templateId != "")
                    _req.Addquerryparams("templateId", templateId);
                ApiResultModel<List<ApiBoardData>> result;

                try
                {
                    result = _req.FetchgetRequest<ApiResultModel<List<ApiBoardData>>>();
                if (result.Status!= "OK")
                {
                    return BadRequest();
                }
                }
                catch (Exception e)
                {
                    return BadRequest(e);
                }
                return new OkObjectResult(result);
            }
        [HttpPost]
        [Route("create")]
        public IActionResult CreateBookmark([FromBody] CreateBookmarkAttribute body)
        {

            _req.RestRequestPost("api/v2/User/CreateBookmark");
            _req.AddobjectBody(body);
            ApiResultModel<int> result;
            try
            {
                result = _req.FetchPost<ApiResultModel<int>>();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
            if (result.Status != "Fail" )
                return Ok();
            return BadRequest(result.ErrorMessage);
        }


        [HttpPost]
        [Route("update")]
        public IActionResult UpdateBookmark([FromBody] CreateBookmarkAttribute body)
        {
            _req.RestRequestPut("aapi/v2/User/UpdateBookmark");
            _req.AddobjectBody(body);
            ApiResultModel<List<UpdateBookmarkResponse>> result;
            try
            {
                result = _req.FetchPost<ApiResultModel<List<UpdateBookmarkResponse>>>();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
            if (result.Result.Count > 0)
                return Ok();
            return BadRequest(result.ErrorMessage);
        }

        [HttpGet]
        [Route("delete/{bookmarkId}")]
        public IActionResult DeleteBookmark(string bookmarkId)
        {
            _req.RestRequestDelete("api/v2/User/DeleteBookmark");
            _req.AddParams("bookmarkId", bookmarkId);
            ApiResultModel<Boolean> result;

            try
            {
                result = _req.FetchPost<ApiResultModel<Boolean>>();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
            if (result.Result)
                return Ok();
            return BadRequest(result.ErrorMessage);
        }


    }
}