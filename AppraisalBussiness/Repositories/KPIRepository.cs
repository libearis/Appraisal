using AppraisalBussiness.Interfaces;
using AppraisalDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppraisalBussiness.Repositories
{
    public class KPIRepository : IKPIRepository
    {
        private readonly AppraisalContext dbContext;

        public KPIRepository(AppraisalContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Kpi> GetAllKpi()
        {
            return dbContext.Kpis.ToList();
        }

        public Kpi GetKpiById(string id)
        {
            return dbContext.Kpis.Find(id) ?? throw new NullReferenceException("KPI Tidak ada");
        }

        public void Insert(Kpi kpi)
        {
            throw new NotImplementedException();
        }

        public void Update(Kpi kpi)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
