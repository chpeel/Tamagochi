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
    public partial class Medicine : Form
    {
        int health;
        int[] qwe = new int[] {10,10,15,100,10 };
        public Medicine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int g;
            foreach (ListViewItem q in listView1.SelectedItems)
            {
                g = q.Index;
                for (int i = 0; i < qwe.Length; i++)
                {
                    if (i == g)
                    {
                        health = qwe[i];
                        break;
                    }
                }
            }
            GamePoligon gamePolygon = (GamePoligon)this.Owner;
            try
            {
                gamePolygon.Health += health;
                gamePolygon.labelHealth.Text = gamePolygon.progressBarHealth.Value.ToString() + "%";
            }
            catch (System.ArgumentOutOfRangeException)
            {
                gamePolygon.progressBarMood.Value = 100;
            }
            this.Close();
        }
    }
}
