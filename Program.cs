﻿using System;

namespace ParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            string txtTmp;
            int Z, quociente;

            Console.Clear();
            Console.Write("Informe um numero Z*+: ");
            txtTmp = Console.ReadLine();

            Z = int.Parse(txtTmp);
            quociente = Z % 2;

            Console.WriteLine("Resultado: " + quociente);
        }
    }
}
