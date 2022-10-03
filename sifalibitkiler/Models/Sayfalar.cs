using System;
using System.Collections.Generic;

namespace sifalibitkiler.Models
{
    public partial class Sayfalar
    {
        public int SayfaId { get; set; }
        public string? Baslik { get; set; }
        public string? Icerik { get; set; }
        public bool? Aktif { get; set; }
        public bool? Pasif { get; set; }
    }
}
