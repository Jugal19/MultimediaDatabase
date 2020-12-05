using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace MultimediaDatabase.Models
{
    public class BookContext : DbContext
    {
        //connects to the database with the list of books and movies
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }
        //this is the list where it accesses the books
        public DbSet<Book> Books { get; set; }

        //this is the list where it accesses the movies
        public DbSet<Movie> Movies { get; set; }


    }
}
