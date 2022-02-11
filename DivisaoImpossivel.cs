
/*
Você terá o desafio de escrever um algoritmo que leia 2 números e imprima o resultado da divisão do primeiro pelo segundo.
Caso não for possível, mostre a mensagem “divisao impossivel” para os valores em questão.
*/

using System;

class Desafio {
    static void Main() {
        int limit = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < limit; i++) 
        {
            string[] line = Console.ReadLine().Split(" ");
            double X = double.Parse(line[0]);
            double Y = double.Parse(line[1]);
            
            if (Y == 0) {
                Console.WriteLine("divisao impossivel");
            } else {
                Console.WriteLine(String.Format("{0:0.0}", (X/Y)));
            }
        }
    }
}
