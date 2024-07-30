using System;
using System.Collections.Generic;

namespace AppraisalDataAccess.Models;

public partial class KompetensiDasar
{
    public string Id { get; set; } = null!;

    public string? CustomerFocus { get; set; }

    public string? Integritas { get; set; }

    public string? KerjasamaTim { get; set; }

    public string? ContinuousImprovement { get; set; }

    public string? WorkExcellence { get; set; }

    public string? RekapId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual Rekapitulasi? Rekap { get; set; }
}
