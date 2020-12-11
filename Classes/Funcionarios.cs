using System;

namespace AulaPOO_PolimosrfismoSobrecarga.Classes
{
    public class Funcionarios
    {
        public string[] lista = {"Andre", "Ana", "Antonio", "Brenda"};
        public void Mostrar(int indice){
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(lista[indice]);
            Console.ResetColor();
        }
        public void Mostrar(string busca){
            foreach(var item in lista){
                Console.ForegroundColor = ConsoleColor.Yellow;

                if(item == busca){
                    Console.WriteLine("Item encontrado : " + item);
                }
                Console.ResetColor();
            }
            
        }
        
    
    }
}