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
        Bear bear = new Bear();

        public Shop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem q in listView1.SelectedItems)
            {
                price = Convert.ToInt32(q.Text);
            }
            GamePoligon gamePolygon = (GamePoligon)this.Owner;
            try
            {
                gamePolygon.progressBarSatiety.Value += price;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                gamePolygon.progressBarSatiety.Value = 100;
            }

            gamePolygon.label1.Text = $"Количество листиков: {Convert.ToString(gamePolygon.Money(-price))}";
            gamePolygon.labelSatiety.Text = gamePolygon.progressBarSatiety.Value.ToString() + "%";
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
