using CBlog.Data.Data;
using CBlog.Data.Model;
using CBlog.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace CBlog.Service;

public class GenericRepository<T>:IGenericRepository<T> where T:class
{
    private readonly BlogContext _context;
    internal DbSet<Post> _dbSet;

    public GenericRepository(BlogContext context)
    {
        _context = context;
        _dbSet = _context.Posts;
    }
    public virtual Task<IEnumerable<T>> All()
    {
        throw new NotImplementedException();
    }

    public Task<T?> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Add(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Update(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}