using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidationExample.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoValidationController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(User user)
        {
            return NoContent();
        }
    }
}