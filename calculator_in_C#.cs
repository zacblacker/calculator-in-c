using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05032021
{
    class Program
    {
        enum opcao{ soma=1, subtraccao, multiplicacao, divisao }
        static void Main(string[] args)
        {
            var bd = "bom dia";
            
            int a;
            int b;
            int total;
        
            string math;
            Console.WriteLine(bd);
            Console.WriteLine("escolha uma das opcoes abaixo");
            Console.WriteLine("1-soma\n2-subtraccao\n3-multiplicacao\n4-divisao");
            int index =int.Parse(Console.ReadLine());
            opcao selecionado = (opcao)index;
            switch (selecionado)
            {
                case opcao.soma:
                    Console.WriteLine("coloque os dois numeros para somar");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    total = a + b;
                    Console.WriteLine("o total é:");
                    Console.WriteLine(total);


                    Console.WriteLine("\n \n \no programa sera fechado,obrigado pelo uso \n \n \n \n");

                    break;
                case opcao.subtraccao:
                    Console.WriteLine("coloque os dois numeros para subtrair");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    total = a - b;
                    Console.WriteLine("o total é:");
                    Console.WriteLine(total);


                    Console.WriteLine("\n \n \no programa sera fechado,obrigado pelo uso \n \n \n \n");

                    break;
                case opcao.multiplicacao:
                    Console.WriteLine("coloque os dois numeros para multiplicar");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    total = a * b;
                    Console.WriteLine("o total é:");
                    Console.WriteLine(total);


                    Console.WriteLine("\n \n \no programa sera fechado,obrigado pelo uso \n \n \n \n");

                    break;
                case opcao.divisao:
                    Console.WriteLine("coloque os dois numeros para dividir(use numeros que sao divisiveis)");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    total = a /b;
                    Console.WriteLine("o total é:");
                    Console.WriteLine(total);


                    Console.WriteLine("\n \n \no programa sera fechado,obrigado pelo uso \n \n \n \n");

                    break;
                default:
                    Console.WriteLine("\n \n \no programa sera fechado,obrigado pelo uso \n \n \n \n");
                    break;
            }
                
           
        }
    }
}
