﻿

using Microsoft.EntityFrameworkCore;

namespace Mission06_Bundy.Models
{
    public class MovieFormContext : DbContext
    {
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base(options) 
        {

        }

        public DbSet<Movie> Movies { get; set; }    
    }
}
