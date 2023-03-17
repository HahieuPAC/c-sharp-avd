using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BitArrayTrongCSharp
{
    class Program
    {
        public static void PrintBits(BitArray MyBA, int Width)
        {
            int i = Width;
            foreach (bool item in MyBA)
            {
                if (i < 1)
                {
                    i = Width;
                    Console.WriteLine();
                }
                i--;
                Console.Write(item.GetHashCode()); // In ra 0 1 thay vì true false
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            #region Khai báo và khởi tạo BitArray

            /*
             * Khởi tạo 1 BitArray có 10 phần tử. 
             * Mỗi phần tử có giá trị mặc định 0 (false).
             */
            BitArray MyBA = new BitArray(10);

            /*
             * Khởi tạo 1 BitArray có 10 phần tử. 
             * Mỗi phần tử có giá trị mặc định 1 (true).
             */
            BitArray MyBA2 = new BitArray(10, true);

            /*
             * Khởi tạo 1 BitArray từ một mảng bool có sẵn.
             */
            bool[] MyBools = new bool[5] { true, false, true, true, false };
            BitArray MyBA3 = new BitArray(MyBools); // 1 0 1 1 0

            /*
             * Khởi tạo 1 BitArray từ một mảng byte có sẵn.
             */
            byte[] MyBytes = new byte[5] { 1, 2, 3, 4, 5 };
            BitArray MyBA4 = new BitArray(MyBytes);

            // Kiểm thử. Uncomment để xem kết quả
            //Console.WriteLine("So bits cua BitArray la {0}", MyBA4.Length);
            //PrintBits(MyBA4, 8);

            /*
             * Khởi tạo 1 BitArray từ một mảng int có sẵn.
             */
            int[] MyInts = new int[5] { 1, 2, 3, 4, 5 };
            BitArray MyBA5 = new BitArray(MyInts);

            // Kiểm thử. Uncomment để xem kết quả
            //Console.WriteLine("So bits cua BitArray la {0}", MyBA5.Length);
            //PrintBits(MyBA5, 32);

            #endregion

            #region Ví dụ sử dụng BitArray

            // Khởi tạo 1 BitArray từ mảng bool có sẵn
            bool[] MyBool2 = new bool[5] { true, false, true, true, false };
            BitArray MyBA6 = new BitArray(MyBool2);

            // Khởi tạo 1 BitArray có 2 phần tử và có giá trị mặc định là 1 (true)
            bool[] MyBool3 = new bool[] { false, true, true, false, false };
            BitArray MyBA7 = new BitArray(MyBool3);

            Console.Write(" Gia tri cua MyBA6: ");
            PrintBits(MyBA6, 5);

            Console.Write(" Gia tri cua MyBA7: ");
            PrintBits(MyBA7, 5);

            Console.WriteLine(" Thuc hien cac phep toan AND, OR, NOT, XOR tren MyBA6 va MyBA7: ");
            
            // thực hiện sao chép giá trị của MyBA6 ra để không làm thay đổi nó
            BitArray AndBit = MyBA6.Clone() as BitArray; 
            AndBit.And(MyBA7);
            Console.Write(" Ket qua cua phep toan AND: ");
            PrintBits(AndBit, 5);

            BitArray OrBit = MyBA6.Clone() as BitArray;
            OrBit.Or(MyBA7);
            Console.Write(" Ket qua cua phep toan OR: ");
            PrintBits(OrBit, 5);

            BitArray XorBit = MyBA6.Clone() as BitArray;
            XorBit.Xor(MyBA7);
            Console.Write(" Ket qua cua phep toan XOR: ");
            PrintBits(XorBit, 5);

            BitArray NotBit = MyBA6.Clone() as BitArray;
            NotBit.Not();
            Console.Write(" Ket qua cua phep toan NOT tren MyBA6: ");
            PrintBits(NotBit, 5);

            #endregion

            Console.ReadLine();
        }
    }
}
