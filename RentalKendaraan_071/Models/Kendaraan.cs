﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_071.Models
{
    public partial class Kendaraan
    {
        public Kendaraan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdKendaraan { get; set; }

        [Required(ErrorMessage = "Nama Kendaraan Wajib Diisi!")]
        public string NamaKendaraan { get; set; }

        [Required(ErrorMessage = "No Polisi Wajib Diisi!")]
        public string NoPolisi { get; set; }

        [RegularExpression("^[0-9]^$", ErrorMessage = "Hanya Boleh Diisi oleh Angka!")]
        public string NoStnk { get; set; }

        public int? IdJenisKendaraan { get; set; }

        [RegularExpression("^[0-9]^$", ErrorMessage = "Hanya Boleh Diisi oleh Angka!")]
        public string Ketersediaan { get; set; }

        public JenisKendaraan IdJenisKendaraanNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
