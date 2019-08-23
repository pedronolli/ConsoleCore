using Game.Interface;
namespace Game
{
    public class GameInit
    {
        public readonly IPlayer _jogador;

        public GameInit(IPlayer jogador)
        {
            _jogador = jogador;
        }

        public void starGame()
        {
            System.Console.WriteLine(_jogador.Run());
            System.Console.WriteLine(_jogador.Speak());
            System.Console.WriteLine(_jogador.Walk());
        }
    }
}