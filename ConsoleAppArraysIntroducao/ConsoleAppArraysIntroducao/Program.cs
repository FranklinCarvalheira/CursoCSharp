// See https://aka.ms/new-console-template for more information

string[] semana = new string[7] { "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado", "Domingo"};

// SEM ITERAÇÃO
Console.WriteLine("O dia da semana é: " + semana[3]);

// ITERAÇÃO, COM ESTRUTURA DE REPETIÇÃO
for (int i = 0; i < semana.Length; i++)
{
    Console.WriteLine("O dia da semana é: " + semana[i]);
}

// ITERAÇÃO COM FOR EACH
foreach(string dia in semana)
{
    Console.WriteLine("O dia da semana é: " + dia);
}

// Verificar se esta dentro do array
Console.WriteLine("A posição de quarta é: " + Array.IndexOf(semana, "Quarta"));


Console.ReadKey();
