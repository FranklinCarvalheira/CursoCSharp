using System;

namespace AppOrientacaoObjetosParte1
{
    class Program
    {
        // Classes ->Objeto, Atributos, Métodos, Laço Try Catch, Método Construtor
        static void Main(string[] args)
        {
            try
            {
                //Instânciando o objeto pessoa (classe "vira" objeto)
                Pessoa p1 = new Pessoa("Franklin");
                p1.Comer("Pizza");
                p1.Andar();
                p1.Comer("Lazanha");


                
                Pessoa p2 = new Pessoa("Bárbara");
                p2.Comer("Churrasco");
                p2.Comer("Pizza");
                p2.Andar();



                Console.ReadKey();

            }catch (Exception ex)
            { Console.WriteLine("Ops, deu um erro: {0}", ex.Message); }

        }
    }
}
