using System;
using System.Collections.Generic;

namespace AppraisalDataAccess.Models;

public partial class Kpi
{
    public string Id { get; set; } = null!;

    public string? Nama { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual ICollection<IndikatorUtamaKerja> IndikatorUtamaKerjas { get; set; } = new List<IndikatorUtamaKerja>();
}
