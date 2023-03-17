using System.Collections.Generic;

namespace Generic
{

    public class MyGeneric<T>
    {
        private T [] items;
        public T[] Item
        {
            get { return items; }
        }

        public MyGeneric(int Size)
        {
            items = new T[Size];
        }

        public T GetByIndex(int Index)
        {
            // Nếu index vượt ra khỏi chỉ số phần tử của mảng thì ném ra ngoại lệ
            if (Index < 0 || Index >= items.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return items[Index];
            }
        }
        
        public void SetItemValue(int Index, T Value)
        {
            if (Index < 0 || Index >= items.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                items[Index] = Value;
            }
        }
    }    
    class Program
    {
        static void Main(string[] args) 
        {
            MyGeneric<int> MyG = new MyGeneric<int>(5);

            MyG.SetItemValue(0, 32);

            foreach (var data in MyG.Item)
            {
                Console.WriteLine(data);
            }
           
        }
    }


}