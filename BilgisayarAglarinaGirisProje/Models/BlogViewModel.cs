using System;
namespace BilgisayarAglarinaGirisProje.Models
{
    public class BlogViewModel
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
        public int? HeaderMediaId { get; set; }
        public string HeaderMediaUrl { get; set; }
        public UserViewModel Writer { get; set; } 
    }
}
