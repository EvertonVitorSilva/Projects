using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyBookLibrary.Models;

namespace MyBookLibrary.Data
{
    public class MyBookLibraryContext : DbContext
    {
        public MyBookLibraryContext (DbContextOptions<MyBookLibraryContext> options)
            : base(options)
        {
        }

        public DbSet<MyBookLibrary.Models.Book> Book { get; set; } = default!;
    }
}
