using BaseRepository.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Repository
{

    public class BaseRepository<MstRegistration> where MstRegistration : class
    {
        private readonly LearnDbContext _context;

        public BaseRepository(LearnDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MstRegistration>> GetAllAsync()
        {
            return await _context.Set<MstRegistration>().ToListAsync();
        }

        public async Task<MstRegistration?> GetByIdAsync(int id)
        {
            return await _context.Set<MstRegistration>().FindAsync(id);
        }

        public async Task AddAsync(MstRegistration entity)
        {
            await _context.Set<MstRegistration>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(MstRegistration entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.Set<MstRegistration>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }


}
