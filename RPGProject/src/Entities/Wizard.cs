namespace RPGProject.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name) : base(name)
        {
<<<<<<< HEAD
            damageAttack = 30;
=======
<<<<<<< HEAD
            Dano = 20;
            
=======
            damageAttack = 30;
>>>>>>> 86ada8893b4e395ea7f08b6c05cc1edfd58650db
>>>>>>> e54d9b7ccc438f47478fb7bb9fc0690785483304
        }
        public override int DefineHitPoints()
        {
            return dice.Next(120);
        }
        public override string Attack()
        {
            damageAttack = damageAttack + 12;
            return $"{this.name} fez um ataque magico com {damageAttack} pts de dano";
        }

        public string Attack(int bonus)
        {
            damageAttack = damageAttack+bonus;
            return $"{this.name} fez um ataque magico com {damageAttack} pts de dano";
        }
    }
}