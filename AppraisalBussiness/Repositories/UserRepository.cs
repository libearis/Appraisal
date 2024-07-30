using AppraisalBussiness.Interfaces;
using AppraisalDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppraisalBussiness.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppraisalContext dbContext;

        public UserRepository(AppraisalContext appraisalContext)
        {
            this.dbContext = appraisalContext;
        }

        public User? GetByNIK(int NIK)
        {
            return dbContext.Users.Find(NIK);
        }

        public User? GetByEmail(string email)
        {
            return dbContext.Users.Where(user => user.Email == email).FirstOrDefault();
        }

        public List<User> GetAllEmployees()
        {
            return dbContext.Users.Where(user => user.Jabatan == "Karyawan").ToList();
        }

        public void Insert(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }

        public void Update(User user)
        {
            dbContext.Users.Update(user);
            dbContext.SaveChanges();
        }

        public void Delete(User user)
        {
            dbContext.Remove(user);
            dbContext.SaveChanges();
        }
    }
}
