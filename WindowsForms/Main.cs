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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateTam createTam = new CreateTam();
            createTam.Show();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            GamePoligon poligon = new GamePoligon();
            poligon.SetTypeBear("Panda");
            poligon.Show();
        }
    }
}