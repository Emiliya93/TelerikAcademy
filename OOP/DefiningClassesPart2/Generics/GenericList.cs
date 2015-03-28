namespace Generics
{
    using System;
    using System.Text;

    public class GenericList<T> where T : IComparable
    {
        // Fields
        private T[] list;
        private int count;
        private int capacity;

        // Constructor
        public GenericList(int capacity)
        {
            this.Capacity = capacity;
            this.list = new T[this.capacity];
            this.Count = 0;
        }

        // Properties
        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Capacity cannot be less than zero or zero!");
                }
                this.capacity = value;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                this.count = value;
            }
        }

        // Methods
        public void AddElement(T element)
        {
            CheckForCapacity();

            this.list[this.Count] = element;
            this.Count++;
        }

        private void CheckForCapacity()
        {
            if (this.Count == this.Capacity)
            {
                this.Capacity = this.Capacity * 2;
                T[] oldList = this.list;
                this.list = new T[this.Capacity];
                Array.Copy(oldList, this.list, this.Count);
            }
        }

        public T ElementAt(int inputIndex)
        {
            if (inputIndex < 0 || inputIndex > this.Count)
            {
                throw new ArgumentOutOfRangeException("Index cannot be less than zero or more than elemnts count!");
            }
            return this.list[inputIndex];
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > this.Count)
            {
                throw new ArgumentOutOfRangeException("Index cannot be less than zero or more than elemnts count!");
            }
            this.list[index] = default(T);
            for (int i = index; i < this.Count; i++)
            {
                if (i + 1 < this.Count - 1)
                {
                    this.list[i] = this.list[i + 1];
                }
            }
            this.Count--;
        }

        public void Clear(T[] list)
        {
            for (int i = 0; i < this.list.Length; i++)
            {
                this.list[i] = default(T);
            }
            this.count = 0;
        }

        public void Insert(T element, int index)
        {
            CheckForCapacity();

            for (int i = this.Count - 1; i >= index; i--)
            {
                this.list[i + 1] = this.list[i];
            }

            this.list[index] = element;
            this.Count++;
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < this.list.Length; i++)
            {
                if (element.Equals(this.list[i]))
                {
                    return i;
                }
            }

            // If element is not found
            return -1;  
        }

        //public T Min<T>()
        public T Min()
        {
            T min = this.list[0];

            for (int i = 1; i < this.Count; i++)
            {
                // If list[i] < min
                if (this.list[i].CompareTo(min) < 0)
                {
                    min = this.list[i];
                }
            }

            return min;
        }

        public T Max()
        {
            T max = this.list[0];

            for (int i = 1; i < this.Count; i++)
            {
                if (this.list[i].CompareTo(max) > 0)
                {
                    max = this.list[i];
                }
            }

            return max;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                sb.Append(this.list[i]);
                if (i != this.Count - 1)
                {
                    sb.Append(", ");
                }
            }

            return sb.ToString();
        }
    }
}
