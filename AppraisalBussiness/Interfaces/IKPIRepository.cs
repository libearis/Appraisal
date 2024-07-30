using AppraisalDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppraisalBussiness.Interfaces
{
    public interface IKPIRepository
    {
        public Kpi GetKpiById(string id);
        public List<Kpi> GetAllKpi();

        public void Insert(Kpi kpi);
        public void Update(Kpi kpi);
        public void Delete(string id);
    }
}
