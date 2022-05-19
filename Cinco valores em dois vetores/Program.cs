using System;

namespace Cinco_valores_em_dois_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[5];
            int[] vetor2 = new int[5];
            int[] vetor3  = new int[5];
          
            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine("Insira um valor para o vetor 01: " + i);
                vetor1[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine(vetor1[i]);

            }

            for (int j = 0; j < vetor2.Length; j++)
            {
                Console.WriteLine("Insira um valor para o vetor 02: " + j);
                vetor2[j] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }

            for (int j = 0; j < vetor2.Length; j++)
            {
                Console.WriteLine(vetor2[j]);

            }

            vetor3[0] = vetor1[0] * vetor2[0];
            vetor3[01] = vetor1[01] * vetor2[01];
            vetor3[02] = vetor1[02] * vetor2[02];
            vetor3[03] = vetor1[03] * vetor2[03];
            vetor3[04] = vetor1[04] * vetor2[04];

            Console.WriteLine("O resultado da multiplicação é : " 
                + "\r\n indice 01 resultou em:"+ vetor3[0]
                + "\r\n indice 02 resultou em " + vetor3[01] 
                + "\r\n indice 02 resultou em " + vetor3[02] 
                + "\r\n indice 02 resultou em " + vetor3[03] 
                + "\r\n indice 02 resultou em " + vetor3[04]);
        }
        
      

    }
}
