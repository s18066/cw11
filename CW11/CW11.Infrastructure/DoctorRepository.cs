using System.Linq;
using System.Threading.Tasks;
using CW11.Application;
using CW11.Application.Model;
using Microsoft.EntityFrameworkCore;

namespace CW11.Infrastructure
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly HospitalContext _context;

        public DoctorRepository(HospitalContext context)
        {
            _context = context;
        }
        
        public async ValueTask<Doctor> GetAsync(int doctorId)
        {
            return await _context.Doctors.SingleOrDefaultAsync(x => x.IdDoctor == doctorId);
        }

        public void Delete(Doctor doctor)
        {
            _context.Doctors.Remove(doctor);
        }

        public async ValueTask AddAsync(Doctor doctor)
        {
            await _context.Doctors.AddAsync(doctor);
        }

        public async ValueTask SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}