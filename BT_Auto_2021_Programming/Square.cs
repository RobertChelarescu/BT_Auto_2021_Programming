﻿using System;


namespace BT_Auto_2021_Programming

{
    class Square
    {
        double side;

        public Square(double side)
        {
            this.side = side;
        }

        public Square()
        {

        }

        public void SetSide(double side)
        {
            this.side = side;
        }

        public double GetArea()
        {
            return Math.Pow(side, 2);
        }

        public void PrintSquare()
        {
            Console.WriteLine("The square with side {0} has the area {1}", side, GetArea());
        }

    }
}