using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressaocondiTernaria {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um Valor: ");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //suponhamos que queira calcular um desconto
            //abaixo utilizando condição ternaria (uma unica linha) simplificando
            double Desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;//verdadeiro ou falso
         /*   if(preco < 20.0) {
                //preço sendo menor que 20.0 ira cair aqui
                Desconto = preco * 0.1;
            }
            else {
                //se não ira cair aqui
                Desconto = preco * 0.05;
            }*/
            Console.WriteLine("Valor final com desconto: " + Desconto);
            Console.ReadKey();
        }
    }
}
