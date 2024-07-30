using AppraisalWeb.Models.Profile;

namespace AppraisalWeb.Models.Penilaian
{
    public class PenilaianVM
    {
        public List<ProfileVM>? Employees { get; set; } = new List<ProfileVM>();
        public PaginationVM? Pagination { get; set; }
    }
}
