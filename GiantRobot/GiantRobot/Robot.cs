namespace GiantRobot
{
    public class Robot
    {
        public int health=100, damage=10;
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

        public bool IsAlive { get { return isAlive; } }

    }
}