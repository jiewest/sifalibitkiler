using System;
using System.Collections.Generic;

namespace sifalibitkiler.Models
{
    public partial class Kategori
    {
        public Kategori()
        {
            Bitkilers = new HashSet<Bitkiler>();
        }

        public int KategoriId { get; set; }
        public string? Kategoriadi { get; set; }
        public bool? Aktif { get; set; }
        public bool? Pasif { get; set; }

        public virtual ICollection<Bitkiler> Bitkilers { get; set; }
    }
}
