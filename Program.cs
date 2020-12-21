using System;
using AulaPOOL_Polimorfismo.Classes;

namespace AulaPOOL_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Mostrar();
            funcionario.Mostrar("Brenda");
            funcionario.Mostrar(2);

            Console.Beep();
        }
    }
}
