namespace AppraisalWeb.Models
{
    public class PaginationVM
    {
        public int PageSize { get; set; }
        public int TotalSize { get; set; }
        public int PageNumber { get; set; }
        public int TotalPages
        {
            get
            {
                return (int)Math.Ceiling((double)TotalSize / PageSize);
            }
        }
    }
}
