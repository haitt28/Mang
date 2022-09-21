

using System.Text;

namespace Mang
{

    class Program
    {
        static void Main(string[] args)
        {
            //string[] ds;
            //ds = new string[3];
            //ds[0] = "Nguyễn văn A";
            //ds[1] = "Nguyễn văn b";
            //ds[2] = "Nguyễn văn c";
            Console.OutputEncoding = Encoding.UTF8;
            //for(int i = 0; i <= 2; i++)
            //{
            //    Console.WriteLine(ds[i]);
            //}    
            //Console.WriteLine(ds[0]);
            //Console.WriteLine(ds[1]);
            //Console.WriteLine(ds[2]);

            //    int[] mangsonguyen;
            //    string[] mang1 = new string[2];
            //    string[] mang2 = { "Xin chào", "Bla bla" };
            //    double[] kieusothuc;
            //    mangsonguyen = new int[3] { 22, 23, 24 };
            //    for (int i = 0; i < mangsonguyen.Length; i++)
            //    {
            //        Console.WriteLine(mangsonguyen[i]);
            //    }
            //    Console.WriteLine("----------------------------------");
            //    for (int i = mangsonguyen.Length-1; mangsonguyen.Length > 0; i--)
            //    {
            //        Console.WriteLine(mangsonguyen[i]);
            //    }
            //int[] numbers = { 3, 2, 5, 33, 67, 56, 10, 22, 3, 4, 6, 5 };

            //// lấy ra số lớn nhất 
            //Console.WriteLine($"Phần tử lơn nhất : {numbers.Max()}");
            //// lấy ra số bé nhất
            //Console.WriteLine($"Phần tử bé nhất : {numbers.Min()}");
            //// lấy ra độ dài của mảng
            //Console.WriteLine($"Độ dài của mảng: {numbers.Length}");
            //// lấy ra loại mảng
            //Console.WriteLine($"Loại mảng : {numbers.Rank}");

            int[,] songuyen = new int[3,4] { { 1, 2, 3, 4 }, { 0, 3, 1, 3 }, { 4, 2, 3, 4 } };
            for(int i = 0; i <= 2; i++)
            {
               
                for(int j = 0; j <= 3; j++)
                {
                    Console.Write(songuyen[i, j] + " ");
                }
                //Console.WriteLine();
            }
            Console.WriteLine(songuyen[2, 3]);
        }
    }
} 
    
