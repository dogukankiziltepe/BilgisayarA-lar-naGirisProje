using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using BilgisayarAglarinaGirisProje.Context;
using BilgisayarAglarinaGirisProje.Entity;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BilgisayarAglarinaGirisProje.Controllers
{
    public class MediaController : Controller
    {
        private readonly IHostingEnvironment _environment;
        private readonly AppDbContext dbContext;
        public MediaController(IHostingEnvironment IHostingEnvironment,AppDbContext _appdbContext)
        {
            _environment = IHostingEnvironment;
            dbContext = _appdbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("Media/UploadMedia")]
        public IActionResult UploadMedia([FromForm]IFormFile file)
        {           

            if (file.Length > 0)
            {
                string uploadsFolder = Path.Combine(_environment.WebRootPath, "images");
                var uniqueFileName = Guid.NewGuid().ToString();
                var extension = System.IO.Path.GetExtension(file.FileName);
                string filePath = Path.Combine(uploadsFolder, uniqueFileName+extension);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                Media media = new Media
                {
                    url = "images/"+uniqueFileName+extension
                };
                var entityMedia = dbContext.Medias.Add(media);
                var isSuccess = dbContext.SaveChanges();
                if (isSuccess == 1)
                {
                    return Ok(entityMedia.Entity.Id);
                }
            }
            


            
            return Ok();
        }
    }
}
