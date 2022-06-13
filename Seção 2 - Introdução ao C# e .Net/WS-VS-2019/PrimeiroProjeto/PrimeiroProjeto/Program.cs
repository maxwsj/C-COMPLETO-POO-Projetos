using System; // Aponta (Referencia) para um namespace chamado System, sendo um namespace padrão do .Net. Contém funções básicas de manipulação de programa

// Por padrão o VS declara nosso namespace com o mesmo nome do Projeto. (Podemos colocar o nome que quisermos)
namespace PrimeiroProjeto // Declaração de namespace do nosso arquivo.
// Nosso programa também pode ser parte de um namespace
{
    class Program // Por convenção, colocamos o nome da classe com o mesmo nome do arquivo (Porém não é obrigatório)
    {
        // Dentro da classe podemos ter membros da classe
        static void Main(string[] args) // Identificação padrão para identificar o entry point (onde a execução começa)
        {
            Console.WriteLine("Hello World!");
        }
    }
}