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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelNutural_Need = new System.Windows.Forms.Label();
            this.labelSatiety = new System.Windows.Forms.Label();
            this.labelSleeping = new System.Windows.Forms.Label();
            this.labelHygiene = new System.Windows.Forms.Label();
            this.labelHealth = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelMood = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxPanda = new System.Windows.Forms.PictureBox();
            this.pictureBoxGrizz = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarNuturalNeed = new System.Windows.Forms.ProgressBar();
            this.progressBarMood = new System.Windows.Forms.ProgressBar();
            this.progressBarHygiene = new System.Windows.Forms.ProgressBar();
            this.progressBarSleeping = new System.Windows.Forms.ProgressBar();
            this.progressBarSatiety = new System.Windows.Forms.ProgressBar();
            this.progressBarHealth = new System.Windows.Forms.ProgressBar();
            this.pictureBoxWhile = new System.Windows.Forms.PictureBox();
            this.progressBarSleep = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPanda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrizz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWhile)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timerHealth_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.labelNutural_Need);
            this.groupBox1.Controls.Add(this.labelSatiety);
            this.groupBox1.Controls.Add(this.labelSleeping);
            this.groupBox1.Controls.Add(this.labelHygiene);
            this.groupBox1.Controls.Add(this.labelHealth);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labelMood);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBoxPanda);
            this.groupBox1.Controls.Add(this.pictureBoxGrizz);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.progressBarNuturalNeed);
            this.groupBox1.Controls.Add(this.progressBarMood);
            this.groupBox1.Controls.Add(this.progressBarHygiene);
            this.groupBox1.Controls.Add(this.progressBarSleeping);
            this.groupBox1.Controls.Add(this.progressBarSatiety);
            this.groupBox1.Controls.Add(this.progressBarHealth);
            this.groupBox1.Controls.Add(this.pictureBoxWhile);
            this.groupBox1.Location = new System.Drawing.Point(-14, -10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1185, 633);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(891, 496);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(201, 37);
            this.button7.TabIndex = 60;
            this.button7.Text = "Работа(+10 листиков)";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(53, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 61);
            this.button2.TabIndex = 59;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(892, 297);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(202, 41);
            this.button6.TabIndex = 58;
            this.button6.Text = "Сходить в туалет";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(892, 344);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(202, 42);
            this.button5.TabIndex = 57;
            this.button5.Text = "Поспать";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(891, 392);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 44);
            this.button4.TabIndex = 56;
            this.button4.Text = "Поиграть с Медведем";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(891, 442);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 44);
            this.button3.TabIndex = 55;
            this.button3.Text = "Помыться";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // labelNutural_Need
            // 
            this.labelNutural_Need.AutoSize = true;
            this.labelNutural_Need.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelNutural_Need.Location = new System.Drawing.Point(903, 69);
            this.labelNutural_Need.Name = "labelNutural_Need";
            this.labelNutural_Need.Size = new System.Drawing.Size(44, 17);
            this.labelNutural_Need.TabIndex = 54;
            this.labelNutural_Need.Text = "100%";
            // 
            // labelSatiety
            // 
            this.labelSatiety.AutoSize = true;
            this.labelSatiety.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelSatiety.Location = new System.Drawing.Point(590, 69);
            this.labelSatiety.Name = "labelSatiety";
            this.labelSatiety.Size = new System.Drawing.Size(44, 17);
            this.labelSatiety.TabIndex = 53;
            this.labelSatiety.Text = "100%";
            // 
            // labelSleeping
            // 
            this.labelSleeping.AutoSize = true;
            this.labelSleeping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelSleeping.Location = new System.Drawing.Point(449, 69);
            this.labelSleeping.Name = "labelSleeping";
            this.labelSleeping.Size = new System.Drawing.Size(44, 17);
            this.labelSleeping.TabIndex = 52;
            this.labelSleeping.Text = "100%";
            // 
            // labelHygiene
            // 
            this.labelHygiene.AutoSize = true;
            this.labelHygiene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelHygiene.Location = new System.Drawing.Point(299, 69);
            this.labelHygiene.Name = "labelHygiene";
            this.labelHygiene.Size = new System.Drawing.Size(44, 17);
            this.labelHygiene.TabIndex = 51;
            this.labelHygiene.Text = "100%";
            // 
            // labelHealth
            // 
            this.labelHealth.AutoSize = true;
            this.labelHealth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelHealth.Location = new System.Drawing.Point(164, 69);
            this.labelHealth.Name = "labelHealth";
            this.labelHealth.Size = new System.Drawing.Size(44, 17);
            this.labelHealth.TabIndex = 50;
            this.labelHealth.Text = "100%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Tomato;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(137, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 29);
            this.label8.TabIndex = 49;
            // 
            // labelMood
            // 
            this.labelMood.AutoSize = true;
            this.labelMood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelMood.Location = new System.Drawing.Point(750, 69);
            this.labelMood.Name = "labelMood";
            this.labelMood.Size = new System.Drawing.Size(44, 17);
            this.labelMood.TabIndex = 48;
            this.labelMood.Text = "100%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(878, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Естественные нужды";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(721, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Настроение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(562, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Сытость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(425, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Бодрость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(275, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Гигиена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(139, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Здоровье";
            // 
            // pictureBoxPanda
            // 
            this.pictureBoxPanda.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPanda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPanda.BackgroundImage")));
            this.pictureBoxPanda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxPanda.Location = new System.Drawing.Point(478, 248);
            this.pictureBoxPanda.Name = "pictureBoxPanda";
            this.pictureBoxPanda.Size = new System.Drawing.Size(207, 325);
            this.pictureBoxPanda.TabIndex = 41;
            this.pictureBoxPanda.TabStop = false;
            this.pictureBoxPanda.Visible = false;
            // 
            // pictureBoxGrizz
            // 
            this.pictureBoxGrizz.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGrizz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxGrizz.BackgroundImage")));
            this.pictureBoxGrizz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxGrizz.Location = new System.Drawing.Point(441, 272);
            this.pictureBoxGrizz.Name = "pictureBoxGrizz";
            this.pictureBoxGrizz.Size = new System.Drawing.Size(259, 301);
            this.pictureBoxGrizz.TabIndex = 40;
            this.pictureBoxGrizz.TabStop = false;
            this.pictureBoxGrizz.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(53, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 48);
            this.button1.TabIndex = 38;
            this.button1.Text = "Магазин еды";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(106, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 37;
            // 
            // progressBarNuturalNeed
            // 
            this.progressBarNuturalNeed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBarNuturalNeed.Location = new System.Drawing.Point(881, 69);
            this.progressBarNuturalNeed.Name = "progressBarNuturalNeed";
            this.progressBarNuturalNeed.Size = new System.Drawing.Size(100, 23);
            this.progressBarNuturalNeed.Step = -10;
            this.progressBarNuturalNeed.TabIndex = 36;
            this.progressBarNuturalNeed.Value = 100;
            // 
            // progressBarMood
            // 
            this.progressBarMood.BackColor = System.Drawing.Color.Green;
            this.progressBarMood.Location = new System.Drawing.Point(724, 69);
            this.progressBarMood.Name = "progressBarMood";
            this.progressBarMood.Size = new System.Drawing.Size(100, 23);
            this.progressBarMood.Step = -10;
            this.progressBarMood.TabIndex = 35;
            this.progressBarMood.Value = 100;
            // 
            // progressBarHygiene
            // 
            this.progressBarHygiene.Location = new System.Drawing.Point(278, 69);
            this.progressBarHygiene.Name = "progressBarHygiene";
            this.progressBarHygiene.Size = new System.Drawing.Size(100, 23);
            this.progressBarHygiene.Step = -10;
            this.progressBarHygiene.TabIndex = 34;
            this.progressBarHygiene.Value = 100;
            // 
            // progressBarSleeping
            // 
            this.progressBarSleeping.Location = new System.Drawing.Point(428, 69);
            this.progressBarSleeping.Name = "progressBarSleeping";
            this.progressBarSleeping.Size = new System.Drawing.Size(100, 23);
            this.progressBarSleeping.Step = -10;
            this.progressBarSleeping.TabIndex = 33;
            this.progressBarSleeping.Value = 100;
            this.progressBarSleeping.Click += new System.EventHandler(this.progressBarSleeping_Click);
            // 
            // progressBarSatiety
            // 
            this.progressBarSatiety.Location = new System.Drawing.Point(565, 69);
            this.progressBarSatiety.Name = "progressBarSatiety";
            this.progressBarSatiety.Size = new System.Drawing.Size(100, 23);
            this.progressBarSatiety.Step = -10;
            this.progressBarSatiety.TabIndex = 32;
            this.progressBarSatiety.Value = 100;
            // 
            // progressBarHealth
            // 
            this.progressBarHealth.Location = new System.Drawing.Point(142, 69);
            this.progressBarHealth.Name = "progressBarHealth";
            this.progressBarHealth.Size = new System.Drawing.Size(100, 23);
            this.progressBarHealth.Step = 0;
            this.progressBarHealth.TabIndex = 31;
            this.progressBarHealth.Value = 100;
            // 
            // pictureBoxWhile
            // 
            this.pictureBoxWhile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWhile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxWhile.BackgroundImage")));
            this.pictureBoxWhile.Location = new System.Drawing.Point(445, 134);
            this.pictureBoxWhile.Name = "pictureBoxWhile";
            this.pictureBoxWhile.Size = new System.Drawing.Size(243, 433);
            this.pictureBoxWhile.TabIndex = 30;
            this.pictureBoxWhile.TabStop = false;
            this.pictureBoxWhile.Visible = false;
            // 
            // progressBarSleep
            // 
            this.progressBarSleep.Location = new System.Drawing.Point(214, 657);
            this.progressBarSleep.Name = "progressBarSleep";
            this.progressBarSleep.Size = new System.Drawing.Size(699, 38);
            this.progressBarSleep.Step = 1;
            this.progressBarSleep.TabIndex = 59;
            this.progressBarSleep.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GamePoligon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1161, 566);
            this.Controls.Add(this.progressBarSleep);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GamePoligon";
            this.Text = "GamePoligon";
            this.Load += new System.EventHandler(this.GamePoligon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPanda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrizz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWhile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelNutural_Need;
        public System.Windows.Forms.Label labelSatiety;
        private System.Windows.Forms.Label labelSleeping;
        private System.Windows.Forms.Label labelHygiene;
        private System.Windows.Forms.Label labelHealth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxPanda;
        private System.Windows.Forms.PictureBox pictureBoxGrizz;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarNuturalNeed;
        private System.Windows.Forms.ProgressBar progressBarHygiene;
        private System.Windows.Forms.ProgressBar progressBarSleeping;
        public System.Windows.Forms.ProgressBar progressBarSatiety;
        private System.Windows.Forms.ProgressBar progressBarHealth;
        private System.Windows.Forms.PictureBox pictureBoxWhile;
        private System.Windows.Forms.ProgressBar progressBarSleep;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label labelMood;
        public System.Windows.Forms.ProgressBar progressBarMood;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
    }
}