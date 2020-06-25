﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class DoAn
    {
        [Key]
        [Required]
        public int idDoAn { get; set; }

        [Required]
        public string tenDoAn { get; set; }

        [Required]
        public  string noiDung { get; set; }

        [Required]
        public  string khoaHoc { get; set; }

        [Required]
        public  string khoa { get; set; }

        public virtual IEnumerable<SinhVien> SinhViens { get; set; }
        public int idGiangVien { get; set; }
        public virtual GiangVien GiangVien { get; set; }
    }
}
