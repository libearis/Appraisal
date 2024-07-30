using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppraisalDataAccess.Models;

namespace AppraisalBussiness.Interfaces
{
    public interface IUserRepository
    {
        public User GetByNIK(int NIK);
        public User GetByEmail(string email);
        public List<User> GetAllEmployees();
        public void Insert(User user);
        public void Update(User user);
        public void Delete(User user);
    }
}
