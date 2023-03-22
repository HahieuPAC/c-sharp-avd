using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ICollectionTrongCSharp
{
    class Program
    {
        private ArrayList array;

        public void Sort(IComparer comparer)
        {
            /* Mình sử dụng thuật toán sắp xếp đơn giản nhất nhé. 
             * Còn thực sự hàm Sort của .NET sử dụng thuật toán khác nha.
             */
            int count = array.Count;
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    // Nếu phần tử i bé hơn phần tử j thì thực hiện hoán đổi vị trí 2 phần tử này
                    if (comparer.Compare(array[i], array[j]) > 0)
                    {
                        object tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            
        }
    }

    public class MyArrayList : ICollection
    {
        private object[] lstObj; // mảng giá trị
        private int count; // số lượng phần tử
        private const int MAXCOUNT = 100; // số lượng phần tử tối đa

        public MyArrayList()
        {
            count = -1;
            lstObj = new object[MAXCOUNT];
        }

        public MyArrayList(int count)
        {
            this.count = count;
            lstObj = new object[count];
        }

        public MyArrayList(Array array)
        {
            array.CopyTo(lstObj, 0);
            count = array.Length;
        }

        public void CopyTo(Array array, int index)
        {
            // thực hiện copy các phần tử trong lstObj từ vị trí index đến cuối sang mảng array.
            lstObj.CopyTo(array, index);
        }

        public int Count
        {
            get { return count; }
        }

        public bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }

        public object SyncRoot
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
