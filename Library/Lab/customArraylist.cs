using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class customArraylist :IEnumerable
    {
        private object[] list;
        private int count;
        private int capacity;
        public int Count{ get { return count;}}   
        public  int Capacity { get { return list.Length; } }
        public customArraylist(int _capacity=1)
        {
            this.count = 0;
            this.capacity = _capacity;
            this.list=new object[this.capacity];
        }
        public void Add(object elem)
        {
            if (this.count == this.capacity)
                Array.Resize(ref this.list, this.list.Length*2);
            this.list[count++] = elem;
            this.capacity=list.Length;

        }
        public void trimExcess()
        {
            object[] arr = new object[this.count];
           Array.Copy(list,arr,this.count);
            list = arr;
        }
        public object this[int index] { get {  return this.list[index]; } set { this.list[index] = value; } }
        public object Get(int index)
        {
           if(index >= list.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return list[index];
       }
        public void Remove_At(int index)
        {
        if(index>=capacity)
            throw new IndexOutOfRangeException();
         object[] arr= new object[this.count];
        int pointer = 0;
         for (int i = 0; i < count; i++)
         {
          if(i==index)
            {
                continue;
            }
          else
            {
                arr[pointer] = this.list[i];
                pointer++;
            }
         }
        Array.Copy(arr, arr, count - 1);
        this.count = count - 1;
        this.list = arr;
    }
        public IEnumerator GetEnumerator()
        {
            return new Enumerate(this);
        }
        private class Enumerate : IEnumerator
        {
            public object Current;
            private customArraylist arr;
            private int index;
            public Enumerate(customArraylist _list)
            {
                this.arr = _list;
                this.index = -1;
            }

            object IEnumerator.Current => this.arr[index];

            public bool MoveNext()
            {
                index++;
                return index <= this.arr.count; 
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
