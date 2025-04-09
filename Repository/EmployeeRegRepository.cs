using Microsoft.EntityFrameworkCore;
using BaseRepository.Models;
using BaseRepository.Data;

namespace BaseRepository.Repository
{
    public class EmployeeRegRepository : IEmployeeRegistration 
    {
        public readonly LearnDbContext _context;
        public EmployeeRegRepository(LearnDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MstRegistration>> GetAllRegistrations()
        {
            
            return await _context.MstRegistrations.ToListAsync();
        }

        public async Task<MstRegistration?> GetRegistrationById(int id)
        {
            return await _context.MstRegistrations.FindAsync(id);
        }

        public async Task AddRegistration(MstRegistration registration)
        {
            await _context.MstRegistrations.AddAsync(registration);
            await _context.SaveChangesAsync();
        }


        public async Task UpdateRegistration(MstRegistration registration)
        {
             _context.MstRegistrations.Update(registration);
            await _context.SaveChangesAsync();
        }


        public async Task DeleteRegistration(int id)
        {
            var registration = await _context.MstRegistrations.FindAsync(id);
            if (registration != null)
            {
                _context.MstRegistrations.Remove(registration);
                await _context.SaveChangesAsync();
            }
        }







    }
}
