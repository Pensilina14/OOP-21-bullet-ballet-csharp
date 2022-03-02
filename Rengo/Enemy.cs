using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP21_task_cSharp.Rengo
{
    class Enemy : ICharacters
    {
        private double _health;
        private string _name;

        // Optional<Weapon> _weapon;

        private Characters _enemyType;

        private static const Random s_rand = Random();
        private static const double s_max = 100.0;
        private bool _landed;

        private static const double s_max_range = 7.0;

        private const double enemyRange = getRandomRange();

        public Enemy(string name, double health, OOP21_task_cSharp.Pioggia.Dimension2D dimension, 
            OOP21_task_cSharp.Pioggia.SpeedVector2D vector, OOP21_task_cSharp.Baiocchi.IEnvironment environment, double mass)
        {

            //super(vector, environment, mass, dimension);

            this._name = name;
            this._health = health;

        }

        public Enemy(EntityList enemyType, OOP21_task_cSharp.Pioggia.Dimension2D dimension,
            OOP21_task_cSharp.Pioggia.SpeedVector2D vector, OOP21_task_cSharp.Baiocchi.IEnvironment environment, 
            double mass)
        {
            //super(vector, environment, mass, dimension);
            this._enemyType = enemyType;
            setEnemyType();
        }

        public Enemy(OOP21_task_cSharp.Pioggia.Dimension2D dimension,
            OOP21_task_cSharp.Pioggia.SpeedVector2D vector, OOP21_task_cSharp.Baiocchi.IEnvironment environment, double mass)
        {
            //super(vector, environment, mass, dimension);

            setRandomEnemy();
            setEnemyType();
        }

        private void SetRandomEnemy()
        {
            const int max = Enum.GetNames(typeof(Characters)).Length;

            const int randomPlayer = s_rand.Next(max);
            foreach (Characters e in Enum.GetValues(typeof(Characters)))
            {
                if (randomPlayer == Enum.GetValues(e.GetType()).GetValue()) //TODO: da riguardare.
                {
                    this._enemyType = e;
                }
            }
        }

        private void SetEnemyType()
        {
            double minHealth;
            switch (this._enemyType)
            {
                case Characters.ENEMY1:
                    minHealth = 80.0;
                    this._name = "Enemy1";
                    this._health = s_rand.Next(minHealth, s_max);
                    break;
                case Characters.ENEMY2:
                    minHealth = 65.0;
                    this._name = "Enemy2";
                    this._health = s_rand.Next(minHealth, s_max);
                    break;
                case Characters.ENEMY3:
                    minHealth = 50.0;
                    this._name = "Enemy3";
                    this._health = s_rand.Next(minHealth, s_max);
                    break;
                default:
                    break;
            }
        }

        public double GetHealth()
        {
            return this._health;
        }

        public bool IsAlive()
        {
            return this._health > 0.0;
        }

        public void SetHealth(double setHealth)
        {
            this._health = setHealth;
        }

        /*public Optional<Weapon> GetWeapon() //TODO: uncomment when Weapon will be added.
        {
            return this._weapon;
        }*/

        /*public void SetWeapon(Weapon weapon)
        {
            this._weapon = Optional.of(weapon);
        }*/

        public string GetName()
        {
            return this._name;
        }

        public void IncreaseHealth(double increaseHealth)
        {
            this._health += increaseHealth;
        }

        public void DecreaseHealth(double decreaseHealth)
        {
            this._health -= decreaseHealth;
        }

        public Characters GetEnemyType()
        {
            return this._enemyType;
        }

        public void updateState()
        {
            //super.updateState();
            if (!this.IsAlive())
            {
                //this.GetGameEnvironment().get()
                //.deleteObjByPosition(new ImmutablePosition2Dimpl(this.getPosition().get())); //TODO: uncomment
            }
        }

        public bool HasLanded()
        {
            return this._landed;
        }

        public void Land()
        {
            this._landed = true;
        }

        public void ResetLanding()
        {
            this._landed = false;
        }

        private double GetRandomRange()
        {
            return s_rand.NextDouble() * s_max_range;
        }

        // forse passare l'index dell'enemy come parametro non serve.
        public bool IsPlayerInRange(int enemyIndex)
        {
            double xPlayer = this.getGameEnvironment().get().getEntityManager().getPlayer().get().getPosition().get().getX();
            double yPlayer = this.getGameEnvironment().get().getEntityManager().getPlayer().get().getPosition().get().getX();

            double xEnemy = this.getGameEnvironment().get().getEntityManager().getEnemies().get().get(enemyIndex).getPosition().get().getX();
            double yEnemy = this.getGameEnvironment().get().getEntityManager().getEnemies().get().get(enemyIndex).getPosition().get().getY();

            double distance = Math.sqrt((xPlayer - xEnemy) + (yPlayer - yEnemy));

            return distance <= this._enemyRange;
        }

        public double GetRange()
        {
            return this._enemyRange;
        }

        public double GetMaxRange()
        {
            return s_max_range;
        }
    }
}
