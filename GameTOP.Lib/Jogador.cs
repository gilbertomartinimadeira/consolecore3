using GameTOP.Interface;

namespace GameTOP.Lib
{
    public partial class Jogador : IJogador
    {
        public string Nome{ get; set; }    
        //Chuta
        public Jogador(string nome)
        {
            Nome = nome;
        }
        public string Chutar() => $"{Nome} está a chutar";           
        public string Correr() => $"{Nome} está a correr";            
        public string Passar() => $"{Nome} está a passar";
        

    }
}