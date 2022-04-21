using System;
using System.Globalization;

namespace SistemaDeCalculosDeVendas_CSharp_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, cod2, qtd1, qtd2;
            double preco1, preco2, total;

            Console.WriteLine("Digite o código do produto, a quantidade e o valor unitário da peça 01:");

            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            qtd1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o código do produto, a quantidade e o valor unitário da peça 02:");

            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            qtd2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = preco1 * qtd1 + preco2 * qtd2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
