using System;
using System.Collections.Generic;
using System.Linq;
using BilgisayarAglarinaGirisProje.Context;
using BilgisayarAglarinaGirisProje.Models;
using Microsoft.EntityFrameworkCore;

namespace BilgisayarAglarinaGirisProje.Services
{
    public class MessagingService
    {
        private readonly AppDbContext _appDbContext;
        public MessagingService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<MessagingViewModel> getMessages(int chatId)
        {
            try
            {
                var messages = _appDbContext.Messages.Where(x => x.Chat.Id == chatId).Include(x => x.User).Include(x => x.toUser).Include(x => x.Media).ToList();
                List<MessagingViewModel> messagingViewModels = new List<MessagingViewModel>();
                foreach (var item in messages)
                {
                    var messagesViewModel = new MessagingViewModel
                    {
                        Content = item.Content,
                        Id = item.Id,
                        MediaUrl = item.Media != null ? item.Media.url:null,
                        ChatId = chatId,
                        SenderUserViewModel = new UserViewModel { Ad = item.User.Ad, Email = item.User.Email, Username = item.User.Username, Id = item.User.Id},
                        
                    };
                    messagingViewModels.Add(messagesViewModel);
                }
                return messagingViewModels;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool CheckNewMessages(CheckNewMessagesViewModel checkNewMessagesViewModel)
        {
            try
            {
                var isTrue = _appDbContext.Messages.Any(x => x.Id > checkNewMessagesViewModel.LastMessageId && x.Chat.Id == checkNewMessagesViewModel.ChatId);
                return isTrue;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool SendNewMessage(SendMessageModel sendMessageModel)
        {
            try
            {
                var chat = _appDbContext.Chats.Where(x => x.Id == sendMessageModel.ChatId).Include(x => x.User1).Include(x => x.User2).FirstOrDefault();
                var Sended = _appDbContext.Messages.Add(new Entity.Message
                {
                    Chat = _appDbContext.Chats.Where(x => x.Id == sendMessageModel.ChatId).FirstOrDefault(),
                    Content = sendMessageModel.Content,
                    IsRead = false,
                    Media = sendMessageModel.MediaId != 0 ? _appDbContext.Medias.Where(x => x.Id == sendMessageModel.MediaId).FirstOrDefault(): null,
                    toUser = chat.User1.Id == sendMessageModel.UserId ? _appDbContext.Users.Find(chat.User2.Id): _appDbContext.Users.Find(chat.User1.Id),
                    User = _appDbContext.Users.Where(x => x.Id == sendMessageModel.UserId).FirstOrDefault()
                });
                var a = _appDbContext.SaveChanges();
                if(a == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<ChatViewModel> getChats(int id)
        {
            try
            {
                var chats = _appDbContext.Chats.Where(x => x.User1.Id == id || x.User2.Id == id).Include(x => x.User1).Include(x => x.User2).ToList();
                List<ChatViewModel> chatViewModels = new List<ChatViewModel>();
                foreach (var item in chats)
                {
                    ChatViewModel chatViewModel = new ChatViewModel
                    {
                        Id = item.Id,
                        UserViewModelSender = new UserViewModel
                        {
                            Id = item.User1.Id,
                            Username = item.User1.Username
                        },
                        UserViewModelGetter = new UserViewModel
                        {
                            Id = item.User2.Id,
                            Username = item.User2.Username
                        },
                        Userid = id,
                    };
                    chatViewModels.Add(chatViewModel);
                }
                return chatViewModels;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public ChatViewModel createNewChat(ChatViewModel chatViewModel)
        {
            var user = _appDbContext.Users.Where(x => x.Username == chatViewModel.UserViewModelGetter.Username).FirstOrDefault();
            if(user != null)
            {
                var res = _appDbContext.Chats.Add(new Entity.Chat
                {
                    User1 = _appDbContext.Users.Find(chatViewModel.UserViewModelSender.Id),
                    User2 = _appDbContext.Users.Find(user.Id)
                });
                var a = _appDbContext.SaveChanges();
                if (a == 1)
                {
                    return chatViewModel;
                }
            }
            return null;
        }

        public List<MessagingViewModel> getNewMessages(GetNewMessagesModel getNewMessagesModel)
        {
            try
            {
                var newMessages = _appDbContext.Messages.Where(x => x.Id > getNewMessagesModel.LastMessageId && x.Chat.Id == getNewMessagesModel.ChatId).Include(x => x.Media).Include(x => x.User).ToList();
                List<MessagingViewModel> messagingViewModels = new List<MessagingViewModel>();
                foreach (var item in newMessages)
                {
                    MessagingViewModel messagingViewModel = new MessagingViewModel() {
                        ChatId = getNewMessagesModel.ChatId,
                        Content = item.Content,
                        Id = item.Id,
                        SenderUserViewModel = new UserViewModel()
                        {
                            Id = item.User.Id,
                            Username = item.User.Username
                        },
                        IsRead = true,
                    };
                    item.IsRead = true;
                    if (item.Media != null)
                        messagingViewModel.MediaUrl = item.Media.url;
                    messagingViewModels.Add(messagingViewModel);
                    _appDbContext.Messages.Update(item);
                }
                _appDbContext.SaveChanges();
                return messagingViewModels;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<ChatViewModel> GetUserChats(int id)
        {
            try
            {
                var userMessages = _appDbContext.Chats.Where(x => x.User1.Id == id || x.User2.Id == id).ToList();
                List<ChatViewModel> chatViewModels = new List<ChatViewModel>();
                foreach (var item in userMessages)
                {
                    ChatViewModel chatViewModel = new ChatViewModel()
                    {
                        Id = item.Id,
                        UserViewModelGetter = new UserViewModel { Id = item.User2.Id, Username = item.User2.Username },
                        UserViewModelSender = new UserViewModel { Id = item.User1.Id, Username = item.User1.Username }
                    };
                    chatViewModels.Add(chatViewModel);
                }
                return chatViewModels;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
