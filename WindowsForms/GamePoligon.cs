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
using System.IO;
using System.Text.RegularExpressions;

namespace Tamagotchi
{
    public partial class GamePoligon : Form
    {

        CreateTam createTam = new CreateTam();
        Bear bear;
        int price;
        bool flag = true;

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
            bear = new Bear("", "", 100, 100, 100, 100, 100, 100, 100);
            InitializeComponent();
            timer.Interval = 10000;
            timer.Enabled = true;
            timer.Tick += timerHealth_Tick;
            label1.Text = $"Количество листиков: {Convert.ToString(bear.Money)}";
        }
        public GamePoligon(string fileName)
        {
            StreamReader f = new StreamReader(fileName);
            String strpat = @"[\s]";
            Regex re = new Regex(strpat);
            String[] element = re.Split(f.ReadToEnd());
            f.Close();
            bear = new Bear(element[0], element[1], Convert.ToInt32(element[2]), Convert.ToInt32(element[3]), Convert.ToInt32(element[4]), Convert.ToInt32(element[5]), Convert.ToInt32(element[6]), Convert.ToInt32(element[7]), Convert.ToInt32(element[8]));
            SetTypeBear(element[1]);
            SetNameBear(element[0]);
            InitializeComponent();
            progressBarHealth.Value = Convert.ToInt32(element[3]);
            progressBarHygiene.Value = Convert.ToInt32(element[4]);
            progressBarSleeping.Value = Convert.ToInt32(element[5]);
            progressBarSatiety.Value = Convert.ToInt32(element[6]);
            progressBarMood.Value = Convert.ToInt32(element[7]);
            progressBarNuturalNeed.Value = Convert.ToInt32(element[8]);
            labelMood.Text = progressBarMood.Value.ToString() + "%";
            labelHealth.Text = progressBarHealth.Value.ToString() + "%";
            labelSatiety.Text = progressBarSatiety.Value.ToString() + "%";
            labelNutural_Need.Text = progressBarNuturalNeed.Value.ToString() + "%";
            labelSleeping.Text = progressBarSleeping.Value.ToString() + "%";
            labelHygiene.Text = progressBarHygiene.Value.ToString() + "%";
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

        public int Money(int money)
        {
            return bear.Money += money;
        }

        private void GamePoligon_Load(object sender, EventArgs e)
        {
            if (bear.Type == "White")
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
            if (progressBarHygiene.Value == 0 || progressBarNuturalNeed.Value == 0 || progressBarSatiety.Value == 0 || progressBarSleeping.Value==0 || (progressBarMood.Value==0 && flag))
            {
                try
                {
                    progressBarHealth.Value = progressBarHealth.Value - 20;
                }
                catch (ArgumentOutOfRangeException)
                {
                    timer.Enabled = false;
                    progressBarHealth.Value = 0;
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
            if(progressBarHealth.Value == 50)
            {
                button8.Visible = true;
            }
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
                progressBarSleeping.Value = 100;
                labelSleeping.Text = progressBarSleeping.Value.ToString() + "%";
        }
        

        private void button6_Click_1(object sender, EventArgs e)
        {
                progressBarNuturalNeed.Value = 100;
                labelNutural_Need.Text = progressBarNuturalNeed.Value.ToString() + "%";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Enterainment enterainment = new Enterainment();
            enterainment.Owner = this;
            enterainment.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
                progressBarHygiene.Value = 100;
                labelHygiene.Text = progressBarHygiene.Value.ToString() + "%";
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

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter f = new StreamWriter("savefile.txt");
            f.Write("{0} {1} {2} {3} {4} {5} {6} {7} {8}", bear.Name, bear.Type, bear.Money, progressBarHealth.Value, progressBarHygiene.Value, progressBarSleeping.Value, progressBarSatiety.Value, progressBarMood.Value, progressBarNuturalNeed.Value);
            f.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                progressBarMood.Value -= 10;
                label1.Text = $"Количество листиков: {Convert.ToString(Money(10))}";
                labelMood.Text = progressBarMood.Value.ToString() + "%";
                if (progressBarMood.Value == 0 && flag)
                {
                    progressBarHealth.Value -= 20;
                    flag = false;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Ваш мишка не в настроении работать!", "Сообщение");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
