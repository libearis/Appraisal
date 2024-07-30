using System;
using System.Collections.Generic;

namespace AppraisalDataAccess.Models;

public partial class User
{
    public int Nik { get; set; }

    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;

    public string Nama { get; set; } = null!;

    public string DivisiOrDepartemen { get; set; } = null!;

    public string Jabatan { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual ICollection<Rekapitulasi> Rekapitulasis { get; set; } = new List<Rekapitulasi>();
}
