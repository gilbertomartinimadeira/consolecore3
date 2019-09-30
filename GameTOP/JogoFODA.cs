using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly IJogador _jogadorA;
        private readonly IJogador _jogadorB;
    
        public JogoFODA(IJogador jogadorA, IJogador jogadorB) {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }

        public void IniciarJogo()
        {            
            System.Console.WriteLine(_jogadorA.Correr());
            System.Console.WriteLine(_jogadorA.Chutar());
            System.Console.WriteLine(_jogadorA.Passar());                    

            System.Console.WriteLine(_jogadorB.Chutar());
            System.Console.WriteLine(_jogadorB.Chutar());
            System.Console.WriteLine(_jogadorB.Correr());
        }
    }

   
}