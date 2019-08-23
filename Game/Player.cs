using Game.Interface;
namespace Game
{
    public class Player : IPlayer
    {
        public readonly string _Nome;

        public Player(string nome)
        {
            _Nome = nome;
        }
        public string Run()
        {
            return $"{_Nome} está correndo \n";
        }

        public string Speak()
        {
            return $"{_Nome} está falando \n";
        }

        public string Walk()
        {
            return $"{_Nome} está caminhando \n";
        }
    }
}