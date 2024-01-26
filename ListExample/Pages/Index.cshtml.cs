using ListExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace ListExample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IWebHostEnvironment _env;
        public List<Category> CategoryList { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IWebHostEnvironment env)
        {
            _logger = logger;            _env = env;

        }

        public void OnGet()
        {

            CategoryList = Categories().Categories.ToList();
        }
    
        public Category Categories()
        {

            var path = Path.Combine(_env.WebRootPath    , "siteData/Categories.json");
            using StreamReader reader = new(path);
            var lines = reader.ReadToEnd();
            var categories = JsonSerializer.Deserialize<Category>(lines);
            
            return categories;

        }
    }
}