using System;
using System.Collections;
using System.Collections.Generic;
using static Lab3.SinhVien;

namespace Lab3
{
    internal class Program
    {

        public class myComparer : IComparer
        {
            public int Compare(object x, object y)
            {
               SinhVien sv1 = (SinhVien) x;
               SinhVien sv2 = (SinhVien) y;
                return sv1.Ten.CompareTo(sv2.Ten);
            }
        }

        public static SinhVien FindSt(string ten, ArrayList dsSv)
        {

            foreach (SinhVien s in dsSv)
            {
                if (s.Ten == ten)
                {
                    System.Console.WriteLine(s);
                    return s;
                }
            }
            return null;

        }

        public static SinhVien FindStByMaSv(int maSV, ArrayList dsSv)
        {

            foreach (SinhVien s in dsSv)
            {
                if (s.MaSv == maSV)
                {
                    System.Console.WriteLine(s);
                    return s;
                }
            }
            return null;

        }

        public static void addSt(SinhVien sv1, ArrayList dsSv)
        {
            if (!dsSv.Contains(sv1))
            {
                dsSv.Add(sv1);
                System.Console.WriteLine("Them thanh cong");
            }
            else
            {
                System.Console.WriteLine("Them that bai");
            }
        }

        public static void removeSt(int maSv, ArrayList dsSv)
        {
            for(int i = 0; i < dsSv.Count; i++)
            {
                SinhVien tmp =(SinhVien) dsSv[i];
                if(tmp.MaSv == maSv)
                {
                    System.Console.WriteLine("Xoa thanh cong");
                    dsSv.Remove(tmp);
                }

            }

        }

        public static void editSt(int maSv, ArrayList dsSv, SinhVien editSv)
        {
            for (int i = 0; i < dsSv.Count; i++)
            {
                SinhVien tmp = (SinhVien)dsSv[i];
                if (tmp.MaSv == maSv)
                {
                    tmp = editSv;
                    Console.WriteLine("Sua thanh cong");
                    Console.WriteLine(tmp + "");
                }
            }
        }

        public static void sortSt(ArrayList dsSv)
        {
            dsSv.Sort(new myComparer());
            foreach (SinhVien i in dsSv)
            {
                Console.WriteLine(i + "");
            }
            
        }
              
        
        static void Main(string[] args)
        {
            ArrayList dsSv = new ArrayList();

            MonHoc m1 = new MonHoc(111, "CSDL", 4, 9.5);
            MonHoc m2 = new MonHoc(112, "DHMT", 2, 1.1);
            MonHoc m3 = new MonHoc(113, "LTHDT", 3, 5.5);
            MonHoc m4 = new MonHoc(114, "HDHCB", 2, 7.0);
            MonHoc m5 = new MonHoc(115, "LTM", 4, 8.0);
            MonHoc m6 = new MonHoc(116, "LTW", 4, 7.5);
            MonHoc m7 = new MonHoc(117, "HDHNC", 2, 7.0);
            MonHoc m8 = new MonHoc(118, "TOANRR", 3, 6.0);
            MonHoc m9 = new MonHoc(119, "LTDT", 4, 7.5);
            ArrayList dsMon1 = new ArrayList();
            dsMon1.Add(m1);
            ArrayList dsMon2 = new ArrayList();
            dsMon2.Add(m2);
            ArrayList dsMon3 = new ArrayList();
            dsMon3.Add(m3);
            ArrayList dsMon4 = new ArrayList();
            dsMon4.Add(m4);
            ArrayList dsMon5 = new ArrayList();
            dsMon5.Add(m5);
            ArrayList dsMon6 = new ArrayList();
            dsMon6.Add(m6);
            ArrayList dsMon7 = new ArrayList();
            dsMon7.Add(m7);
            ArrayList dsMon8 = new ArrayList();
            dsMon8.Add(m8);
            ArrayList dsMon9 = new ArrayList();
            dsMon9.Add(m9);



            SinhVien sv1 = new SinhVien(121, "Le Trong", "Tinh", new DateTime(2002, 07, 27), "Nam", "1111/8/12", dsMon1);
            SinhVien sv2 = new SinhVien(122, "Nguyen Van", "A", new DateTime(2002, 01, 12), "Nam", "Ha Noi", dsMon2);
            SinhVien sv3 = new SinhVien(123, "Pham Thi", "B", new DateTime(2002, 02, 22), "Nu", "Da Nang", dsMon3);
            SinhVien sv4 = new SinhVien(131, "Nguyen Vu Manh", "Ha", new DateTime(2002, 1, 1), "Nu", "Dong Nai", dsMon4);
            SinhVien sv5 = new SinhVien(132, "Tran Thi", "D", new DateTime(2002, 03, 22), "Nu", "Ca Mau", dsMon5);
            SinhVien sv6 = new SinhVien(133, "Pham Thanh", "E", new DateTime(2002, 04, 07), "Nam", "Ninh Binh", dsMon6);
            SinhVien sv7 = new SinhVien(141, "Phan Vo", "F", new DateTime(2002, 08, 28), "Nam", "Phu Tho", dsMon7);
            SinhVien sv8 = new SinhVien(142, "Le Huu", "G", new DateTime(2002, 09, 19), "Nu", "Long An", dsMon8);
            SinhVien sv9 = new SinhVien(143, "Trinh Thang", "H", new DateTime(2002, 10, 11), "Nam", "Phu Quoc", dsMon9);
            SinhVien sv10 = new SinhVien(145, "Ha", "Ngu", new DateTime(2002, 10, 11), "Nam", "Phu Quoc", dsMon5);
            dsSv.Add(sv1);
            dsSv.Add(sv2);
            dsSv.Add(sv3);
            dsSv.Add(sv4);
            dsSv.Add(sv5);
            dsSv.Add(sv6);
            dsSv.Add(sv7);
            dsSv.Add(sv8);
            dsSv.Add(sv9);

            ////FindSt("Tinh", dsSv).ToString();
            //addSt(sv10, dsSv);
            ////FindStByMaSv(145, dsSv).ToString();
            ////removeSt(143, dsSv);

            //editSt(145, dsSv, new SinhVien(145, "Ha", "Nguyen", new DateTime(2002, 10, 11), "Nam", "Phu Quoc", dsMon2));


            sortSt(dsSv);

        }
    }
}
