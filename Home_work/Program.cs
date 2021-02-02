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

    class Fraction
    {
        int Numerator { set; get; }
        int Denominator { set; get; }
        public Fraction() {}
        public Fraction(int numerator,int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }
        public void GetReducedFraction()
        {
            for (int i = Denominator * Numerator; i > 1; i--)
		    {
			    if ((Denominator % i == 0) && (Numerator % i == 0))
			    {
				    Denominator /= i;
				    Numerator /= i;
			    }

       		}
        }

        public static Fraction operator +(Fraction a) => a;

        public static Fraction operator -(Fraction a) => new Fraction(-a.Numerator, a.Denominator);

        public static Fraction operator +(Fraction a, Fraction b) => new Fraction(a.Numerator * b.Denominator + b.Numerator * a.Denominator, a.Denominator * b.Denominator);

        public static Fraction operator -(Fraction a, Fraction b) => a + (-b);

        public static Fraction operator *(Fraction a, Fraction b)=> new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.Numerator == 0)
            {
                throw new DivideByZeroException();
            }
            return new Fraction(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
        }

        public void Show()
        {
            GetReducedFraction();
            Console.WriteLine($"{Numerator}/{Denominator}");
        }
    }

    class Car
    {
        int Id { get; set; }
        string Model { get; set; } = String.Empty;
        string Vendor { get; set; } = String.Empty;
        DateTime ProduceYear { get; set; } = DateTime.Now;

        public Car(in int id, in string model, in string vendor, in DateTime produceYear)
        {
            Id = id;
            Model = model;
            Vendor = vendor;
            ProduceYear = produceYear;
        }
        public int Age
        {
            get
            {
                var years = DateTime.Now.Year - ProduceYear.Year;
                return years;
            }
        }

        public void Show()
        {
            Console.WriteLine($"Car ID: {Id}");
            Console.WriteLine($"Car Model: {Model}");
            Console.WriteLine($"Car Vendor: {Vendor}");
            Console.WriteLine($"Car Produce Year: {ProduceYear.ToString("MM/dd/yy")}");
            Console.WriteLine($"Car Age: {Age}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            /*Point point = new Point(10, 20);
            point.Show();*/

            //Counter counter = new Counter(10,20);
            //for (int i = 0; i < 40; i++)
            //{
            //    counter.Increment();
            //    counter.Show();
            //}

            //Fraction fraction = new Fraction(50,100);
            //Fraction fraction1 = new Fraction(30, 90);
            //fraction = fraction + fraction1;
            //fraction.Show();

            Car car = new Car(1, "Maybach", "Mercedes", new DateTime(2005,11,12));
            car.Show();
        }
    }   
}
