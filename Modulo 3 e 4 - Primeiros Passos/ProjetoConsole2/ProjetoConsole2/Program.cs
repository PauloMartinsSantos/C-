using System;
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
            float res;

            Console.WriteLine("Digite o primeiro valor: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valores digitados: {0} e {1}", num1, num2);
            res = num1 + num2;
            Console.WriteLine("A soma dos valores é:{0} ",res);
            res = num1 - num2;
            Console.WriteLine("A subtração dos valores é:{0} ",res);
            res = num1 * num2;
            Console.WriteLine("A multiplicação dos valores é:{0} ", res);
            res = num1 / num2;
            Console.WriteLine("A divisão dos valores é:{0} ",res.ToString("N2"));

        }
    }
}
