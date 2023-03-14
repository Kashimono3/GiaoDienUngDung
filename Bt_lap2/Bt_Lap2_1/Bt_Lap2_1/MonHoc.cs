﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt_Lap2_1
{
    public class MonHoc
    {
        public int Id { get; set; }
        public int SoTC { get; set; }
        public string TenMH { get; set; }

        public MonHoc()
        {

        }
        public MonHoc(int id,string ten,int tc)
        {
            this.Id = id;
            this.TenMH = ten;
            this.SoTC = tc;
        }
        public MonHoc(string ten)
        {
            this.TenMH = ten;
        }
        public override string ToString()
        {
            return TenMH;
        }
    }
}
