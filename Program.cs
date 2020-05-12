using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aumento_Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Aumento_Salario

            double salario;
            double valorAumento;

            Console.WriteLine("Escreva o salário do Colaborador: ");

            salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O seu salário antes do ajuste era: " + salario);

            if (salario <= 280)
            {
                valorAumento = salario * 0.2;
                salario *= 1.2;
                Console.WriteLine("O percentual de aumento foi de 20%");
                Console.WriteLine("O valor do aumento foi: " + valorAumento);
            }

            if (salario > 280 && salario <= 700)
            {
                valorAumento = salario * 0.15;
                salario *= 1.15;
                Console.WriteLine("O percentual de aumento foi de 15%");
                Console.WriteLine("O valor do aumento foi: " + valorAumento);
            }

            if (salario > 700 && salario <= 1500)
            {
                valorAumento = salario * 0.1;
                salario *= 1.1;
                Console.WriteLine("O percentual de aumento foi de 10%");
                Console.WriteLine("O valor do aumento foi: " + valorAumento);
            }

            if (salario > 1500)
            {
                valorAumento = salario * 0.05;
                salario *= 1.05;
                Console.WriteLine("O percentual de aumento foi de 5%");
                Console.WriteLine("O valor do aumento foi: " + valorAumento);
            }

            Console.WriteLine("O valor do aumento foi de: " + salario);

            Console.ReadLine();

            #endregion
        }
    }
}
