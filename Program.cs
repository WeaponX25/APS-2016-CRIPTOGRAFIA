using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Criptografia_Simples_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = string.Empty;
            string Tipo;
            Console.WriteLine("Digite a senha a Ser Criptografada");

            texto = Console.ReadLine();

            Console.WriteLine(Cript(texto));

            texto = Cript(texto);

            Console.Clear();

            Console.WriteLine("Para Descriptografar a palavra {0} digite a Senha", texto);

            Tipo = Console.ReadLine();

            if (Tipo.Equals("equinox"))
            {
                Console.Clear();

                Console.WriteLine("A senha criptografada foi: ");
                Console.WriteLine(Descript(texto));
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Console.WriteLine("Desenvolvido por Leonardo Moya Fernandes");
                Console.WriteLine("Desenvolvido por Igor Abreu de Andrade");
                Console.WriteLine("Desenvolvido por Felipe Da Silva Lima");
                Console.WriteLine("Desenvolvido por Gabriel Maia Ferreira");
                Console.WriteLine("Desenvolvido por Emerson dos Santos Gonçalves");
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Console.WriteLine("Pressione o Enter Para Sair");
            }
            Console.ReadLine();
        }
        static string Cript(string valor)
        {
            string chaveCripto;
            Byte[] cript = System.Text.ASCIIEncoding.ASCII.GetBytes(valor);
            chaveCripto = Convert.ToBase64String(cript);
            return chaveCripto;


        }

        static string Descript(string valor)
        {
            string chaveCripto;
            Byte[] cript = Convert.FromBase64String(valor);
            chaveCripto = System.Text.ASCIIEncoding.ASCII.GetString(cript);
            return chaveCripto;
            
        }
    }
}
