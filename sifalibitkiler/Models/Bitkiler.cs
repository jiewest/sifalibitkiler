using System;
using System.Collections.Generic;

namespace sifalibitkiler.Models
{
    public partial class Bitkiler
    {
        public int BitkiId { get; set; }
        public string? Bitkiname { get; set; }
        public string? Bitkioz { get; set; }
        public byte[]? Bitkiimg { get; set; }
        public byte? Sira { get; set; }
        public int? KategoriId { get; set; }
        public DateTime? Addtime { get; set; }
        public bool? Aktif { get; set; }
        public bool? Pasif { get; set; }

        public virtual Kategori? Kategori { get; set; }
    }
}
