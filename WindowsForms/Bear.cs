using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class Bear
    {
        string name;
        string type;
        private int hygiene;//гигиена
        private int satiety;//сытость
        private int health;//здоровье
        private int sleeping;//сон
        private int natural_need;//ествественные нужды
        private int mood;//настроение
        //private int level;//уровень
        private int money;
        private String[] desires = new String[] { "Хочу пить", "Хочу чего-нибудь сладенького", "Съесть бы чего-нибудь" };//желания


        public Bear(string name, string type, int money, int health, int hygiene, int sleep, int satiety, int mood, int natural_need)
        {
            this.name = name;
            this.type = type;
            this.money = money;
            this.health = health;
            this.hygiene = hygiene;
            this.sleeping = sleep;
            this.satiety = satiety;
            this.mood = mood;
            this.natural_need = natural_need;
        }
        public Bear()
        {
            money = 100;
            health = 100;
            hygiene = 100;
            sleeping = 100;
            satiety = 100;
            mood = 100;
            natural_need = 100;
            }
        

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Natural_need
        {
            get { return natural_need; }
            set { natural_need = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public String[] Desires
        {
            get { return desires; }
            set { desires = value; }
        }

        public int Mood
        {
            get { return mood; }
            set { mood = value; }
        }

        public int Hygiene
        {
            get { return hygiene; }
            set { hygiene = value; }
        }

        public int Satiety
        {
            get { return satiety; }
            set { satiety = value; }
        }

        public int Sleeping
        {
            get { return sleeping; }
            set { sleeping = value; }
        }

        public int Money
        {
            get { return money; }
            set { money = value; }
        } 
    }
}
