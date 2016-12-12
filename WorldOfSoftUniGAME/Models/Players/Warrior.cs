namespace WorldOfSoftuniRPG.Models.Players
{
    internal class Warrior : HeroDto
    {
        private const int StartAttack = 90; 
        private const int StartDefence = 150; 
        private const int StartHealth = 100; 

        public Warrior()
            : base(StartAttack, StartDefence, StartHealth)
        {   
        }
    }
}