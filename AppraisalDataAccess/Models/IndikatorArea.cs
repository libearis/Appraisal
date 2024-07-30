using System;
using System.Collections.Generic;

namespace AppraisalDataAccess.Models;

public partial class IndikatorArea
{
    public string Id { get; set; } = null!;

    public string? Aspek { get; set; }

    public string? Keterangan { get; set; }

    public int? Target { get; set; }

    public int? Aktual { get; set; }

    public int? TingkatUnjukKerja { get; set; }

    public int? NilaiUnjukKerja { get; set; }

    public string? RekapId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual Rekapitulasi? Rekap { get; set; }
}
