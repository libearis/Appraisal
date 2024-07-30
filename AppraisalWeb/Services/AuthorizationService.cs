using AppraisalBussiness.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using AppraisalWeb.Models;
using AppraisalWeb.Models.Authorization;

namespace AppraisalWeb.Services
{
    public class AuthorizationService
    {
        private readonly IUserRepository _userRepository;

        public AuthorizationService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        private ClaimsPrincipal GetPrincipal(LoginVM viewModel, string name, int nik)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, name),
                new Claim("NIK", nik.ToString()),
                new Claim(ClaimTypes.Role, viewModel.Role)
            };

            ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            return new ClaimsPrincipal(identity);
        }

        private AuthenticationTicket GetAuthenticationTicket(ClaimsPrincipal claimsPrincipal)
        {
            AuthenticationProperties authenticationProperties = new AuthenticationProperties()
            {
                IssuedUtc = DateTime.Now,
                ExpiresUtc = DateTime.Now.AddMinutes(30),
                AllowRefresh = false
            };

            return new AuthenticationTicket(claimsPrincipal, authenticationProperties, CookieAuthenticationDefaults.AuthenticationScheme);
        }
        public AuthenticationTicket CheckLogin(LoginVM viewModel)
        {
            int number;
            var model = new AppraisalDataAccess.Models.User();
            if (int.TryParse(viewModel.NikOrEmail, out number))
            {
                model = _userRepository.GetByNIK(Convert.ToInt32(viewModel.NikOrEmail)) ??
                    throw new Exception("NIK atau password atau jabatan salah");
            }
            else
            {
                model = _userRepository.GetByEmail(viewModel.NikOrEmail??"") ??
                    throw new Exception("NIK atau password atau jabatan salah");
            }

            bool isCorrectPassword = BCrypt.Net.BCrypt.Verify(viewModel.Password, model.Password);
            bool isCorrectRole = viewModel.Role == model.Jabatan? true: false;

            if (!isCorrectPassword || !isCorrectRole) 
                throw new Exception("NIK atau password atau jabatan salah");

            ClaimsPrincipal claimsPrincipal = GetPrincipal(viewModel, model.Nama, model.Nik);
            return GetAuthenticationTicket(claimsPrincipal);
            
        }
    }
}
