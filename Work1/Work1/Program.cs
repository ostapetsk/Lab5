using System;
using System.Drawing;

namespace Work1
{
    class Program
    {
        public static Point lu = new Point();
        public static Point ld = new Point();
        public static Point ru = new Point();
        public static Point rd = new Point();
        public static Rectangle rectangle = new Rectangle();
        public static int RectangleLong = 0;
        static void Main(string[] args)
        {
            Input();
            DefinePoints();
            RectangleInfo();
            MoveSquare.Show();
            MoveOrRotate();
            string moveORrotate = Convert.ToString(Console.ReadKey().Key);
            if (moveORrotate == "M")
            {
                MoveSquare move = new MoveSquare();
            }
            else if (moveORrotate == "R")
            {
                RotateSquare rotate = new RotateSquare();
            }
        }
        static void MoveOrRotate()
        {
            Console.WriteLine("Нажмите клавишу 'm', для передвижения квадрата");
            Console.WriteLine("ИЛИ");
            Console.WriteLine("Нажмите клавишу 'r', для вращения квадрата");
        }
        static void Input()
        {
            Console.WriteLine("Задайте параметры квадрату");
            Console.WriteLine("Введите верхний левый угол квадрата ");
            Console.WriteLine("Введите координату X: ");
            lu.X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату Y: ");
            lu.Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину квадрата: ");
            RectangleLong = Convert.ToInt32(Console.ReadLine());
        }
        static void DefinePoints()
        {
            ld.X = lu.X;
            ld.Y = lu.Y - RectangleLong;
            ru.X = lu.X + RectangleLong;
            ru.Y = lu.Y;
            rd.X = ru.X;
            rd.Y = ru.Y - RectangleLong;
        }
        static void RectangleInfo()
        {
            rectangle.X = lu.X;
            rectangle.Y = lu.Y;
            rectangle.Width = RectangleLong;
            rectangle.Height = RectangleLong;
            Console.WriteLine("Заданый квадрат: ");
            Console.WriteLine(rectangle);
        }
    }
}
