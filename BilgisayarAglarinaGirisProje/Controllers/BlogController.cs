using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BilgisayarAglarinaGirisProje.Models;
using BilgisayarAglarinaGirisProje.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BilgisayarAglarinaGirisProje.Controllers
{
    public class BlogController : Controller
    {
        public readonly BlogService blogService;

        public BlogController(BlogService _blogService)
        {
            blogService = _blogService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult Blog()
        {

            return View("Blog");
        }

        public IActionResult BlogDetail()
        {
            return View("BlogDetail");
        }


        [HttpPost("CreateBlogPost")]
        public IActionResult CreateBlogPost(BlogViewModel blogViewModel)
        {
            var username = HttpContext.User.Identity.Name;
            var userId = Int32.Parse(HttpContext.User.FindFirst("UserId").Value);
            blogViewModel.Writer = new UserViewModel { Id = userId };
            var result = blogService.createBlogPost(blogViewModel);
            return Ok(result);
        }

        [HttpGet("GetBlogPosts")]
        public IActionResult GetBlogs(BlogViewModel blogViewModel)
        {
            var result = blogService.GetBlogs();
            if(result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("GetBlogPost/{id}")]
        public IActionResult GetBlogPost(string id)
        {
            var result = blogService.getBlog(Int32.Parse(id));
            if(result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
           
        }

    }
}
