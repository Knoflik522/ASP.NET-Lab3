﻿using Microsoft.AspNetCore.Mvc;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    
    
    public class CalcController : Controller
    {
        private readonly CalcService _calcService;

        public CalcController(CalcService calcService)
        {
            _calcService = calcService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("add")]
        public IActionResult Add(int a, int b)
        {
            return Ok(_calcService.Add(a, b));
        }

        [HttpGet("subtract")]
        public IActionResult Subtract(int a, int b)
        {
            return Ok(_calcService.Subtract(a, b));
        }

        [HttpGet("multiply")]
        public IActionResult Multiply(int a, int b)
        {
            return Ok(_calcService.Multiply(a, b));
        }

        [HttpGet("divide")]
        public IActionResult Divide(int a, int b)
        {
            try
            {
                return Ok(_calcService.Divide(a, b));
            }
            catch (DivideByZeroException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
