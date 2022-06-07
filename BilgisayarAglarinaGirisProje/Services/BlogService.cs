using System;
using System.Collections.Generic;
using System.Linq;
using BilgisayarAglarinaGirisProje.Context;
using BilgisayarAglarinaGirisProje.Models;
using Microsoft.EntityFrameworkCore;

namespace BilgisayarAglarinaGirisProje.Services
{
    public class BlogService
    {
        private readonly AppDbContext _appDbContext;
        public BlogService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public BlogViewModel createBlogPost(BlogViewModel model)
        {
            var entity = _appDbContext.Blogs.Add(new Entity.Blog
            {
                Content = model.Content,
                Header = model.Header,
                HeaderMedia = model.HeaderMediaId == 0 ? null : _appDbContext.Medias.Find(model.HeaderMediaId),
                Writer = _appDbContext.Users.Find(model.Writer.Id)
            });
            var res = _appDbContext.SaveChanges();
            if(res == 1)
            {
                return model;
            }
            return null;
        }

        public List<BlogViewModel> GetBlogs()
        {
            var blogs = _appDbContext.Blogs.Include(x => x.Writer).Include(x => x.HeaderMedia).ToList();
            List<BlogViewModel> blogViewModels = new List<BlogViewModel>();
            foreach (var item in blogs)
            {
                BlogViewModel blogViewModel = new BlogViewModel
                {
                    Content = item.Content,
                    Header = item.Header,
                    HeaderMediaUrl = item.HeaderMedia != null ? item.HeaderMedia.url:null,
                    Writer = new UserViewModel { Id = item.Writer.Id, Username = item.Writer.Username},
                    Id=item.Id
                };
                blogViewModels.Add(blogViewModel);
            }
            return blogViewModels;
        }

        public BlogViewModel getBlog(int id)
        {
            var blog = _appDbContext.Blogs.Where(x => x.Id == id).Include(x => x.HeaderMedia).Include(x=> x.Writer).FirstOrDefault();
            BlogViewModel blogViewModel = new BlogViewModel
            {
                Content = blog.Content,
                Id = blog.Id,
                Header = blog.Header,
                HeaderMediaUrl = blog.HeaderMedia == null ? null : blog.HeaderMedia.url,
                Writer = new UserViewModel { Id = blog.Writer.Id, Username = blog.Writer.Username}
            };
            return blogViewModel;
        }
    }
}
