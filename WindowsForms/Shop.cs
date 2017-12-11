﻿using System;
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
            foreach(ListViewItem q in listView1.SelectedItems)
            {
                price = Convert.ToInt32(q.Text);
            }
            GamePoligon gamePolygon = (GamePoligon)this.Owner;
            gamePolygon.Price += price;
            gamePolygon.progressBarSatiety.Value += price;
            bear.Money = bear.Money - gamePolygon.Price;
            gamePolygon.label1.Text = $"Количество листиков: {Convert.ToString(bear.Money)}";
            gamePolygon.labelSatiety.Text = gamePolygon.progressBarSatiety.Value.ToString() + "%";
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
