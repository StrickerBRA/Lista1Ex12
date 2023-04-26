using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, f, g;
            Console.WriteLine("Realizando: Operação (valor compra, pagamento e troco):");
            Console.Write("Digite o valor do primeiro produto:");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do segundo produto:");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do terceiro produto:");
            c = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do quarto produto:");
            d = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do quinto produto:");
            e = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor utilizado para o pagamento:");
            f = double.Parse(Console.ReadLine());

            g = f - (a + b + c + d + e);
            Console.WriteLine($"Com R${f} para o pagamento e R${a + b + c + d + e} do valor da compra, teve-se R${g} de troco");
        }
    }
}
