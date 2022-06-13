using System;

namespace BuiltInDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'F';
            // \u : Informa que será um código unicode
            char letra = '\u0046'; // código unicode de caracteres | Chars são representados por aspas simples
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L; // Quando trabalhamos com long, é recomendado colocar o L no final para deixar explícito o tipo long.
            double n5 = 4.5; // Double é com ponto (por padrão do C# será exibido com vírgula na minha tela pois ele segue o padrão de pontuação da máquina)
            float n6 = 4.5f; // Float devemos colocar o f no final para informar explicitamente que se trata de um float
            string nome = "Max William Santos de Jesus"; // Strings são representadas por aspas duplas
            nome = "Andressa  Gomes"; // Isso pode acontecer pois estamos atribuindo um novo valor a string e não modificando-a (em sua essência)
            object obj1 = "Maxuel Alves"; // É um tipo genêrico

            ///////////////////////////////////////////////////////
            ///// Funções para valores mínimos e máximos /////
            int n7 = int.MinValue;
            int n8 = int.MaxValue;


        }
    }
}
