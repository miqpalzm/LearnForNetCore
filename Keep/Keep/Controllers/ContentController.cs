using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Keep.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Keep.Controllers
{
    public class ContentController : Controller
    {
        private readonly Content contents;

        public ContentController(IOptions<Content> option)
        {
            contents = option.Value;
        }

        public IActionResult Index()
        {
            return View(new ContentViewModel { Contents = new List<Content>{ contents } });
        }
    }
}