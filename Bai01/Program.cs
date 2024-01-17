using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class SinhVien
    {
        private string hoten;
        private double diemtoan;
        private double diemvan;
        private double diemngoaingu;
        private string khoihoc;

        public SinhVien()
        {

        }
        public SinhVien(string hoten,double diemtoan,double diemvan,double diemngoaingu,string khoihoc)
        {
            this.hoten = hoten;
            this.diemtoan = diemtoan;
            this.diemvan = diemvan;
            this.diemngoaingu = diemngoaingu;
            this.khoihoc = khoihoc;
        }
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public double Diemtoan
        {
            get { return diemtoan; }
            set { diemtoan = value; }
        }
        public double Diemvan
        {
            get { return diemvan; }
            set { diemvan = value; }
        }
        public double Diemngoaingu
        {
            get { return diemngoaingu; }
            set { diemngoaingu = value; }
        }
        public string Khoihoc
        {
            get { return khoihoc; }
            set { khoihoc = value; }
        }
        public double TinhTB()
        {
            
            if (khoihoc == "A")
            {
                return (Diemtoan * 2 + Diemvan + Diemngoaingu) / 4;
            }
            else if (khoihoc == "D")
            {
                return (Diemtoan + Diemvan + Diemngoaingu*2) / 4;
            }
            else if (khoihoc =="C")
            {
                return (Diemtoan  + Diemvan*2 + Diemngoaingu) / 4;
            }
            return 0;                 
        }
        public string TinhXepLoai()
        {
            double diemtb = TinhTB();
            if (diemtb>=5)
                return "DuocLenLop";
            else
                return "LuuBan";
        }
        public void InThongTin()
        {
            double diemtb = TinhTB();
            string loai = TinhXepLoai();
            Console.WriteLine($"Ho ten:{Hoten}");
            Console.WriteLine($"Diem Trung Binh:{TinhTB()}");
            Console.WriteLine($"Xep loai:{TinhXepLoai()}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv1 = new SinhVien();
            Console.Write("Nhap ho ten sinh vien:");
            sv1.Hoten = Console.ReadLine();
            Console.Write("Nhap diem toan:");
            sv1.Diemtoan= double.Parse(Console.ReadLine());
            Console.Write("Nhap diem van:");
            sv1.Diemvan = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem ngoai ngu:");
            sv1.Diemngoaingu = double.Parse(Console.ReadLine());
            Console.Write("Nhap khoi hoc:");
            sv1.Khoihoc = Console.ReadLine();
            sv1.InThongTin();


            SinhVien sv2 = new SinhVien("linh", 8, 9, 10, "A");
            sv2.InThongTin();
            Console.ReadLine();
        }
    }
}
