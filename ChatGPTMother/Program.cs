using System;

namespace ChatGPTMother
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis auxiliares
            string question, response;

            while (true)
            {
                // Colocar questão ao utilizador
                Console.Write("Place your question? ");
                question = Console.ReadLine();

                // Input para sair
                if (question == "EXIT")
                {
                    break;
                }
                else
                {
                // Verificar se se trata de uma questão conhecida e determinar uma
                // resposta adequada
                response = question switch
                    {
                        "How are you?" => "I'm fine, thank you",

                        "What's your name?" => "Gran'pa",

                        "What's your mission?" => "Destroy mankind!",

                        "What is the meaning of life?" =>"42",

                        _ => "You got me, I'm not THAT smart!",

                    };

                    // Responder adequadamente
                    Console.WriteLine(response);
                }
            }
        }
    }
}
