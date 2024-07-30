namespace AppraisalWeb.Models.Profile
{
    public class ProfileVM
    {
        public int Nik { get; set; }

        public string Email { get; set; } = null!;

        public string Nama { get; set; } = null!;

        public string DivisiOrDepartemen { get; set; } = null!;

        public string Jabatan { get; set; } = null!;
    }
}
