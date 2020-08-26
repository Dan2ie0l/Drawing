using System;
using System.Text;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            var pnt = new Paint();

            Console.Write("Object name: ");
            string answer = Console.ReadLine();

            pnt.Draw(answer);
            Console.ReadKey();
        }
    }
    class Paint
    {
        protected string Line = "-";
        protected string Arrow = "→";
        protected string doubleArrow = "↔";
        protected string Rectangle = "▬";
        protected string Square = "■";
        protected string Triangle = "▲";

        public void Draw(string objectType)
        {
            string drawingObject;

            switch (objectType.ToUpper())
            {
                case "LINE":
                    drawingObject = Line;
                    break;
                case "ARROW":
                    drawingObject = Arrow;
                    break;
                case "DOUBLE ARROW":
                    drawingObject = doubleArrow;
                    break;
                case "RECTANGLE":
                    drawingObject = Rectangle;
                    break;
                case "SQUARE":
                    drawingObject = Square;
                    break;
                case "TRIANGLE":
                    drawingObject = Triangle;
                    break;
                default:
                    drawingObject = "Unknown Object";
                    break;
            }
            Console.WriteLine(drawingObject);
        }
    }
}