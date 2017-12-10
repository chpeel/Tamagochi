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
    public partial class CreateTam : Form
    {

        Image image;

        public CreateTam()
        {
            InitializeComponent();
        }

        private void pictureBoxBearWhile_Click(object sender, EventArgs e)
        {
            string bear = "White";
        }

        private void pictureBoxBear_Click(object sender, EventArgs e)
        {
            string bear = "Bear";
        }

        private void pictureBoxBearPanda_Click(object sender, EventArgs e)
        {
            string bear = "Panda";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bear bear = new Bear(textBoxNameTam.Text);
        }
    }
}
