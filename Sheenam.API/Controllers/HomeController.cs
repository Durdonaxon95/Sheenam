//=================================================
//Copyright (c) Coalition of Good-Hearted Engineers
//FreeTo Use To Find Comfort and Peace
//=================================================

using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace Sheenam.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get() =>
          Ok("Hello Durdona, THe princess is in another castle");
    }


}