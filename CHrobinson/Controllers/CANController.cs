﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CHrobinson.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CANController : ControllerBase
    {
        public IActionResult Get() 
        {
            string[] borders = {"US" };
            return Ok(borders);
        }
    }
}
