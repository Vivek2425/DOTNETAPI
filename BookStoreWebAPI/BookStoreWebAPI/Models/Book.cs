using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BookStoreWebAPI.Models
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public int PblisherId { get; set; }
        public string Isbn { get; set; }

        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
        public virtual Publisher Pblisher { get; set; }
    }
}
