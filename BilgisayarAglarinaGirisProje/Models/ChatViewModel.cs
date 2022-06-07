using System;
namespace BilgisayarAglarinaGirisProje.Models
{
    public class ChatViewModel
    {
        public int Id { get; set; }
        public UserViewModel UserViewModelSender { get; set; }
        public UserViewModel UserViewModelGetter { get; set; }
        public int Userid { get; set; }
        public MessagingViewModel messagingViewModel { get; set; }
    }
}
