using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP21_task_cSharp.Rengo
{
    public class Player : ICharacters
    {
        private double _health;
        private string _name;

        //TODO: private Weapon _weapon;

        private bool _landed;
        private bool _blockedX;

        private Characters _playerType;
        //TODO: private const ScoreSystem _currentScore;

        private static const Random s_rand = new Random();
        private static const double s_max = 100.0;

        public Player(string name, OOP21_task_cSharp.Pioggia.Dimension2D dimension,
            OOP21_task_cSharp.Pioggia.SpeedVector2D vector, OOP21_task_cSharp.Baiocchi.IEnvironment environment, double mass) 
        {
            this._name = name;
            this._health = 100.0;
            //TODO: this._weapon = empty;
        }

        public Player(string name, double health, OOP21_task_cSharp.Pioggia.Dimension2D dimension,
            OOP21_task_cSharp.Pioggia.SpeedVector2D vector, OOP21_task_cSharp.Baiocchi.IEnvironment environment, double mass) 
        {
            this._name = name;
            this._health = health;
            //TODO: this._weapon = empty;
        }

        public Player(EntityList playerType, OOP21_task_cSharp.Pioggia.Dimension2D dimension,
            OOP21_task_cSharp.Pioggia.SpeedVector2D vector, OOP21_task_cSharp.Baiocchi.IEnvironment environment,
            double mass) 
        {
            this._playerType = playerType;

            SetPlayerType();
        }

        public Player(OOP21_task_cSharp.Pioggia.Dimension2D dimension,
            OOP21_task_cSharp.Pioggia.SpeedVector2D vector, OOP21_task_cSharp.Baiocchi.IEnvironment environment,
            double mass) 
        {
            SetRandomPlayer();
            SetPlayerType();
        }

        private void SetRandomPlayer()
        {
            const int max = Enum.GetNames(typeof(Characters)).Length;

            const int randomPlayer = s_rand.Next(max);
            foreach( Characters p in Enum.GetValues(typeof(Characters)))
            {
                if(randomPlayer == Enum.GetValues(p.GetType()).GetValue()) //TODO: da riguardare.
                {
                    this._playerType = p;
                }
            }
        }

        private void SetPlayerType()
        {
            double minHealth;
            switch(this._playerType){
                case Characters.PLAYER1:
                    minHealth = 80.0;
                    this._name = "Player1";
                    //TODO: Weapon
                    this._health = s_rand.Next(minHealth, s_max);
                    break;
                case Characters.PLAYER2:
                    minHealth = 65.0;
                    this._name = "Player2";
                    //TODO: Weapon
                    this._health = s_rand.Next(minHealth, s_max);
                    break;
                case Characters.PLAYER3:
                    minHealth = 50.0;
                    this._name = "Player3";
                    //TODO: Weapon
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

        //TODO: Weapon GetWeapon()

        //TODO: void SetWeapon()

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

        public Characters GetPlayerType()
        {
            return this._playerType;
        }

        //TODO: Has Weapon

        public void UpdateState()
        {
            if(!this._blockedX)
            {
                //TODO:
            } else
            {
                //TODO:
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

        //TODO: ScoreSystem

        public void BlockX()
        {
            this._blockedX = true;
        }

        public void UnblockX()
        {
            this._blockedX = false;
        }

        public bool HasBlockedX()
        {
            return this._blockedX;
        }
    }
}
