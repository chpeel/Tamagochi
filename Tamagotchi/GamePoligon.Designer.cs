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
            this.pictureBoxTam = new System.Windows.Forms.PictureBox();
            this.progressBarHealth = new System.Windows.Forms.ProgressBar();
            this.progressBarSatiety = new System.Windows.Forms.ProgressBar();
            this.progressBarSleeping = new System.Windows.Forms.ProgressBar();
            this.progressBarHygiene = new System.Windows.Forms.ProgressBar();
            this.progressBarMood = new System.Windows.Forms.ProgressBar();
            this.progressBarNuturalNeed = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.timerHealth = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTam)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTam
            // 
            this.pictureBoxTam.Location = new System.Drawing.Point(296, 173);
            this.pictureBoxTam.Name = "pictureBoxTam";
            this.pictureBoxTam.Size = new System.Drawing.Size(182, 253);
            this.pictureBoxTam.TabIndex = 0;
            this.pictureBoxTam.TabStop = false;
            this.pictureBoxTam.Click += new System.EventHandler(this.pictureBoxTam_Click);
            // 
            // progressBarHealth
            // 
            this.progressBarHealth.Location = new System.Drawing.Point(30, 12);
            this.progressBarHealth.Name = "progressBarHealth";
            this.progressBarHealth.Size = new System.Drawing.Size(100, 23);
            this.progressBarHealth.TabIndex = 2;
            this.progressBarHealth.Click += new System.EventHandler(this.progressBarHealth_Click);
            // 
            // progressBarSatiety
            // 
            this.progressBarSatiety.Location = new System.Drawing.Point(378, 22);
            this.progressBarSatiety.Name = "progressBarSatiety";
            this.progressBarSatiety.Size = new System.Drawing.Size(100, 23);
            this.progressBarSatiety.TabIndex = 3;
            // 
            // progressBarSleeping
            // 
            this.progressBarSleeping.Location = new System.Drawing.Point(263, 22);
            this.progressBarSleeping.Name = "progressBarSleeping";
            this.progressBarSleeping.Size = new System.Drawing.Size(100, 23);
            this.progressBarSleeping.TabIndex = 4;
            // 
            // progressBarHygiene
            // 
            this.progressBarHygiene.Location = new System.Drawing.Point(145, 22);
            this.progressBarHygiene.Name = "progressBarHygiene";
            this.progressBarHygiene.Size = new System.Drawing.Size(100, 23);
            this.progressBarHygiene.TabIndex = 5;
            // 
            // progressBarMood
            // 
            this.progressBarMood.Location = new System.Drawing.Point(498, 22);
            this.progressBarMood.Name = "progressBarMood";
            this.progressBarMood.Size = new System.Drawing.Size(100, 23);
            this.progressBarMood.TabIndex = 6;
            // 
            // progressBarNuturalNeed
            // 
            this.progressBarNuturalNeed.Location = new System.Drawing.Point(623, 22);
            this.progressBarNuturalNeed.Name = "progressBarNuturalNeed";
            this.progressBarNuturalNeed.Size = new System.Drawing.Size(100, 23);
            this.progressBarNuturalNeed.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Количество денег:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Магазин еды";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "Багаж";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // timerHealth
            // 
            this.timerHealth.Tick += new System.EventHandler(this.timerHealth_Tick);
            // 
            // GamePoligon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(759, 458);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarNuturalNeed);
            this.Controls.Add(this.progressBarMood);
            this.Controls.Add(this.progressBarHygiene);
            this.Controls.Add(this.progressBarSleeping);
            this.Controls.Add(this.progressBarSatiety);
            this.Controls.Add(this.progressBarHealth);
            this.Controls.Add(this.pictureBoxTam);
            this.Name = "GamePoligon";
            this.Text = "GamePoligon";
            this.Load += new System.EventHandler(this.GamePoligon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTam;
        private System.Windows.Forms.ProgressBar progressBarHealth;
        private System.Windows.Forms.ProgressBar progressBarSatiety;
        private System.Windows.Forms.ProgressBar progressBarSleeping;
        private System.Windows.Forms.ProgressBar progressBarHygiene;
        private System.Windows.Forms.ProgressBar progressBarMood;
        private System.Windows.Forms.ProgressBar progressBarNuturalNeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timerHealth;
    }
}