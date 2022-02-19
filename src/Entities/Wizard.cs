namespace Abstraindo_um_jogo_de_RPG_Usando_Orientacao_a_Objetos_com_C_sharp.src.Entities
{
    public class Wizard : Hero
    {
       
       public Wizard(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " Atacou com a magia ";
        }

        public string Attack(int Bonus){
            return this.Name + " Lançou Magia com Bonus de Ataque: " + Bonus;
        }

    }
}