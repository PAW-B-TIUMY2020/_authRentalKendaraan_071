using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_071.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdCustomer { get; set; }

        [Required(ErrorMessage = "Nama Customer Wajib Diisi!")]
        public string NamaCustomer { get; set; }

        [RegularExpression("^[0-9]^$", ErrorMessage ="Hanya Boleh Diisi oleh Angka!")]
        public string Nik { get; set; }

        [Required(ErrorMessage = "Alamat Customer Wajib Diisi!")]
        public string Alamat { get; set; }

        [MinLength(10, ErrorMessage ="No Hp tidak boleh kurang dari 10 angka")]
        [MaxLength(12, ErrorMessage = "No Hp tidak boleh lebih dari 12 angka")]
        public string NoHp { get; set; }
        public int? IdGender { get; set; }

        public Gender IdGenderNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
