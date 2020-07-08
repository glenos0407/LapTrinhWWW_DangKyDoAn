using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class SinhVien
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idSinhVien { get; set; }

        [Required]
        public string hoTen { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public string avatarLink { get; set; }

        [Required]
        public string nienKhoa { get; set; }

        public string diaChi { get; set; }

        [RegularExpression("^[0-9]{10}$")]
        public string soDienThoai { get; set; }

        public string email { get; set; }

        public double? diem { get; set; }

        [Required]
        public string khoa { get; set; }

        public int? idDoAn { get; set; }
        public virtual DoAn DoAn { get; set; }
    }
}
