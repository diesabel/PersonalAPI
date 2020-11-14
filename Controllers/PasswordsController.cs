using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PersonalAPI.Services;

namespace PersonalAPI.Controllers
{
    [ApiController]
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    public class PasswordsController : ControllerBase
    {
        public readonly IMapper _mapper;
        public readonly IPasswordManager _password;

        public PasswordsController(IMapper mapper, IPasswordManager password)
        {
            _mapper = mapper;
            _password = password;
        }

        [HttpGet("all")]
        public IActionResult GetAllPasswords()
        {
            var data = _password.GetAllPasswords();

            return Ok(_mapper.Map<IEnumerable<Models.PasswordManager>>(data));
        }

        [HttpGet("service/{service}")]
        public IActionResult GetAPassword(string service)
        {
            var data = _password.GetPasswords(service);

            return Ok(_mapper.Map<Models.PasswordManager>(data));
        }


    }
}
