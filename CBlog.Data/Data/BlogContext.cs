using CBlog.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace CBlog.Data.Data;

public class BlogContext:DbContext
{
    public DbSet<Post> Posts { get; set; }
    public BlogContext(DbContextOptions options) : base(options)
    {
    }
    
}