using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class JogadorNoob : IJogador
    {
        public string Chutar()
        {
            return "Maradona esta pateando";
        }

        public string Correr()
        {
            return "Maradona estas corriendo";
        }

        public string Passar()
        {
            return "Maradona esta passando a pelota";
        }
    }
}