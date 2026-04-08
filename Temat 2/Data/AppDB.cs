using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

internal class AppDbContext : DbContext
{
    public DbSet<City> Cities { get; set; }
    public DbSet<Weather> Weathers { get; set; }

    public AppDbContext()
    {
        Database.EnsureCreated(); // tworzy bazę
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite("Data Source=weather.db");
    }
}