using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_071.Models
{
    public partial class KondisiKendaraan
    {
        public int IdKondisi { get; set; }

        [Required(ErrorMessage = "Kondisi tidak boleh kosong!")]
        public string NamaKondisi { get; set; }

        public Pengembalian Pengembalian { get; set; }
    }
}
