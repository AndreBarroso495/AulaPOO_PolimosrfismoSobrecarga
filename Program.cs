using System;
using AulaPOO_PolimosrfismoSobrecarga.Classes;

namespace AulaPOO_PolimosrfismoSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando a classe funcionario
            Funcionarios fun = new Funcionarios();
            fun.Mostrar(3);

            Console.Beep();
        }
    }
}
