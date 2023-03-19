using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GestãoBiblioteca.Models;

namespace GestãoBiblioteca.Data
{
    public class GestãoBibliotecaContext : DbContext
    {
        public GestãoBibliotecaContext (DbContextOptions<GestãoBibliotecaContext> options)
            : base(options)
        {
        }

        public DbSet<GestãoBiblioteca.Models.Usuarios> Usuarios { get; set; } = default!;

        public DbSet<GestãoBiblioteca.Models.Livros> Livros { get; set; } = default!;
    }
}
