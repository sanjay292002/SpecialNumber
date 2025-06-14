using Microsoft.AspNetCore.Mvc;
using SpecialNumbersApp.Logic;
using System.Collections.Generic;

namespace SpecialNumbersApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpecialNumbersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string type, int start, int end)
        {
            var result = new List<int>();
            for (int i = start; i <= end; i++)
            {
                switch (type.ToLower())
                {
                    case "prime":
                        if (SpecialNumberAll.IsPrime(i)) result.Add(i);
                        break;
                    case "fibonacci":
                        if (SpecialNumberAll.IsFibonacci(i)) result.Add(i);
                        break;
                    case "perfectsquare":
                        if (SpecialNumberAll.IsPerfectSquare(i)) result.Add(i);
                        break;
                    case "perfect":
                        if (SpecialNumberAll.IsPerfectNumber(i)) result.Add(i);
                        break;
                    case "abundant":
                        if (SpecialNumberAll.IsAbundantNumber(i)) result.Add(i);
                        break;
                    case "deficient":
                        if (SpecialNumberAll.IsDeficientNumber(i)) result.Add(i);
                        break;
                    case "narcissitic":
                        if (SpecialNumberAll.IsNarcissitc(i)) result.Add(i);
                        break;
                    case "palandrom":
                        if (SpecialNumberAll.IsPalandrom(i)) result.Add(i);
                        break;
                     
                }
            }
            return Ok(result);
        }
    }
}
