using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBooks.Models
{
    public class Book
    {
        public int BookID { get; set; }

        public int ISBN { get; set; }

        public string Title { get; set; }

        [Display(Name = "Number of Pages")]
        public int NumberOfPages { get; set; }

        [Display(Name = "Publication Year")]       
        public int PublicationYear { get; set; }

        public int CategoryID { get; set; }

        public int PublisherID { get; set; }

        public int AuthorID { get; set; }

        //The fields below are the foreign keys
        public virtual Category Category { get; set; }

        public virtual Publisher Publisher { get; set; }

        public virtual Author Author { get; set; } 

    }
}
