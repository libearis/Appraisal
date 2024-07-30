using System;
using System.Collections.Generic;

namespace AppraisalDataAccess.Models;

public partial class PerubahanNilai
{
    public string Id { get; set; } = null!;

    public string? SuratPeringatan { get; set; }

    public string? FireIncident { get; set; }

    public int? LostTimeInjury { get; set; }

    public int? Project { get; set; }

    public int? Sga { get; set; }

    public int? AuditorOrTrainer { get; set; }

    public string? RekapId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual Rekapitulasi? Rekap { get; set; }
}
