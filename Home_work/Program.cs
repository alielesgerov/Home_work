using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work
{
    class Point
    {
        int X { get; set; }
        int Y { get; set; }
        public Point(){}
        public Point(int X,int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public void Show()
        {
            Console.WriteLine($"Point X: {X}");
            Console.WriteLine($"Point Y: {Y}");
        }
    }

    class Counter
    {
        int Min { set; get; }
        int Max { set; get; }
        int Current { set; get; }
        public Counter(){}
        public Counter(int Min,int Max)
        {
            this.Min = Min;
            this.Max = Max;
            this.Current = Min;
        }
       public void Increment()
        {
            if (Current < Max)
                Current++;
            else
                Current = Min;
        }
       public void Decrement()
        {
            if (Current > Min)
                Current--;
        }
        public void Show()
        {
            Console.Write($"{Current} ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*Point point = new Point(10, 20);
            point.Show();*/

            Counter counter = new Counter(10,20);
            for (int i = 0; i < 40; i++)
            {
                counter.Increment();
                counter.Show();
            }
        }
    }
}
