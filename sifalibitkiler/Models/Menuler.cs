using System;
using System.Collections.Generic;

namespace sifalibitkiler.Models
{
    public partial class Menuler
    {
        public int MenuId { get; set; }
        public string? Baslik { get; set; }
        public string? Yol { get; set; }
        public byte? Sira { get; set; }
        public bool? Aktif { get; set; }
        public bool? Pasif { get; set; }
        public int? UstId { get; set; }
    }
}
