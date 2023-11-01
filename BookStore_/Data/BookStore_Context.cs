using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookStore_.Models;

namespace BookStore_.Data
{
    public class BookStore_Context : DbContext
    {
        public BookStore_Context (DbContextOptions<BookStore_Context> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; } = default!;
    }
}
