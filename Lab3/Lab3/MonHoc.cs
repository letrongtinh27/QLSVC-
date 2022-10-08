using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class MonHoc
    {
        private int maMH;
        private string tenMh;
        private int soTc;
        private double diem;

        public MonHoc()
        {
        }

        public MonHoc(int maMH, string tenMh, int soTc, double diem)
        {
            this.MaMH = maMH;
            this.TenMh = tenMh;
            this.SoTc = soTc;
            this.Diem = diem;
        }

        public int MaMH { get => maMH; set => maMH = value; }
        public string TenMh { get => tenMh; set => tenMh = value; }
        public int SoTc { get => soTc; set => soTc = value; }
        public double Diem { get => diem; set => diem = value; }

        public override string ToString()
        {
            return "Ma Mon hoc: " + MaMH + " Ten Mon hoc: " + TenMh + " So Tin chi: " + SoTc + " Diem: " +Diem;
        }
    }

}
