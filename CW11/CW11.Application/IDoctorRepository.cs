using System.Threading.Tasks;
using CW11.Application.Model;

namespace CW11.Application
{
    public interface IDoctorRepository
    {
        ValueTask<Doctor> GetAsync(int doctorId);
        
        void Delete(Doctor doctor);

        ValueTask AddAsync(Doctor doctor);

        ValueTask SaveChangesAsync();
    }
}