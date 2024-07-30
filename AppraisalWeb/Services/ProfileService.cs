using AppraisalBussiness.Interfaces;
using AppraisalDataAccess.Models;
using AppraisalWeb.Models.Profile;
using System.Security.Claims;

namespace AppraisalWeb.Services
{
    public class ProfileService
    {
        private readonly IUserRepository _repository;

        public ProfileService(IUserRepository repository)
        {
            _repository = repository;
        }

        public ProfileVM GetPersonalInfo(string nik)
        {
            var model = _repository.GetByNIK(Convert.ToInt32(nik));
            return new ProfileVM()
            {
                Nama = model.Nama,
                Nik = model.Nik,
                Email = model.Email,
                DivisiOrDepartemen = model.DivisiOrDepartemen,
                Jabatan = model.Jabatan,
            };
        }
    }
}
