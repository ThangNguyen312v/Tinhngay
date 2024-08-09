using System;
using System.IO.Compression;
namespace tinhngay{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Which month that you want to count days? ");
            int month = Int32.Parse(Console.ReadLine());

            switch(month){
                case 2:
                       Console.WriteLine("thang 2 co 28 hoac 29 ngay");
                       break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                       Console.WriteLine("thang: " + month + " co 31 ngay");
                       break; 
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("thang: " + month + " co 30 ngay");
                       break; 
                default: 
                    Console.WriteLine("Nhap sai roi");
                    break;       

                       
            }
        }
    }
}
