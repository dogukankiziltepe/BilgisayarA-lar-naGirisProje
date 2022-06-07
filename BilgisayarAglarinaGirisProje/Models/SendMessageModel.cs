using System;
namespace BilgisayarAglarinaGirisProje.Models
{
    public class SendMessageModel
    {
        public string Content { get; set; }
        public int UserId { get; set; }
        public int ToUserId { get; set; }
        public int MediaId { get; set; }
        public int ChatId { get; set; }
    }
}
