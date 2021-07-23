using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mynewweb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        //next add an action method
        [HttpGet]

        public string[] GetDishes()
        {
            String[] dishes = { "mango", "rice hot", "dumpling" };
            return dishes;
        }
    }
}
