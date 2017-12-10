namespace Tamagotchi
{
    partial class GamePoligon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePoligon));
            this.progressBarHealth = new System.Windows.Forms.ProgressBar();
            this.progressBarSatiety = new System.Windows.Forms.ProgressBar();
            this.progressBarSleeping = new System.Windows.Forms.ProgressBar();
            this.progressBarHygiene = new System.Windows.Forms.ProgressBar();
            this.progressBarMood = new System.Windows.Forms.ProgressBar();
            this.progressBarNuturalNeed = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxWhile = new System.Windows.Forms.PictureBox();
            this.pictureBoxGrizz = new System.Windows.Forms.PictureBox();
            this.pictureBoxPanda = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMood = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWhile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrizz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPanda)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarHealth
            // 
            this.progressBarHealth.Location = new System.Drawing.Point(58, 53);
            this.progressBarHealth.Name = "progressBarHealth";
            this.progressBarHealth.Size = new System.Drawing.Size(100, 23);
            this.progressBarHealth.Step = -10;
            this.progressBarHealth.TabIndex = 2;
            this.progressBarHealth.Value = 100;
            this.progressBarHealth.Click += new System.EventHandler(this.progressBarHealth_Click);
            // 
            // progressBarSatiety
            // 
            this.progressBarSatiety.Location = new System.Drawing.Point(486, 53);
            this.progressBarSatiety.Name = "progressBarSatiety";
            this.progressBarSatiety.Size = new System.Drawing.Size(100, 23);
            this.progressBarSatiety.Step = -10;
            this.progressBarSatiety.TabIndex = 3;
            this.progressBarSatiety.Value = 100;
            // 
            // progressBarSleeping
            // 
            this.progressBarSleeping.Location = new System.Drawing.Point(346, 53);
            this.progressBarSleeping.Name = "progressBarSleeping";
            this.progressBarSleeping.Size = new System.Drawing.Size(100, 23);
            this.progressBarSleeping.Step = -10;
            this.progressBarSleeping.TabIndex = 4;
            this.progressBarSleeping.Value = 100;
            // 
            // progressBarHygiene
            // 
            this.progressBarHygiene.Location = new System.Drawing.Point(196, 53);
            this.progressBarHygiene.Name = "progressBarHygiene";
            this.progressBarHygiene.Size = new System.Drawing.Size(100, 23);
            this.progressBarHygiene.Step = -10;
            this.progressBarHygiene.TabIndex = 5;
            this.progressBarHygiene.Value = 100;
            // 
            // progressBarMood
            // 
            this.progressBarMood.Location = new System.Drawing.Point(644, 53);
            this.progressBarMood.Name = "progressBarMood";
            this.progressBarMood.Size = new System.Drawing.Size(100, 23);
            this.progressBarMood.Step = -10;
            this.progressBarMood.TabIndex = 6;
            this.progressBarMood.Value = 100;
            // 
            // progressBarNuturalNeed
            // 
            this.progressBarNuturalNeed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBarNuturalNeed.Location = new System.Drawing.Point(799, 53);
            this.progressBarNuturalNeed.Name = "progressBarNuturalNeed";
            this.progressBarNuturalNeed.Size = new System.Drawing.Size(100, 23);
            this.progressBarNuturalNeed.Step = -10;
            this.progressBarNuturalNeed.TabIndex = 7;
            this.progressBarNuturalNeed.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(27, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 8;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(24, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Магазин еды";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(813, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 61);
            this.button2.TabIndex = 10;
            this.button2.Text = "Багаж";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timerHealth_Tick);
            // 
            // pictureBoxWhile
            // 
            this.pictureBoxWhile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWhile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxWhile.BackgroundImage")));
            this.pictureBoxWhile.Location = new System.Drawing.Point(378, 124);
            this.pictureBoxWhile.Name = "pictureBoxWhile";
            this.pictureBoxWhile.Size = new System.Drawing.Size(243, 433);
            this.pictureBoxWhile.TabIndex = 0;
            this.pictureBoxWhile.TabStop = false;
            this.pictureBoxWhile.Visible = false;
            this.pictureBoxWhile.Click += new System.EventHandler(this.pictureBoxTam_Click);
            // 
            // pictureBoxGrizz
            // 
            this.pictureBoxGrizz.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGrizz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxGrizz.BackgroundImage")));
            this.pictureBoxGrizz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxGrizz.Location = new System.Drawing.Point(362, 256);
            this.pictureBoxGrizz.Name = "pictureBoxGrizz";
            this.pictureBoxGrizz.Size = new System.Drawing.Size(259, 301);
            this.pictureBoxGrizz.TabIndex = 11;
            this.pictureBoxGrizz.TabStop = false;
            this.pictureBoxGrizz.Visible = false;
            this.pictureBoxGrizz.Click += new System.EventHandler(this.pictureBoxGrizz_Click);
            // 
            // pictureBoxPanda
            // 
            this.pictureBoxPanda.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPanda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPanda.BackgroundImage")));
            this.pictureBoxPanda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxPanda.Location = new System.Drawing.Point(399, 232);
            this.pictureBoxPanda.Name = "pictureBoxPanda";
            this.pictureBoxPanda.Size = new System.Drawing.Size(207, 325);
            this.pictureBoxPanda.TabIndex = 12;
            this.pictureBoxPanda.TabStop = false;
            this.pictureBoxPanda.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Здоровье";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Гигиена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Бодрость";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Сытость";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(641, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Настроение";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(799, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Естественные нужды";
            // 
            // labelMood
            // 
            this.labelMood.AutoSize = true;
            this.labelMood.BackColor = System.Drawing.Color.Transparent;
            this.labelMood.Location = new System.Drawing.Point(659, 53);
            this.labelMood.Name = "labelMood";
            this.labelMood.Size = new System.Drawing.Size(0, 17);
            this.labelMood.TabIndex = 19;
            // 
            // GamePoligon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 569);
            this.Controls.Add(this.labelMood);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxPanda);
            this.Controls.Add(this.pictureBoxGrizz);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarNuturalNeed);
            this.Controls.Add(this.progressBarMood);
            this.Controls.Add(this.progressBarHygiene);
            this.Controls.Add(this.progressBarSleeping);
            this.Controls.Add(this.progressBarSatiety);
            this.Controls.Add(this.progressBarHealth);
            this.Controls.Add(this.pictureBoxWhile);
            this.Name = "GamePoligon";
            this.Text = "GamePoligon";
            this.Load += new System.EventHandler(this.GamePoligon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWhile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrizz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPanda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBarHealth;
        private System.Windows.Forms.ProgressBar progressBarSleeping;
        private System.Windows.Forms.ProgressBar progressBarHygiene;
        private System.Windows.Forms.ProgressBar progressBarMood;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBoxWhile;
        private System.Windows.Forms.PictureBox pictureBoxGrizz;
        private System.Windows.Forms.PictureBox pictureBoxPanda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBarNuturalNeed;
        private System.Windows.Forms.Label labelMood;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ProgressBar progressBarSatiety;
    }
}