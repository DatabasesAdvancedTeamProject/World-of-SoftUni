namespace WorldOfSoftuniRPG.Models.Players
{
    internal class Mage : HeroDto
    {
        private const int Attack = 150;
        private const int Defence = 90;
        private const int Health = 100;

        public Mage()
            : base(Attack, Defence, Health)
        {   
        }
    }
}