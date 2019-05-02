using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 9 - Escopo");

            int idadeJoao = 18;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "João esta acompanhado!";
            }
            else
            {
                mensagemAdicional = "João NÃO está acompanhado";
            }

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar!");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar!");
            }

            Console.ReadLine();
        }
    }
}
