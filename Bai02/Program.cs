using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class ChuNhat
    {
        private double rong;
        private double dai;
        public ChuNhat()
        {

        }

        public ChuNhat(double rong,double dai)
        {
            this.rong = rong;
            this.dai = dai;
        }
        public double Rong
        {
            get { return rong; }
            set { rong = value; }
        }
        public double Dai
        {
            get { return dai; }
            set { dai = value; }
        }
        public double TinhChuVi()
        {
            return 2 * (rong + dai);
        }
        public double TinhDienTich()
        {
            return dai * rong;
        }
        public virtual void Xuat()
        {
            Console.WriteLine($"Chieu rong:{rong},Chieu dai:{dai},Chu vi:{TinhChuVi()},Dien Tich:{TinhDienTich()}");

        }

    }
    class Vuong : ChuNhat
    {
        private double canh;
        public Vuong()
        {

        }

        public Vuong(double canh):base(canh,canh)
        {
            
        }
        public double Canh
        {
            get { return canh; }
            set { canh = value; }
        }
        
        public override void Xuat()
        { 
            Console.WriteLine($"Canh:{Rong},Chu vi:{TinhChuVi()},Dien tich:{TinhDienTich()}");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chieu dai hinh chu nhat:");
            double dai = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong hinh chu nhat:");
            double rong = double.Parse(Console.ReadLine());
            Console.Write("Nhap canh hinh vuong: ");
            double canh = double.Parse(Console.ReadLine());

            ChuNhat chunhat = new ChuNhat(dai, rong);
            Vuong vuong = new Vuong(canh);

            Console.WriteLine("*****Thong tin hinh chu nhat");
            chunhat.Xuat();
            Console.WriteLine("*****Thong tin hinh vuong");
            vuong.Xuat();
            Console.ReadLine();


        }
    }
}
