using System;

namespace AulaPOOL_Polimorfismo.Classes
{
    public class Funcionario
    {
        private int myVar;

        public int MyPropety
        {
            get{return myVar;}
            set {myVar = value;}
        }

        public string Name{get;set;}

        //Atividade

        private string[] lista = {"Gabriel", "Noah", "João", "Maicon"};
        public void Mostrar(){
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        public void Mostrar(int indice){
                Console.WriteLine("Busca por indice: " +  lista[indice]);
        }

        public void Mostrar(string busca){
            foreach (var item in lista)
            {
                if(item == busca){
                    Console.WriteLine($"Nome encontrado: " + item);
                }
            }
        }
    }
}