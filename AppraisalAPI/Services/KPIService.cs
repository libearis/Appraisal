using AppraisalBussiness.Interfaces;

namespace AppraisalAPI.Services
{
    public class KPIService
    {
        private readonly IKPIRepository _repository;

        public KPIService(IKPIRepository repository)
        {
            _repository = repository;
        }

        public List<string?> GetKPIList()
        {
            return _repository.GetAllKpi().Select(kpi => kpi.Nama).ToList();
        }
    }
}
