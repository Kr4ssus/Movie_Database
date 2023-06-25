using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movie_Database.Models;

namespace Movie_Database.Data
{
    public class Movie_DatabaseContext : DbContext
    {
        public Movie_DatabaseContext (DbContextOptions<Movie_DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Movie_Database.Models.Movie> Movie { get; set; } = default!;
    }
}
