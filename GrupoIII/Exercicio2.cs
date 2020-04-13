using System;

namespace GrupoIII
{
    public class Exercicio2
    {
        #region A
        public static string SolicitarNome()
        {
            Console.WriteLine("Qual o nome?");
            var nome = Console.ReadLine();  
            Console.WriteLine($"Olá {nome}");
            return nome;
        }
        #endregion

        #region B
        public static int QuantasPatas(int vacas, int porcos, int galinhas)
        {
            int pvacas = 4 * vacas;
            int pporcos = 4 * porcos;
            int pgalinhas = 2 * galinhas;
            int patas_total = pvacas + pporcos + pgalinhas;

            Console.WriteLine(patas_total);
            return patas_total;
        }
        #endregion

        #region C e D
        //região criada

        public static void ParOuImpar()
        {
            Console.WriteLine("Introduza um número para verificar se é par ou impar");           
            var nr = int.Parse(Console.ReadLine());

            if (nr % 2 == 0)
            {
                Console.WriteLine($"{nr} é par");
            }
            else if (nr % 2 != 0)
            {
                Console.WriteLine($"{nr} é impar");
            }
        }
        #endregion

        #region E
        public static void SomaInteiros()
        {
            Console.WriteLine("Introduza um nr");
            var nr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza outro nr");
            var nr2 = int.Parse(Console.ReadLine());

            if (nr1 == nr2)
            {
                Console.WriteLine((nr1 + nr2) * 3);
            }
            else
            {
                Console.WriteLine(nr1 + nr2);
            }

        }
        #endregion

        #region F
        //public static void PotenciaDeNumero()
        //{
        //    Console.WriteLine("Introduza um nr");
        //    var nr = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Introduza a potência");
        //    var pow = int.Parse(Console.ReadLine());

        //    var result = 0;

        //    for (var i = 0; i < pow; i++)
        //    {
        //        result = nr * nr;                
        //    }
        //    Console.WriteLine(result);

        //}
        #endregion
    }
}
