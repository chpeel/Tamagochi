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
        int[] qwe = new int[] { 10, 5, 15, 25, 10, 12, 5, 20, 40 };

        public Enterainment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int g;
            foreach (ListViewItem q in listView1.SelectedItems)
            {
                g = q.ImageIndex;
                for(int i = 0; i < qwe.Length; i++)
                {
                    if (i == g)
                    {
                        mood = qwe[i];
                        break;
                    }
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
                gamePolygon.progressBarMood.Value = 100;
            }
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Enterainment_Load(object sender, EventArgs e)
        {

        }
    }
}
