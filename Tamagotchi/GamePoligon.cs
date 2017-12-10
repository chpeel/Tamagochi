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
    public partial class GamePoligon : Form
    {
        CreateTam createTam = new CreateTam();

        public GamePoligon()
        {
            InitializeComponent();
        }

        private void pictureBoxTam_Click(object sender, EventArgs e)
        {
            
        }

        private void GamePoligon_Load(object sender, EventArgs e)
        {

        }

        private void progressBarHealth_Click(object sender, EventArgs e)
        {
            timerHealth.Interval = 500;
            timerHealth.Enabled = true;
            timerHealth.Tick += timerHealth_Tick;
        }

        private void timerHealth_Tick(object sender, EventArgs e)
        {
            progressBarHealth.PerformStep();
        }
    }
}
