using System;

namespace GrupoIII
{
    public class Exercicio3
    {
        #region A
        public static void ApresentarTabela()
        {
            Console.WriteLine("Linhas?");
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine("Colunas?");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("Caracter?");
            var c = Console.ReadLine();
            
            var count = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (count % 2 == 0)
                        Console.Write($"{c} ");
                    else
                    {
                        Console.Write($"{c} ");
                    }
                    count++;
                }
                Console.Write("\n");
            }
        }
        #endregion

        #region B
        public static void MultiploDeTresESete()
        {
            Console.WriteLine("Numero para verificar se é multiplo de 3 ou 7?");
            int nr = int.Parse(Console.ReadLine());

            if (nr % 3 == 0 && nr % 7 == 0)
            {
                Console.WriteLine("É multiplo de 3 e 7");
            }
            else if (nr % 3 == 0)
            {
                Console.WriteLine("É multiplo de 3");
            }
            else if (nr % 7 == 0)
            {
                Console.WriteLine("É multiplo de 7");
            }
            else
            {
                Console.WriteLine("Não é multiplo de 3 ou 7");
            }
        }

        #endregion

        #region C

        public static int FactorialRecursivo(int nr)
        {
            if (nr == 1) return nr;
            return nr * (FactorialRecursivo(nr - 1));

        }

        public static int FactorialIterativo(int nr)
        {           
            if (nr == 1) return nr;

            else
            {
                for (var i = 1; i <= nr; i++)
                {
                    return nr * FactorialIterativo(nr-1);
                }
                return nr;
            }
        }

        public static void Factorial()
        {
            Console.WriteLine(FactorialRecursivo(3));
            Console.WriteLine(FactorialIterativo(3));
        }

        #endregion









    }
}
