using System;
using System.Collections.Generic;
using System.Text;

namespace Work1
{
    class MoveSquare
    {
        public static string WhatButton = "";
        public MoveSquare()
        {
            Console.WriteLine("");
            Action();
        }
        static void Action()
        {
            Console.WriteLine("Нажмите стрелку вправо, чтобы передвинуть квадрат вправо");
            Console.WriteLine("ИЛИ");
            Console.WriteLine("Нажмите стрелку влево, чтобы передвинуть квадрат влево");
            WhatButton = Convert.ToString(Console.ReadKey().Key);
            if (WhatButton == "RightArrow")
            {
                Program.lu.X += 1;
                Program.ld.X += 1;
                Program.ru.X += 1;
                Program.rd.X += 1;
                Show();
                Action();
            }
            else if (WhatButton == "LeftArrow")
            {
                Program.lu.X -= 1;
                Program.ld.X -= 1;
                Program.ru.X -= 1;
                Program.rd.X -= 1;
                Show();
                Action();
            }
            else
            {
                Action();
            }
        }
        public static void Show()
        {
            Console.WriteLine("");
            Console.WriteLine("Координаты квадрата: ");
            Console.WriteLine("Верхний левый угол: " + Program.lu);
            Console.WriteLine("Нижний левый угол: " + Program.ld);
            Console.WriteLine("Верхний правый угол: " + Program.ru);
            Console.WriteLine("Нижний правый угол: " + Program.rd);
            Console.WriteLine("");
        }
    }
}