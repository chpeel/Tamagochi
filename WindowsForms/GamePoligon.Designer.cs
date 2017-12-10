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
            this.label8 = new System.Windows.Forms.Label();
            this.labelHealth = new System.Windows.Forms.Label();
            this.labelHygiene = new System.Windows.Forms.Label();
            this.labelSleeping = new System.Windows.Forms.Label();
            this.labelSatiety = new System.Windows.Forms.Label();
            this.labelNutural_Need = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWhile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrizz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPanda)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarHealth
            // 
            this.progressBarHealth.Location = new System.Drawing.Point(58, 53);
            this.progressBarHealth.Minimum = 20;
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
            this.progressBarSatiety.Click += new System.EventHandler(this.progressBarSatiety_Click);
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
            this.progressBarMood.BackColor = System.Drawing.Color.Green;
            this.progressBarMood.Location = new System.Drawing.Point(645, 53);
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
            this.pictureBoxWhile.Location = new System.Drawing.Point(366, 118);
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
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(60, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Здоровье";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(196, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Гигиена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(346, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Бодрость";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(483, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Сытость";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(642, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Настроение";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(799, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Естественные нужды";
            // 
            // labelMood
            // 
            this.labelMood.AutoSize = true;
            this.labelMood.BackColor = System.Drawing.Color.Green;
            this.labelMood.Location = new System.Drawing.Point(685, 59);
            this.labelMood.Name = "labelMood";
            this.labelMood.Size = new System.Drawing.Size(0, 17);
            this.labelMood.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Tomato;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(58, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 29);
            this.label8.TabIndex = 20;
            // 
            // labelHealth
            // 
            this.labelHealth.AutoSize = true;
            this.labelHealth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelHealth.Location = new System.Drawing.Point(85, 53);
            this.labelHealth.Name = "labelHealth";
            this.labelHealth.Size = new System.Drawing.Size(0, 17);
            this.labelHealth.TabIndex = 21;
            // 
            // labelHygiene
            // 
            this.labelHygiene.AutoSize = true;
            this.labelHygiene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelHygiene.Location = new System.Drawing.Point(220, 53);
            this.labelHygiene.Name = "labelHygiene";
            this.labelHygiene.Size = new System.Drawing.Size(0, 17);
            this.labelHygiene.TabIndex = 22;
            // 
            // labelSleeping
            // 
            this.labelSleeping.AutoSize = true;
            this.labelSleeping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelSleeping.Location = new System.Drawing.Point(370, 53);
            this.labelSleeping.Name = "labelSleeping";
            this.labelSleeping.Size = new System.Drawing.Size(0, 17);
            this.labelSleeping.TabIndex = 23;
            // 
            // labelSatiety
            // 
            this.labelSatiety.AutoSize = true;
            this.labelSatiety.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelSatiety.Location = new System.Drawing.Point(511, 53);
            this.labelSatiety.Name = "labelSatiety";
            this.labelSatiety.Size = new System.Drawing.Size(0, 17);
            this.labelSatiety.TabIndex = 24;
            this.labelSatiety.Click += new System.EventHandler(this.labelSatiety_Click);
            // 
            // labelNutural_Need
            // 
            this.labelNutural_Need.AutoSize = true;
            this.labelNutural_Need.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelNutural_Need.Location = new System.Drawing.Point(824, 53);
            this.labelNutural_Need.Name = "labelNutural_Need";
            this.labelNutural_Need.Size = new System.Drawing.Size(0, 17);
            this.labelNutural_Need.TabIndex = 25;
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(813, 281);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(202, 41);
            this.button6.TabIndex = 29;
            this.button6.Text = "Сходить в туалет";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(813, 328);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(202, 42);
            this.button5.TabIndex = 28;
            this.button5.Text = "Поспать";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(812, 376);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 44);
            this.button4.TabIndex = 27;
            this.button4.Text = "Поиграть с Медведем";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(812, 426);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 44);
            this.button3.TabIndex = 26;
            this.button3.Text = "Помыться";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GamePoligon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 569);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labelNutural_Need);
            this.Controls.Add(this.labelSatiety);
            this.Controls.Add(this.labelSleeping);
            this.Controls.Add(this.labelHygiene);
            this.Controls.Add(this.labelHealth);
            this.Controls.Add(this.label8);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelHealth;
        private System.Windows.Forms.Label labelHygiene;
        private System.Windows.Forms.Label labelSleeping;
        private System.Windows.Forms.Label labelNutural_Need;
        public System.Windows.Forms.Label labelSatiety;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}