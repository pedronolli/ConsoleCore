
namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new GameInit(new Player("Pedro"));
            jogo.starGame();
        }
    }
}
