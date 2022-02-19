using System;
using Abstraindo_um_jogo_de_RPG_Usando_Orientacao_a_Objetos_com_C_sharp.src.Entities;


namespace Abstraindo_um_jogo_de_RPG_Usando_Orientacao_a_Objetos_com_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Arus hero = new Arus("Arus", 10, "Cavaleiro");
          
           Console.Write(hero.ToString());

        }
    }
}
