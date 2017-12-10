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
    public partial class Shop : Form
    {
        int price;
        int index;
        public Shop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem q in listView1.SelectedItems)
            {
                price = Convert.ToInt32(q.Text);
                index = q.ImageIndex;
            }
            GamePoligon gamePoligon = new GamePoligon();
            gamePoligon.Price = price;
            gamePoligon.Satiety = gamePoligon.Satiety+ 5;
            this.Close();
        }
        
    }
}
