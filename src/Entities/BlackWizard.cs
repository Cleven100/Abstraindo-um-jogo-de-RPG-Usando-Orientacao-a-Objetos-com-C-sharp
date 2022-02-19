namespace Abstraindo_um_jogo_de_RPG_Usando_Orientacao_a_Objetos_com_C_sharp.src.Entities
{
    public class BlackWizard : Hero
    {
         public BlackWizard(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " Atacou com a magia ";
        }


         public string Attack(string Tipo, int Bonus){
            if(Tipo == "Noite"){
                return this.Name + " Ataque de magia negra " + Bonus;
            }else {
                 return this.Name + " Ataque reduzido ";
            }
        }
    }
}