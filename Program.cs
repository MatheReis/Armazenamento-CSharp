using System;

namespace Teste_em_C__Armazenamento
{
    class Program
    {
        static void Main(string[] args)
        {
           //declaração das variáveis do programa
           int A, B , C, D;

           //atribui o valor 0 à variável D
           D = 0;

           //exibe na tela o valor D com frase explicativa
           Console.WriteLine("Valor de D: " + D);

           //atribui o valor 2 à variável A
           A = 2;

           //exibe na tela o valor de A com frase explicativa
           Console.WriteLine("Valor de A: " + A); 

           //atribui o valor 3 à variável B
           B = 3;

           //exibe na tela o valor de B com frase explicativa
           Console.WriteLine("Valor de B: " + B);

           //atribui o valor 5 à variável C
           C = 5;

           //exibe na tela o valor de C com frase explicativa
           Console.WriteLine("Valor de C: " + C);

           //atualiza a variàvel C o seu valor anterior acrescido de 1
           C = C + 1;

           //exibe na tela o valor de C (atualizado) com 
           //frase explicativa
           Console.WriteLine("Valor de C: " + C);

           //atribui à variável D a soma do valor de A com o  valor atual de C
           D = A + C;

           //exibe na tela o  valor de D (atualizado) com frase explicativa
           Console.WriteLine("Valor de D: " + D);
        }
    }
}
