﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Digite o primeiro valor: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valores digitados: {0} e {1}", num1, num2);
        }
    }
}
