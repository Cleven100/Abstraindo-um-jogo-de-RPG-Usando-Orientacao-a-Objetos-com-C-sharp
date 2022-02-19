namespace Abstraindo_um_jogo_de_RPG_Usando_Orientacao_a_Objetos_com_C_sharp.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Hero(){

        }
       
        public string Name;

        public int Level;

        public string HeroType;


        public override string ToString(){
          return this.Name + " " + this.Level + " " + this.HeroType;
        }



        public virtual string Attack(){
            return this.Name + " Atacou com a espada";
        }
    }
}