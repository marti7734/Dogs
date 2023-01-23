using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class DogsController : Controller

    {
        private readonly ApplicationDbContext context;

        public IActionResult Create()
        {
            return this.View();
        }
    }
    
    
}
