using ClassLibrary1.Entity;

namespace ClassLibrary1.Repository;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity, new()
{
    readonly DbContext _context;



    public GenericRepository(DbContext context)
    {
        _context = context;
    }




    public async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate)
    {
        var entity = await _context.Set<TEntity>().FirstOrDefaultAsync(predicate);

        if (entity is null)
            throw new Exception(nameof(entity));

        return entity;

    }




    public async Task<TEntity> Get(string id)
    {
        var entity = await _context.Set<TEntity>().FindAsync(id);

        if (entity is null)
            throw new Exception(nameof(entity));

        return entity;
    }




    public async Task<IList<TEntity>> GetAllAsync()
    {
        var entitries = await _context.Set<TEntity>().ToListAsync();

        return entitries;
    }



    public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate)
    {
        var entitries = await _context.Set<TEntity>().Where(predicate).ToListAsync();

        return entitries;
    }








    public async Task CreateAsync(TEntity entity)
    {
        await _context.Set<TEntity>().AddAsync(entity);
    }


    public async Task DeleteAsync(string id)
    {
        var entity = await _context.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));

        if (entity is null)
            throw new Exception(nameof(entity));

        _context.Set<TEntity>().Remove(entity);
    }



   

    public Task UpdateAsync(TEntity entity)
    {
        return Task.FromResult(_context.Set<TEntity>().Update(entity));
    }



}
