using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MultimediaDatabase.Models
{
    public class Movie
    {
        public int MovieID { get; set; }

        public int bookID { get; set; }

        public Book Book { get; set; }

        public string watcherName { get; set; }

        public string movieName { get; set; }

        public int year { get; set; }

        public int age { get; set; }

        public string director { get; set; }

        public string description { get; set; }

        public string basedOnBooks { get; set; }

        public string genre { get; set; }
    }
}
