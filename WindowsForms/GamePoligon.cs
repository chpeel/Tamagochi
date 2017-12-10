using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Resources;

namespace Tamagotchi
{
    public partial class GamePoligon : Form
    {

        CreateTam createTam = new CreateTam();
        Bear bear = new Bear();
        int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Satiety
        {
            set { progressBarSatiety.Value = value; }
            get { return progressBarSatiety.Value; }
        }

        public int Mood
        {
            set { progressBarMood.Value = value; }
            get { return progressBarMood.Value; }
        }

        public GamePoligon()
        {
            InitializeComponent();
            timer.Interval = 6000;
            timer.Enabled = true;
            timer.Tick += timerHealth_Tick;
            labelMood.Text = progressBarMood.Value.ToString() + "%";
            label1.Text = $"Количество листиков: {Convert.ToString(bear.Money-Price)}";
        }

        private void pictureBoxTam_Click(object sender, EventArgs e)
        {

        }

        public void SetTypeBear(string tp)
        {
            bear.Type = tp;
        }

        private void GamePoligon_Load(object sender, EventArgs e)
        {
            if (bear.Type == "While")
            {
                pictureBoxWhile.Visible = true;
            }
            else if (bear.Type == "Grizz")
            {
                pictureBoxGrizz.Visible = true;
            }
            else
            {
                pictureBoxPanda.Visible = true;
            }
            createTam.Close();
        }

        private void progressBarHealth_Click(object sender, EventArgs e)
        {

        }

        private void timerHealth_Tick(object sender, EventArgs e)
        {
            progressBarHygiene.PerformStep();
            progressBarMood.PerformStep();
            progressBarNuturalNeed.PerformStep();
            progressBarSatiety.PerformStep();
            progressBarSleeping.PerformStep();
            if (progressBarHealth.Value == 0 || progressBarHygiene.Value == 0 || progressBarNuturalNeed.Value == 0 || progressBarSatiety.Value == 0 || progressBarMood.Value == 0)
            {
                progressBarHealth.Value = progressBarHealth.Value - 20;
            }
            if (progressBarHealth.Value == 0) MessageBox.Show("Ваш мишка умер!", "Сообщение");
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop();
            shop.Owner = this;
            shop.Show();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxGrizz_Click(object sender, EventArgs e)
        {

        }

        private void progressBarSatiety_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(progressBarHygiene.Value<50)
                progressBarHygiene.Value = 100;
            else MessageBox.Show("Ваш мишка не хочет умываться!", "Сообщение");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Enterainment entertainment = new Enterainment();
            entertainment.Owner = this;
            entertainment.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(progressBarNuturalNeed.Value<50)
                progressBarNuturalNeed.Value = 100;
            else MessageBox.Show("Ваш мишка не хочет гадить!", "Сообщение");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(progressBarSleeping.Value<50)
                progressBarSleeping.Value = 100;
            else MessageBox.Show("Ваш мишка не хочет спать!", "Сообщение");

        }
    }
}
