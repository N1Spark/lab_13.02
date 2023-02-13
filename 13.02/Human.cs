using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02
{
    #region Зад 2
    class Passport
    {
        public string FIO { get; set; }
        public string Birthday { get; set; }
        public string National { get; set; }
        public string ID { get; set; }
        public Passport(string f, string b, string n, string i)
        {
            FIO = f;
            Birthday = b;
            National = n;
            ID = i;
        }
        public Passport() : this("", "", "", "") { }
        public void Print()
        {
            Console.WriteLine($"Fullname: {FIO}\nBirthday: {Birthday}\nNational: {National}\nID Card: {ID}");
        }
    }
    class ForeignPassport : Passport
    {
        public string InDate { get; set; }
        public string OutDate { get; set; }
        public string Type { get; set; }
        public ForeignPassport(string id, string o, string t,
            string f, string b, string n, string i) : base(f, b, n, i)
        {
            InDate = id;
            OutDate = o;
            Type = t;
        }
        public ForeignPassport() : this("", "", "", "", "", "", "") { }
        public new void Print()
        {
            base.Print();
            Console.WriteLine($"InDate: {InDate}\nOutDate: {OutDate}\nType: {Type}");
        }
        #endregion

        #region Зад 3
        class Animal
        {
            public string AnimalName { get; set; }
            public int Age { get; set; }
            public int Speed { get; set; }
            public Animal(string animalName, int age, int speed)
            {
                AnimalName = animalName;
                Age = age;
                Speed = speed;
            }
            public Animal() : this("", 0, 0) { }
            public void Print()
            {
                Console.WriteLine($"Animal: {AnimalName}\nAge: {Age}\nSpeed: {Speed}");
            }
        }
        class Tiger : Animal
        {
            public int Size { get; set; }
            public Tiger(int size, int age, int speed) : base("Tiger", age, speed)
            {
                Size = size;
            }
            public Tiger() : this(0, 0, 0) { }
            public new void Print()
            {
                base.Print();
                Console.WriteLine($"Size: {Size} sm");
            }
        }
        class Crocodile : Animal
        {
            public int Lenght { get; set; }
            public Crocodile(int lenght, int age, int speed) : base("Crocodile", age, speed)
            {
                Lenght = lenght;
            }
            public Crocodile() : this(0, 0, 0) { }
            public new void Print()
            {
                base.Print();
                Console.WriteLine($"Lenght: {Lenght} sm");
            }
        }
        class Kangaroo : Animal
        {
            public int Jump { get; set; }
            public Kangaroo(int jump, int age, int speed) : base("Kangaroo", age, speed)
            {
                Jump = jump;
            }
            public Kangaroo() : this(0, 0, 0) { }
            public new void Print()
            {
                base.Print();
                Console.WriteLine($"Jump: {Jump} sm");
            }
        }
        #endregion

        #region Зад 4
        abstract class Figure
        {
            virtual public int Square() { return 0; }
        }
        class Rectangle : Figure
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;
            }
            public Rectangle() : this(0, 0) { }
            public override int Square()
            {
                return Width * Height;
            }
        }
        class Circle : Figure
        {
            public int Radius { get; set; }
            public Circle(int radius)
            {
                Radius = radius;
            }
            public Circle() : this(0) { }
            public override int Square()
            {
                return Radius * 3;
            }
        }

        class RightTriangle : Figure
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public RightTriangle(int width, int height)
            {
                Width = width;
                Height = height;
            }
            public RightTriangle() : this(0, 0) { }
            public override int Square()
            {
                return ((Width * Height) / 2);
            }
        }
        class Trapeze : Figure
        {
            public int Width_up { get; set; }
            public int Width_down { get; set; }
            public int Side { get; set; }
            public Trapeze(int width_up, int width_down, int side)
            {
                Width_up = width_up;
                Width_down = width_down;
                Side = side;
            }
            public Trapeze() : this(0, 0, 0) { }
            public override int Square()
            {
                int buf = Width_down - Width_up;
                if (buf < 0)
                    buf *= -1;
                buf /= 2;
                buf = Convert.ToInt32(Math.Sqrt(Math.Pow(5, 2) - Math.Pow(buf, 2)));
                return (Width_down + Width_up) / 2 * buf;
            }
        }
        #endregion
    }
}
