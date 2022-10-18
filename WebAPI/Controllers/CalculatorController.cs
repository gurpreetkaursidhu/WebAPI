﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class CalculatorController : Controller
    {
        double result = 0;


        [HttpGet]
        public double Addition(double left, double right)
        {
            return CalculatorLogic.CalculatorLogic.Addition(left, right); // if user want to add 2 numbers this api works
        }
    }
}
