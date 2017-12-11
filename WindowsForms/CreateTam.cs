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

namespace Tamagotchi
{
    public partial class CreateTam : Form
    {
        String typeBear = "";
        GamePoligon poligon;

        public CreateTam()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void CreateTam_Load(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"..\..\..\s1.wav");
            sound.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            typeBear = "Grizz";
            MessageBox.Show("Самый лучший мишка!Выбор сделан!", "Сообщение");
        }

        private void buttonWhileBear_Click(object sender, EventArgs e)
        {
            typeBear = "White";
            MessageBox.Show("Самый лучший мишка!Выбор сделан!", "Сообщение");
        }

        private void buttonBeerPanda_Click(object sender, EventArgs e)
        {
            typeBear = "Panda";
            MessageBox.Show("Самый лучший мишка!Выбор сделан!", "Сообщение");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            poligon= new GamePoligon();
            poligon.SetTypeBear(typeBear);
            poligon.SetNameBear(textBoxNameTam.Text);
            this.Close();
            poligon.Show();
        }
    }
}
