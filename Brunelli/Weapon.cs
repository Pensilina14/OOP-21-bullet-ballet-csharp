using OOP21_task_cSharp.Pioggia;

namespace OOP21_task_cSharp.Brunelli
{
    public class WeaponImpl : Weapon, OOP21_task_cSharp.Pioggia.GameEntity
    {
        private readonly static int DISTANCE_X = 15;
        private readonly static int DISTANCE_Y = 6;
        private readonly int limitBullets;
        private readonly int limitChargers;
        private readonly string name;
        private readonly bool mode;
        private int currentAmmo;
        private int indexCharger;
        private List<List<Bullet>> bandolier;
        private readonly EntityList.Weapons weaponType;

        public WeaponImpl(EntityList.Weapon weaponType, Dimension2D dimension, Enviroment gameEnv,
        double mass, SpeedVector2D vector)
        {
            base(vector, gameEnvironment, mass, dimension);

            this.weaponType = weaponType;

            this.name = weaponType.GetName();

            this.limitBullets = weaponType.getLimBullets();

		    this.limitChargers = weaponType.getLimChargers();

            this.currentAmmo = limitBullets;

            this.mode = False;

            this.indexCharger = 0;   
        }

        override
        public string Name
        {
            get { return this.name; }
        }

        override
        public bool Mode{
            get { return this.mode; }
            set { this.mode = value; }
        }

        override
        public int IndexCharger
        {
            get { return this.indexCharger; }
        }

        override
        public void Position(OOP21_task_cSharp.Pioggia.IMutablePosition2D newPos)
        {
            this.getPosition..get().setPosition(newPos.getX + DISTANCE_X, newPos.getY + DISTANCE_Y);
        }

        override
        public EntityList.Weapons TypeOfWeapon
        {
            get { return this.TypeOfWeapon; }
        }

        override
        public int LimitBullets
        {
            get { return this.limitBullets; }
        }

        override
        public int LimitChargers
        {
            get { return this.limitChargers; }
        }

        
    }
}