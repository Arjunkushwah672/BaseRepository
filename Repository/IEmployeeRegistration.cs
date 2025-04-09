using BaseRepository.Models;

namespace BaseRepository.Repository
{
    public interface IEmployeeRegistration
    {
        Task<IEnumerable<MstRegistration>> GetAllRegistrations();
        Task<MstRegistration?> GetRegistrationById(int id);
        Task AddRegistration(MstRegistration registration);
        Task UpdateRegistration(MstRegistration registration);
        Task DeleteRegistration(int id);
    }
}
