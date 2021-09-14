using System;

namespace VerificadorDeEntradas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Esta aplicação visa ler e validar as seguintes informações no seguinte escopo:

            Nome: maior que 2 caracteres;    
            Idade: entre 0 e 150;
            Sexo: 'f' ou 'm';

*/


            bool erro;                   //Erro: "booleia" o status da falha;
            string imput;                //Imput: recebe os dados do console;
            string nome = String.Empty;
            int idade = 0;
            string sexo;


            Console.WriteLine("Este programa lê e valida a inclusão de informações!\n");



            #region nome;

            do
            {
                Console.Write("Digite seu nome completo: ");
                imput = Console.ReadLine();
                erro = false;

                foreach (char c in imput)
                {
                    if (Char.IsLetter(c))
                    {
                        nome += c;
                    }
                    else if (nome.Length > 2 && Char.IsSeparator(c))
                    {
                        nome += c;
                    }
                    else if (String.IsNullOrEmpty(nome))
                    {
                        erro = true;
                    }
                    else
                    {
                        erro = true;
                    }

                }
                if (erro == true || String.IsNullOrEmpty(nome) || nome.Length < 2)
                {
                    Console.WriteLine($"\nNome aceita apenas letras e espaços entre palavras! \n");
                    imput = null;
                    nome = String.Empty;
                }

            } while (nome.Length < 2 || erro == true);

            Console.WriteLine($"{nome}");
            Console.ReadLine();

            #endregion




            #region idade;

            do
            {
                Console.Write("Digite idade: ");
                imput = Console.ReadLine();
                erro = false;

                foreach (char c in imput)
                {
                    if (Char.IsDigit(c))
                    {
                        idade += c;
                    }
                    else if (String.IsNullOrEmpty(imput))
                    {
                        erro = true;
                    }
                    else
                    {
                        erro = true;
                    }

                }
                if (erro == true || String.IsNullOrEmpty(imput) || imput.Length > 3)
                {
                    Console.WriteLine($"\nIdade aceita apenas valores de 0 à 150! \n");
                    imput = null;
                }
                else if (imput.Length >= 0 && imput.Length <= 3)
                {
                    idade = int.Parse(imput);
                    if (idade >= 0 && idade <= 150)
                    {
                        Console.WriteLine($"{idade}");
                        Console.ReadLine();
                    }
                    else
                    {
                        erro = true;
                    }
                }
            } while (erro == true || String.IsNullOrEmpty(imput));

            #endregion





            #region sexo 

            do
            {
                Console.Write("Selecione f para feminino ou m para masculino! ");
                sexo = Console.ReadLine();
                erro = false;

                if (sexo.Length != 1)
                {
                    erro = true;
                }
                else if (sexo.Equals("f") || sexo.Equals("m"))
                {
                    sexo = sexo;
                }
                else
                {
                    erro = true;
                }
            } while (erro == true);

            #endregion
        }
    }
}


