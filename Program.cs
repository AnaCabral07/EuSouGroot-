// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

const string ParaSairDigite = "tchau groot";

Console.WriteLine("        Chat do Groot");

string pergunta;

do 
{
    Console.WriteLine("Faça uma pergunta para o Groot.");
        Console.Write("Ou se quiser sair digite: tchau groot.");
            Console.WriteLine();
     pergunta = Console.ReadLine()!;
 
 string resposta = GrootResponde(pergunta);

            ExibeResposta(GrootResponde(pergunta));
}while (pergunta.Trim().ToLower() != ParaSairDigite);

    void ExibeResposta(string resposta)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"Resposta: {resposta}");
    Console.ResetColor();
}

 string GrootResponde( string pergunta)

{
    return pergunta.Trim().ToLower() == ParaSairDigite ?
       "Eu sou Groot!":
       "Eu sou Groot!";
}
