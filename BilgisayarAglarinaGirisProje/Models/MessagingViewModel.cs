using System;
namespace BilgisayarAglarinaGirisProje.Models
{
    public class MessagingViewModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string MediaUrl { get; set; }
        public UserViewModel SenderUserViewModel { get; set; }
        public bool IsRead { get; set; }
        public int ChatId { get; set; }
    }
}
