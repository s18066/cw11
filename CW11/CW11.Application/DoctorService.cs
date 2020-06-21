using System;
using System.Threading.Tasks;
using CW11.Application.Model;

namespace CW11.Application
{
    public interface IDoctorService
    {
        ValueTask<int> AddAsync(DoctorDto dto);
        ValueTask<bool> ModifyAsync(int doctorId, DoctorDto dto);
        ValueTask<Doctor> GetAsync(int doctorId);
        ValueTask<bool> DeleteAsync(int doctorId);
    }

    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _doctorRepository;

        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public async ValueTask<int> AddAsync(DoctorDto dto)
        {
            var doctor = Doctor.Create(dto.FirstName, dto.LastName, dto.LastName);

            await _doctorRepository.AddAsync(doctor);

            await _doctorRepository.SaveChangesAsync();

            return doctor.IdDoctor;
        }
        
        public async ValueTask<bool> ModifyAsync(int doctorId, DoctorDto dto)
        {
            var doctor = await _doctorRepository.GetAsync(doctorId);

            if (doctor is null)
                return false;
            
            doctor.Modify(dto.FirstName, dto.LastName, dto.Email);

            await _doctorRepository.SaveChangesAsync();

            return true;
        }
        
        public async ValueTask<Doctor> GetAsync(int doctorId)
        {
            return await _doctorRepository.GetAsync(doctorId);
        }
        
        public async ValueTask<bool> DeleteAsync(int doctorId)
        {
            var doctor = await _doctorRepository.GetAsync(doctorId);

            if (doctor is null)
                return false;
            
            _doctorRepository.Delete(doctor);

            await _doctorRepository.SaveChangesAsync();
            return true;
        }
        
    }
}