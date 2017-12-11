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

        public int Mood
        {
            set { progressBarMood.Value = value; }
            get { return progressBarMood.Value; }
        }

        public GamePoligon()
        {
            InitializeComponent();
            timer.Interval = 10000;
            timer.Enabled = true;
            timer.Tick += timerHealth_Tick;
            label1.Text = $"Количество листиков: {Convert.ToString(bear.Money)}";
            
        }

        private void pictureBoxTam_Click(object sender, EventArgs e)
        {

        }

        public void SetNameBear(string name)
        {
            bear.Name = name;
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
            label8.Text = bear.Name;
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
                try
                {
                    progressBarHealth.Value = progressBarHealth.Value - 20;
                }
                catch (ArgumentOutOfRangeException)
                {
                    timer.Enabled = false;
                    MessageBox.Show("Ваш мишка умер!", "Сообщение");
                    this.Close();
                }
            }
            labelMood.Text = progressBarMood.Value.ToString() + "%";
            labelHealth.Text = progressBarHealth.Value.ToString() + "%";
            labelSatiety.Text = progressBarSatiety.Value.ToString() + "%";
            labelNutural_Need.Text = progressBarNuturalNeed.Value.ToString() + "%";
            labelSleeping.Text = progressBarSleeping.Value.ToString() + "%";
            labelHygiene.Text = progressBarHygiene.Value.ToString() + "%";
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        
        private void pictureBoxGrizz_Click(object sender, EventArgs e)
        {

        }

        private void progressBarSatiety_Click(object sender, EventArgs e)
        {
            
        }

        private void labelSatiety_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (progressBarSleeping.Value < 50)
            {
                progressBarSleeping.Value = 100;
                groupBox1.Visible = false;
                progressBarSleep.Visible = true;
                progressBarSleep.Location = new Point(230, 340);
                this.BackgroundImage = Image.FromFile(@"..\..\..\sleep.jpg");
                timer1.Interval = 100;
                timer1.Enabled = true;
                timer1.Tick += timer1_Tick;
            }
            else MessageBox.Show("Ваш мишка не хочет спать!", "Сообщение");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBarSleep.PerformStep();
            if (progressBarSleep.Value == 100)
            {
                timer1.Enabled = false;
                progressBarSleep.Value = 0;
                groupBox1.Visible = true;
                progressBarSleep.Visible = false;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (progressBarNuturalNeed.Value < 50)
                progressBarNuturalNeed.Value = 100;
            else MessageBox.Show("Ваш мишка не хочет в туалет!", "Сообщение");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Enterainment enterainment = new Enterainment();
            enterainment.Owner = this;
            enterainment.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (progressBarHygiene.Value < 50)
                progressBarHygiene.Value = 100;
            else MessageBox.Show("Ваш мишка не хочет умываться!", "Сообщение");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Shop shop = new Shop();
            shop.Owner = this;
            shop.Show();
        }

        private void progressBarSleeping_Click(object sender, EventArgs e)
        {

        }
    }
}
