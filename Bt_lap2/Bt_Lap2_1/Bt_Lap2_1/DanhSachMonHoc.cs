using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bt_Lap2_1
{
    public class DanhSachMonHoc
    {
        public ArrayList ds = new ArrayList();
        public  DanhSachMonHoc() 
        {
            ds = new ArrayList();
        }
        public MonHoc this[int index]
        {
            get { return ds[index] as MonHoc;}
            set { ds[index] = value; }
        }
        public void Them(MonHoc mh)
        {
            ds.Add(mh);
        }
        public override string ToString()
        {
            string s ="Danh Sanh Mon Hoc"
            foreach (object mh in ds)
            {
                s += mh as MonHoc + ";";
            }
            return s;
        }


    }
