using System;
namespace BilgisayarAglarinaGirisProje.Entity
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public Media Media { get; set; }
        public User User { get; set; }
        public User toUser { get; set; }
        public bool IsRead { get; set; }
        public Chat Chat { get; set; }
    }
}
