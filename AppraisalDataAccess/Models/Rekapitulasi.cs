using System;
using System.Collections.Generic;

namespace AppraisalDataAccess.Models;

public partial class Rekapitulasi
{
    public string Id { get; set; } = null!;

    public string? Periode { get; set; }

    public int? Nik { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual ICollection<IndikatorArea> IndikatorAreas { get; set; } = new List<IndikatorArea>();

    public virtual ICollection<IndikatorUtamaKerja> IndikatorUtamaKerjas { get; set; } = new List<IndikatorUtamaKerja>();

    public virtual ICollection<KompetensiDasar> KompetensiDasars { get; set; } = new List<KompetensiDasar>();

    public virtual User? NikNavigation { get; set; }

    public virtual ICollection<PerubahanNilai> PerubahanNilais { get; set; } = new List<PerubahanNilai>();
}
