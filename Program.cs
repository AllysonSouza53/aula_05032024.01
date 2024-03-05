using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_05032024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entrada
            Console.Write("Informe qual o teu salário bruto: ");
            double s = double.Parse(Console.ReadLine());//bruto
            Console.Write("Informe qual o valor de teu vale alimetação: ");
            double va = double.Parse(Console.ReadLine());//+
            Console.Write("Informe qual a tua hora extra: ");
            double he = double.Parse(Console.ReadLine());//*vhe
            Console.Write("Informe qual o valor da tua hora extra: ");
            double vhe = double.Parse(Console.ReadLine());//*he
            Console.Write("Informe quantos filhos tu tem: ");
            int nf = int.Parse(Console.ReadLine());//*vnf
            Console.Write("Informe qual o valor da por filho: ");
            double vnf = double.Parse(Console.ReadLine());//*nf
            Console.Write("Informe qual o desconto do INNS: ");
            double dINSS = double.Parse(Console.ReadLine());//-
            Console.WriteLine("Informe qual o desconto do IRPF: ");
            double dIRPF = double.Parse(Console.ReadLine());//-

            //Processamento

            double sl = (s + va + (vhe * he) + (vnf * nf)) - (dINSS + dIRPF);

            //Saída

            Console.WriteLine("Salário líquido: " + sl.ToString("C"));

            //Encerramento

            Console.ReadKey();
        }
    }
}
