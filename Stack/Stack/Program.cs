using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BitArrayinCS
{
    class program
    {
        static void Main(string[] args)
        {
            BitArray BA1 = new BitArray(10);
            BitArray BA2 = new BitArray(10, true);
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

            BitArray MyArray = new BitArray(MyBools);

            bool[] Mybool2 = new bool[] { false, true, true, false, false };
            BitArray MyArray2 = new BitArray(Mybool2);

            Console.WriteLine("Gia tri cua MyArray la: ");
            PrintBits(MyArray, 5);

            Console.WriteLine("Gia tri cua MyArray2 la: ");
            PrintBits(MyArray2, 5);

            Console.WriteLine(" Thuc hien cac phep toan AND, OR, NOT, XOR tren MyBA6 va MyBA7: ");

            BitArray AndBit = MyArray.Clone() as BitArray;
            AndBit.And(MyArray2);
            Console.Write("Ket qua cua phep AND: ");
            PrintBits(AndBit, 5);

            BitArray orBit = MyArray.Clone() as BitArray;
            orBit.Or(MyArray2);
            Console.Write("Ket qua cua phep OR: ");
            PrintBits(orBit, 5);

            BitArray XorBit = MyArray.Clone() as BitArray;
            XorBit.Xor(MyArray2);
            Console.Write("Ket qua cua phep XOR: ");
            PrintBits(XorBit, 5);

            BitArray NotBit = MyArray.Clone() as BitArray;
            NotBit.Not();
            Console.Write("Ket qua cua phep NOT: ");
            PrintBits(NotBit, 5);




            static void PrintBits(BitArray MyBA, int Width)
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
        }
    }


}


