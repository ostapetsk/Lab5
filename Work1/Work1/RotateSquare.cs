using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Work1
{
    class RotateSquare
    {
        private static Point p = new Point();
        public RotateSquare()
        {
            Console.WriteLine("");
            Action();
        }
        static void Action()
        {
            Console.WriteLine("Нажмите стрелку вправо, чтобы вращать квадрат вправо");
            Console.WriteLine("ИЛИ");
            Console.WriteLine("Нажмите стрелку влево, чтобы вращать квадрат влево");
            MoveSquare.WhatButton = Convert.ToString(Console.ReadKey().Key);
            if (MoveSquare.WhatButton == "RightArrow")
            {
                p = Program.lu;
                Program.lu = Program.ld;
                Program.ld = Program.rd;
                Program.rd = Program.ru;
                Program.ru = p;
                MoveSquare.Show();
                Action();
            }
            else if (MoveSquare.WhatButton == "LeftArrow")
            {
                p = Program.ld;
                Program.ld = Program.lu;
                Program.lu = Program.ru;
                Program.ru = Program.rd;
                Program.rd = p;
                MoveSquare.Show();
                Action();
            }
            else
            {
                Action();
            }
        }
    }
}
