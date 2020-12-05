using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MultimediaDatabase.Models
{
    public class Book
    {
        public int bookID { get; set; }

        public string readerName { get; set; }

        public string bookName { get; set; }

        public int year { get; set; }

        public int age { get; set; }

        public string author { get; set; }

        public string description { get; set; }

        public string genre { get; set; }
    }
}
