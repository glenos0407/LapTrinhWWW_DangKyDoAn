﻿using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IDoAnService : IBaseService<DoAn>
    {
        int GetID(string tendoan);
        DoAn GetDoAnByIDGiangVien(int idgiangvien);
    }
}