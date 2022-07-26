using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Pasta lógica
namespace LacosIterativos
{
    class Program
    {
        //Método Main:
        //Ponto de entrada para a aplicação, ou seja, é
        //O que define o início da aplicação
        static void Main(string[] args)
        {
            //Laço for
            for(int i=0; i <= 5; i++)
            {
                Console.WriteLine("Valor de i é " + i);
            }

            //While
            int contador = 3;
            while(contador < 10)
            {
                contador++;
                Console.WriteLine("O valor de contador é: " + contador);
            }

            //Do .. while
            //Execução Garantida pelo menos uma vez!
            double j = 10;
            do
            {
                Console.WriteLine(j);
                j = j * 1.5;
            } while (j < 100);

            //Foreach
            //Percorre todos os elementos de um conjunto
            int[] conjunto = { 1, 2, 3, 4, 5, 6, };
            foreach(int numero in conjunto)
            {
                Console.WriteLine("Esse elemento do conjunto tem valor: " + numero + "! Somando esse valor a 25 temos " + (numero + 25));
            }
        }
    }
}