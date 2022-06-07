using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BilgisayarAglarinaGirisProje.Models;
using BilgisayarAglarinaGirisProje.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BilgisayarAglarinaGirisProje.Controllers
{
    public class MessagingController : Controller
    {
        private MessagingService messagingService;
        public MessagingController(MessagingService _messagingService)
        {
            messagingService = _messagingService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Chat()
        {
            return View("Chat");
        }

        [HttpPost("CheckNewMessages")]
        public IActionResult CheckNewMessages(CheckNewMessagesViewModel model)
        {
            var username = HttpContext.User.Identity.Name;
            var userId = Int32.Parse(HttpContext.User.FindFirst("UserId").Value);
            model.UserId = userId;
            var result = messagingService.CheckNewMessages(model);
            if(result == true)
            {
                return Ok(true);
            }
            else
            {
                return Ok(false);
            }
            
        }

        [HttpPost("SendNewMessage")]
        public IActionResult SendNewMessage(SendMessageModel sendMessageModel)
        {
            var username = HttpContext.User.Identity.Name;
            var userId = Int32.Parse(HttpContext.User.FindFirst("UserId").Value);
            sendMessageModel.UserId = userId;
            var result = messagingService.SendNewMessage(sendMessageModel);
            if(result == true)
            {
                return Ok(true);
            }
            else
            {
                return Ok();
            }
        }

        [HttpPost("GetNewMessages")]
        public IActionResult GetNewMessages(GetNewMessagesModel getNewMessagesModel)
        {
            var result = messagingService.getNewMessages(getNewMessagesModel);
            if(result.Count > 0)
            {
                return Ok(result);
            }
            else
            {
                return Ok();
            }
     
        }

        [HttpGet("GetMessages/{id}")]
        public IActionResult GetMessages(string id)
        {
            var result = messagingService.getMessages(Int32.Parse(id));
            if (result.Count > 0)
            {
                return Ok(result);
            }
            else
            {
                return Ok();
            }

        }

        [HttpGet("getChats")]
        public IActionResult GetChats()
        {
            var username = HttpContext.User.Identity.Name;
            var userId = Int32.Parse(HttpContext.User.FindFirst("UserId").Value);
            var result = messagingService.getChats(userId);
            if(result.Count > 0)
            {
                return Ok(result);

            }
            return Ok();
        }

        [HttpPost("createNewChat")]
        public IActionResult createNewChat(ChatViewModel chatViewModel)
        {
            var username = HttpContext.User.Identity.Name;
            var userId = Int32.Parse(HttpContext.User.FindFirst("UserId").Value);
            chatViewModel.UserViewModelSender = new UserViewModel { Id = userId };
            var result = messagingService.createNewChat(chatViewModel);
            if (result != null)
            {
                return Ok(result);

            }
            return BadRequest();
        }
    }
}
