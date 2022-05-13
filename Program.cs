using System;

namespace elementos_repetidos_em_um_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumeroDeEntradas = 0;
            int contador = 0;

           
            Console.WriteLine("Digite o tamanho do seu array");
            NumeroDeEntradas  = Convert.ToInt32(Console.ReadLine());
            int[] entradas = new int[NumeroDeEntradas];

            for (int i = 0; i < entradas.Length; i++)
            {
                Console.WriteLine("Digite um elemento");
                entradas[i] = int.Parse(Console.ReadLine());
            }


            for(int i = 0; i < entradas.Length; i++)
            {
                for(int j = i + 1; j < entradas.Length; j++)
                {
                    if (j != i && entradas[j] == entradas[i])
                    {
                        contador++;
                            break;
                    }
                }
               
            }
           
            
            if (contador <= 0)
            {
                Console.WriteLine("não há nenhum elemento se repetindo");
            }
            else
            {
                Console.WriteLine("há elementos repetidos");

            }
            Console.WriteLine("Total de elementos repetidos ->" + contador);
        } 
    }
}
