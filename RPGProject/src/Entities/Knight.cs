namespace RPGProject.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name) : base(name)
        {
            damageAttack = 20;
        }
        public override int DefineHitPoints()
        {
            return dice.Next(200);
        }
        public override string Attack()
        {
            damageAttack = damageAttack + 8;
            return $"{this.name} fez um ataque com {damageAttack} pts de Dano";
        }
        public string Attack(int bonus)
        {
            damageAttack += bonus;
            return $"{this.name} fez um ataque com bonus de {damageAttack} pts";
        }

    }
}