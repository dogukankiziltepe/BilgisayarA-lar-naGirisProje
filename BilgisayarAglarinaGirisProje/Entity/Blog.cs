using System;
namespace BilgisayarAglarinaGirisProje.Entity
{
    public class Blog
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
        public Media HeaderMedia { get; set; }
        public User Writer { get; set; }
    }
}
