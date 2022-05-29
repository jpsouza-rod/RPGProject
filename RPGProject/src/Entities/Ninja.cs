namespace RPGProject.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name) : base(name)
        {
            damageAttack = 40;
        }
        public override int DefineHitPoints()
        {
            return dice.Next(150);
        }

        public override string Attack()
        {
            damageAttack = damageAttack + 10;
            return $"{this.name} fez um ataque com {damageAttack} pts de dano";
        }
        public string Attack(int shurikenAttack)
        {
            return $"{this.name} fez um ataque com shuriken de {shurikenAttack} pts de dano";
        }

    }
}