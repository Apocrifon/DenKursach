using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    internal class BinaryHeap<T> where T : IComparable<T>
    {
        private List<T> heap ;
        public int Count { get { return heap.Count; } }
        public bool IsMax;

        public BinaryHeap(bool type) 
        {
            heap = new List<T>();
            IsMax= type;
        }

        public T this[int index]
        {
            get => heap[index];
            set => heap.Insert(index,value);
        }


        public void InsertMin(T value)
        {
            heap.Add(value);
            int currentIndex = heap.Count - 1;

            while (currentIndex > 0 && value.CompareTo(heap[currentIndex / 2]) < 0)
            {
                heap[currentIndex] = heap[currentIndex / 2];
                currentIndex /= 2;
            }

            heap[currentIndex] = value;
        }

        public void DeleteMin(int currentIndex)
        {
            heap.RemoveAt(0);

            int rootIndex = currentIndex;
            while (2 * currentIndex + 1 < heap.Count)
            {
                int left = 2 * currentIndex + 1;
                int right = 2 * currentIndex + 2;
                int j = left;

                if (right < heap.Count && heap[right].CompareTo(heap[left]) < 0)
                    j = right;

                if (heap[currentIndex].CompareTo(heap[j]) <= 0)
                    break;

                (heap[currentIndex], heap[j]) = (heap[j], heap[currentIndex]);
                currentIndex = j;
            }

        }

        public void InsertMax(T value)
        {
            heap.Add(value);
            int i = heap.Count - 1;

            while (i > 0 && heap[i].CompareTo(heap[(i - 1) / 2]) > 0)
            {
                (heap[i], heap[(i - 1) / 2])=(heap[(i - 1) / 2], heap[i]);
                i = (i - 1) / 2;
            }
        }

        public void DeleteMax(int currentIndex)
        {
            heap.RemoveAt(0);
            while (2 * currentIndex + 1 < heap.Count)
            {
                int left = 2 * currentIndex + 1;
                int right = 2 * currentIndex + 2;
                int j = left;

                if (right < heap.Count && heap[right].CompareTo(heap[left]) > 0)
                    j = right;

                if (heap[currentIndex].CompareTo(heap[j]) >= 0)
                    break;

                (heap[currentIndex], heap[j]) = (heap[j], heap[currentIndex]);
                currentIndex = j;
            }
        }

        public BinaryHeap<T> MergeMin(BinaryHeap<T> heap2)
        {
            BinaryHeap<T> mergedHeap = new BinaryHeap<T>(this.IsMax);

            for (int i = 0; i < heap.Count; i++)
            {
                mergedHeap.InsertMin(heap[i]);
            }

            for (int i = 0; i < heap2.Count; i++)
            {
                mergedHeap.InsertMin(heap2[i]);
            }

            return mergedHeap;
        }

        public BinaryHeap<T> MergeMax(BinaryHeap<T> heap2)
        {
            BinaryHeap<T> mergedHeap = new BinaryHeap<T>(this.IsMax);

            for (int i = 0; i < heap.Count; i++)
            {
                mergedHeap.InsertMax(heap[i]);
            }

            for (int i = 0; i < heap2.Count; i++)
            {
                mergedHeap.InsertMax(heap2[i]);
            }

            return mergedHeap;
        }

        public void Insert(T item)
        {
            if (IsMax)
                InsertMax(item);
            else
                InsertMin(item);
        }

        public void Delete()
        {
            if (IsMax)
                DeleteMax(0);
            else
                DeleteMin(0);
        }

        public BinaryHeap<T> Merge(BinaryHeap<T> heap2)
        {
            BinaryHeap<T> res;
            if (this.IsMax)
                res=MergeMax(heap2);
            else
                res= MergeMin(heap2);
            return res;
        }
    }
}
