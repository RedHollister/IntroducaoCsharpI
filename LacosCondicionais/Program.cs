using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosCondicionais
{
    class Program

    {
        static void Main(string[] args)
        {
            // Laços Condicionais => Execução mediante determinada condição/situação satisfeita
            int hora = 15;
            //if(hora >= 15) //se a hora for maior ou igual a 15, será impressa a mensagem no console
            //{
            //    Console.WriteLine("Já são 15h ou mais!");
            //}

            //if(hora >=15 || hora ==13)
            //{
            //    Console.WriteLine("A hora é maior ou igual a 15 OU é igual a 13!");
            //}

            //else if(hora >=13)
            //{
            //    Console.WriteLine("A hora é igual ou maior que 13!");
            //}

            //else //o else garante a execução do bloco de código seguinte a ele
            //{
            //    Console.WriteLine("Não não chegou nem nas 13!");
            //}

            //switch
            //Geralmente a expressão avaliada é uma constante
            switch(hora)
            {
                case 15: //O teste condicional aqui é exato
                    Console.WriteLine("São 15h!");
                    break;
                case 18: //O teste condicional aqui é exato
                    Console.WriteLine("São 18h!");
                    break;
            }

            PrimeiroSemestre mes = PrimeiroSemestre.Maio;
            switch(mes)
            {
                case PrimeiroSemestre.Janeiro:
                    Console.WriteLine("Estamos em Janeiro!");
                    break;
                case PrimeiroSemestre.Fevereiro:
                    Console.WriteLine("Estamos em Fevereiro!");
                    break;
                case PrimeiroSemestre.Marco:
                    Console.WriteLine("Estamos em Março!");
                    break;
                case PrimeiroSemestre.Abril:
                    Console.WriteLine("Estamos em Abril!");
                    break;
                case PrimeiroSemestre.Maio:
                    Console.WriteLine("Estamos em Maio!");
                    break;
                case PrimeiroSemestre.Junho:
                    Console.WriteLine("Estamos em Junho!");
                    break;
            }
        }
    }

    public enum PrimeiroSemestre
    {
        Janeiro, Fevereiro, Marco, Abril, Maio, Junho
    }
}
