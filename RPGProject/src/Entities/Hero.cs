namespace RPGProject.src.Entities
{
    public abstract class Hero
    {
        public Hero(string _name)
        {
            name = _name;
            level = 1;
            dice = new Random();
            hp = DefineHitPoints();
        }
<<<<<<< HEAD
        protected string Name;
        private int Level;
        private int HP;
        private int MP;
        protected int Dano;
=======
>>>>>>> 86ada8893b4e395ea7f08b6c05cc1edfd58650db
        protected Random dice;
        public string name { get; private set; }
        public int level { get; private set; }
        public int hp { get; private set; }
        public int damageAttack { get; protected set; }

        public abstract int DefineHitPoints();
        public abstract string Attack();
            
        public override string ToString()
        {
            return $"Name : {name} | {level}\nHP : {hp}";
        }  
    }
}