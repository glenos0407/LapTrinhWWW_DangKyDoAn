using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class SinhVienDiemDto
    {
        public int idSinhVien { get; set; }
        public string hoTen { get; set; }
        public string nienKhoa { get; set; }
        public string khoa { get; set; }
        public double? diem { get; set; }
    }
}
