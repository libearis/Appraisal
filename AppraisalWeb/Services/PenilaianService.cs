using AppraisalBussiness.Interfaces;
using AppraisalWeb.Models.Penilaian;
using AppraisalWeb.Models.Profile;

namespace AppraisalWeb.Services
{
    public class PenilaianService
    {
        private readonly IUserRepository _repository;

        public PenilaianService(IUserRepository repository)
        {
            _repository = repository;
        }

        public PenilaianVM GetAllEmployees()
        {
            PenilaianVM model = new PenilaianVM()
            {
                Employees = _repository.GetAllEmployees().Select(user => new ProfileVM()
                {
                    Nama = user.Nama,
                    DivisiOrDepartemen = user.DivisiOrDepartemen
                }).ToList(),
                Pagination = new Models.PaginationVM()
                {
                    PageNumber = 1,
                    PageSize = 5
                }
            };

            model.Pagination.TotalSize = model.Employees.Count;
            return model;
        }
    }
}
