using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YourNamespace.Domain.Entities;
using YourNamespace.Infrastructure.Persistence;

namespace YourNamespace.Infrastructure.Repositories
{
    public class ExampleRepository
    {
        private readonly AppDbContext _context;

        public ExampleRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ExampleEntity> GetByIdAsync(int id)
        {
            return await _context.ExampleEntities.FindAsync(id);
        }

        public async Task<IEnumerable<ExampleEntity>> GetAllAsync()
        {
            return await _context.ExampleEntities.ToListAsync();
        }

        public async Task AddAsync(ExampleEntity entity)
        {
            await _context.ExampleEntities.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(ExampleEntity entity)
        {
            _context.ExampleEntities.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.ExampleEntities.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}