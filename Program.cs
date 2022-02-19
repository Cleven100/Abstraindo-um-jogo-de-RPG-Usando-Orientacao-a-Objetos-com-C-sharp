using System;
using Abstraindo_um_jogo_de_RPG_Usando_Orientacao_a_Objetos_com_C_sharp.src.Entities;


namespace Abstraindo_um_jogo_de_RPG_Usando_Orientacao_a_Objetos_com_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", 10, "Cavaleiro");
            Wizard wizard = new Wizard("Jennica", 25, "White Wizard");
          
           Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack());

        }
    }
}
