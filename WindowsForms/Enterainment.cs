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
        public Enterainment()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem q in listBox1.SelectedItems)
            {
                mood = Convert.ToInt32(q.Text);
            }
            GamePoligon gamePolygon = (GamePoligon)this.Owner;
            //gamePolygon.Mood += mood;
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
