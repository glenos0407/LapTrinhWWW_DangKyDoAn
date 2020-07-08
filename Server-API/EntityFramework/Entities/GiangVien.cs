using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class GiangVien
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idGiangVien { get; set; }

        [Required]
        public string hoTen { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public string avatarLink { get; set; }

        public string email { get; set; }

        public string diaChi { get; set; }

        [RegularExpression("^[0-9]{10}$")]
        public string soDienThoai { get; set; }

        [Required]
        public string chucVu { get; set; }

        [Required]
        public string khoa { get; set; }

        public virtual IEnumerable<DoAn> DoAns { get; set; }
    }
}
