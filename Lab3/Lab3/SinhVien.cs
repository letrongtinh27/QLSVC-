using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class SinhVien 
    {
        private int maSv;
        private string hoLot;
        private string ten;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string diaChi;
        private ArrayList dsMonHoc;

        public SinhVien()
        {
        }

        public SinhVien(int maSv, string hoLot, string ten, DateTime ngaySinh, string gioiTinh, string diaChi, ArrayList dsMonHoc)
        {
            this.MaSv = maSv;
            this.HoLot = hoLot;
            this.Ten = ten;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.DsMonHoc = dsMonHoc;
        }

        public int MaSv { get => maSv; set => maSv = value; }
        public string HoLot { get => hoLot; set => hoLot = value; }
        public string Ten { get => ten; set => ten = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public ArrayList DsMonHoc { get => dsMonHoc; set => dsMonHoc = value; }



        public override string ToString()
        {
            String mon = "";
            foreach(MonHoc item in DsMonHoc)
            {
                mon += item.ToString();
            }
            return "Ma sv: "+MaSv + " Ho: " + HoLot + " Ten: " + Ten + " Ngay Sinh: " + NgaySinh.ToString() + " Gioi tinh: " + GioiTinh + " Dia chi: " + DiaChi +" Mon hoc: " + mon;
        }

    }
}
