using System;
namespace BilgisayarAglarinaGirisProje.Entity
{
    public class Chat
    {
        public int Id { get; set; }
        public int UserId1 { get; set; }
        public int UserId2 { get; set; }
        public User User1 { get; set; }
        public User User2 { get; set; }
    }
}
