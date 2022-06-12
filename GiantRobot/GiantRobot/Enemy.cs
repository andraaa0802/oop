namespace GiantRobot
{
    public class Enemy
    {
        public int health, damage;
        public string name;
        public bool isAlive = true;

        public int Health 
        {
            get
            { 
                return health; 
            }
            set
            {
                health = value;
                if (health <= 0)
                    isAlive = false;
            }
        }

        public int Damage { get { return damage; } }

        public string Name { get { return name; } }

        public bool IsAlive { get { return isAlive; }}


        public Enemy(string name, int health, int damage)
        {
            this.name = name;
            this.health = health;
            this.damage = damage;
        }
    }
}