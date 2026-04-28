using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("dados da primeira pessoa: ");
            Console.WriteLine("nome");
            p1.nome = Console.ReadLine();
            Console.WriteLine("idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("dados da segunda pessoa: ");
            Console.WriteLine("nome");
            p2.nome = Console.ReadLine();
            Console.WriteLine("idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                Console.WriteLine("primeira pessoa mais velha");
            }
            else
            {
                Console.WriteLine("segunda pessoa mais velha");
            }
        }
    }
}
