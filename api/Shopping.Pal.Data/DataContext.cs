using Microsoft.EntityFrameworkCore;
using Shopping.Pal.Data.Models;

namespace Shopping.Pal.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    //DbSets
    public DbSet<UserProperties> UserProperties { get; set; }
}