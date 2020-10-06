using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace MVCBooks.Models
{
    public class Publisher
    {
        public int PublisherID { get; set; }

        public string Name { get; set; }

        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        public string City { get; set; }

        public string State { get; set; }

        public int Zip { get; set; }
    }
}
