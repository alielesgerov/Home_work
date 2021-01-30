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

    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(10, 20);
            point.Show();
        }
    }
}
