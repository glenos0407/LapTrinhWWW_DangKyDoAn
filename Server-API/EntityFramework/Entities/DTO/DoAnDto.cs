using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class DoAnDto
    {
        public int idDoAn { get; set; }
        public string tenDoAn { get; set; }
        public string noiDung { get; set; }
        public string khoaHoc { get; set; }
        public string khoa { get; set; }
        public int idGiangVien { get; set; }
    }
}
