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
        private int hygiene = 100;//гигиена
        private int satiety = 100;//сытость
        private int health = 100;//здоровье
        private int sleeping = 100;//сон
        private int natural_need = 100;//ествественные нужды
        private int mood = 100;//настроение
        //private int level;//уровень
        private int money = 100;
        private String[] desires = new String[] { "Хочу пить", "Хочу чего-нибудь сладенького", "Съесть бы чего-нибудь" };//желания

        public Bear(string name, int health, int sleeping, int satiety, int hygiene, int nutural_need,int mood,int money)
        {
            this.health = health;
            this.hygiene = hygiene;
            this.money = money;
            this.name = name;
            this.natural_need = natural_need;
            this.satiety = satiety;
            this.mood = mood;
        }

        public Bear(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        public Bear()
        {
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
