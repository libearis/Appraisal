namespace AppraisalWeb.Models.Authorization
{
    public class LoginVM
    {
        public string? NikOrEmail { get; set; }
        public string Password { get; set; } = null!;
        public string Role { get; set; } = null!;
    }
}
