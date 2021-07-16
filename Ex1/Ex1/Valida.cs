using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Valida
    {
        public static string ValidaString()
        {

            string value = string.Empty;
            value = Console.ReadLine().Trim();
            while (String.IsNullOrEmpty(value))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("valor invalido");
                Console.ResetColor();
                value = Console.ReadLine().Trim();
            }
            return value;
        }

        public static decimal LeituraDecimal()
        {
            do
            {
                decimal retorno = -1;
                try
                {
                    retorno = Convert.ToDecimal(Console.ReadLine().ToString().Replace(',','.'));
                    if (retorno > 0)
                    {
                        return retorno;
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dado invalido");
                    Console.ResetColor();
                }

            } while (true);
        }
        public static int LeituraNumero()
        {
            int retorno = -1;
            try
            {
                retorno = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Dado invalido, insira novamente");
                Console.ResetColor();
            }
            return retorno;
        }
        public static string validaSN()
        {
            //Console.WriteLine("Deseja cadastrar mais 1?(y/n)");

            do
            {
                string resposta = Console.ReadLine().Trim().ToLower();
                if (resposta.Equals("s") || resposta.Equals("n"))
                {
                    return resposta;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dado Invalido! Digite [S/N]!!!");
                    Console.ResetColor();
                }
            } while (true);

        }
    }
}