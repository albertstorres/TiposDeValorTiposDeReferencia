using System;

namespace TiposDeValorTiposDeReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new string[2];
            arr[0] = "item1";
            var arr2 = arr; // NÃO CRIA UMA CÓPIA. ARMAZENA A REFERÊNCIA DO ARR.

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

            arr[0] = "item alterado"; // ALTERA ARR E POR CONSEQUÊNCIA ARR2. ARR2 VAI APONTAR PRA O NOVO CONTEÚDO DE ARR.

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);
        }
    }
}
