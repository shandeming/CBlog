using CBlog.Data.Data;
using CBlog.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace CBlog.Service;

public class PostRepository:GenericRepository<Post>
{
    public PostRepository(BlogContext context) : base(context)
    {
    }

    public override async Task<IEnumerable<Post>> All()
    {
        return await _dbSet.ToListAsync();
    }
}