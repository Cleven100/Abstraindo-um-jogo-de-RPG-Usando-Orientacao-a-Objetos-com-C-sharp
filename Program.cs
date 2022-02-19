using System;
using Abstraindo_um_jogo_de_RPG_Usando_Orientacao_a_Objetos_com_C_sharp.src.Entities;


namespace Abstraindo_um_jogo_de_RPG_Usando_Orientacao_a_Objetos_com_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 10, "Cavaleiro");
            Wizard wizard = new Wizard("Jennica", 25, "White Wizard");
            Ninja wedge = new Ninja ("Wedge", 50, "Ninja");
            BlackWizard topappa = new BlackWizard("topappa", 40,  "Black Wizard");
          
           Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(2));
            Console.WriteLine(wizard.Attack(15));
            Console.WriteLine(wedge.Attack("Dia", 100));
            Console.WriteLine(wedge.Attack("Noite", 500));
            Console.WriteLine(topappa.Attack("dia", 50));
            Console.WriteLine(topappa.Attack("Noite", 500));

            Console.WriteLine(wizard.Attack(15));

        }
    }
}
