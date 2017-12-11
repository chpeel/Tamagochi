using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamagotchi
{
    public partial class Enterainment : Form
    {
        int mood;
        int[] addMood = new int[] { 10, 5, 10 };

        public Enterainment()
        {
            InitializeComponent();
        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int g = listBox1.SelectedIndex;
            for (int i = 0; i < addMood.Length; i++)
            {
                if (g == i)
                {
                    mood = addMood[i];
                    break;
                }
            }
            GamePoligon gamePolygon = (GamePoligon)this.Owner;
            try
            {
                gamePolygon.Mood += mood;
                gamePolygon.labelMood.Text = gamePolygon.progressBarMood.Value.ToString() + "%";
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Ваш мишка не хочет веселиться!", "Сообщение");
            }
            this.Close();
        }
    }
}
