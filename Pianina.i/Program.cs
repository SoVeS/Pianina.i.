using System;

namespace Pianina.i
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] OctaveOne = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
            int[] OctaveTwo = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 988 };
            int[] OctaveTree = new int[] { 1047, 1109, 1175, 1254, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            int[] OctaveZero;

            OctaveZero = OctaveOne;

            Console.WriteLine("Добро пожаловать в игру на Инвокере");
            Console.WriteLine("Для того чтобы поменять октаву нажимайте f1 f2 f3");
            Console.WriteLine("Для фф 15 нажмите esc");

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    ChangeOctave(ref keyInfo, ref OctaveZero);
                    Play(keyInfo, OctaveZero);
                }
            }

            static void ChangeOctave(ref ConsoleKeyInfo keyInfo, ref int[] OctaveZero)
            {
                int[] OctaveOne = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
                int[] OctaveTwo = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 988 };
                int[] OctaveTree = new int[] { 1047, 1109, 1175, 1254, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };


                if (keyInfo.Key == ConsoleKey.F1)
                {
                    OctaveZero = OctaveOne;
                }
                else if (keyInfo.Key == ConsoleKey.F2)
                {
                    OctaveZero = OctaveTwo;
                }
                else if (keyInfo.Key == ConsoleKey.F3)
                {
                    OctaveZero = OctaveTree;
                }

            }


            static void Play(ConsoleKeyInfo key, int[] OctaveZero)
            {


                if (key.Key == ConsoleKey.A)
                {
                    Console.Beep(OctaveZero[0], 100);
                }
                else if (key.Key == ConsoleKey.W)
                {
                    Console.Beep(OctaveZero[1], 100);
                }
                else if (key.Key == ConsoleKey.S)
                {
                    Console.Beep(OctaveZero[2], 100);
                }
                else if (key.Key == ConsoleKey.E)
                {
                    Console.Beep(OctaveZero[3], 100);
                }
                else if (key.Key == ConsoleKey.D)
                {
                    Console.Beep(OctaveZero[4], 100);
                }
                else if (key.Key == ConsoleKey.F)
                {
                    Console.Beep(OctaveZero[5], 100);
                }
                else if (key.Key == ConsoleKey.T)
                {
                    Console.Beep(OctaveZero[6], 100);
                }
                else if (key.Key == ConsoleKey.G)
                {
                    Console.Beep(OctaveZero[7], 100);
                }
                else if (key.Key == ConsoleKey.Y)
                {
                    Console.Beep(OctaveZero[8], 100);
                }
                else if (key.Key == ConsoleKey.H)
                {
                    Console.Beep(OctaveZero[6], 100);
                }
                else if (key.Key == ConsoleKey.U)
                {
                    Console.Beep(OctaveZero[7], 100);
                }
                else if (key.Key == ConsoleKey.J)
                {
                    Console.Beep(OctaveZero[8], 100);
                }
            }
        }
    }
}