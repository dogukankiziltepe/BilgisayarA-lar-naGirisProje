using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using BilgisayarAglarinaGirisProje.Context;
using BilgisayarAglarinaGirisProje.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace BilgisayarAglarinaGirisProje.Services
{
    public class UserService
    {
        private AppDbContext _context;
        private readonly IConfiguration _configuration;

        public UserService(AppDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public UserViewModel Login(LoginViewModel loginViewModel)
        {
            try
            {
                var user = _context.Users.Where(x => x.Email == loginViewModel.EMail && x.Password == loginViewModel.Password).FirstOrDefault();
                if(user != null)
                {
                    var userviewmodel = new UserViewModel { Ad = user.Ad, Soyad = user.Soyad, Username = user.Username , Email = user.Email, Id = user.Id };
                    return userviewmodel;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int SignUp(SignUpModel signUpModel)
        {
            try
            {
                _context.Users.Add(new Entity.User
                {
                    Ad = signUpModel.Ad,
                    Soyad = signUpModel.Soyad,
                    Email = signUpModel.EMail,
                    Password = signUpModel.Password,
                    Username = signUpModel.Username
                });
                var saved = _context.SaveChanges();
                return saved;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public List<UserViewModel> UserList()
        {
            try
            {
                var users = _context.Users.ToList();
                List<UserViewModel> userViewModels = new List<UserViewModel>();
                foreach (var item in users)
                {
                    UserViewModel userViewModel = new UserViewModel
                    {
                        Username = item.Username,
                        Id = item.Id
                    };
                    userViewModels.Add(userViewModel);
                }
                return userViewModels;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
