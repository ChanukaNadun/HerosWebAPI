using Microsoft.EntityFrameworkCore;
using System;

namespace HerosWebAPI.Model
{
    public class HerosDBContext: DbContext
    {
        public HerosDBContext(DbContextOptions<HerosDBContext> options)
:       base(options)
        {
        }
        public DbSet<Heros>heros { get; set; }
        public DbSet<Fruits>fruits { get; set; }
        public DbSet<Animals> animals { get; set; }

    }
}
