namespace Tamagotchi
{
    partial class CreateTam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTam));
            this.textBoxNameTam = new System.Windows.Forms.TextBox();
            this.labelNameTam = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxBearWhile = new System.Windows.Forms.PictureBox();
            this.pictureBoxBear = new System.Windows.Forms.PictureBox();
            this.pictureBoxBearPanda = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBearWhile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBearPanda)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNameTam
            // 
            this.textBoxNameTam.Location = new System.Drawing.Point(76, 67);
            this.textBoxNameTam.Name = "textBoxNameTam";
            this.textBoxNameTam.Size = new System.Drawing.Size(170, 22);
            this.textBoxNameTam.TabIndex = 0;
            // 
            // labelNameTam
            // 
            this.labelNameTam.AutoSize = true;
            this.labelNameTam.Location = new System.Drawing.Point(73, 38);
            this.labelNameTam.Name = "labelNameTam";
            this.labelNameTam.Size = new System.Drawing.Size(195, 17);
            this.labelNameTam.TabIndex = 1;
            this.labelNameTam.Text = "Как завут вашего питомца? ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxBearWhile
            // 
            this.pictureBoxBearWhile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBearWhile.BackgroundImage")));
            this.pictureBoxBearWhile.Location = new System.Drawing.Point(41, 182);
            this.pictureBoxBearWhile.Name = "pictureBoxBearWhile";
            this.pictureBoxBearWhile.Size = new System.Drawing.Size(313, 272);
            this.pictureBoxBearWhile.TabIndex = 3;
            this.pictureBoxBearWhile.TabStop = false;
            this.pictureBoxBearWhile.Click += new System.EventHandler(this.pictureBoxBearWhile_Click);
            // 
            // pictureBoxBear
            // 
            this.pictureBoxBear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBear.BackgroundImage")));
            this.pictureBoxBear.Location = new System.Drawing.Point(410, 228);
            this.pictureBoxBear.Name = "pictureBoxBear";
            this.pictureBoxBear.Size = new System.Drawing.Size(164, 195);
            this.pictureBoxBear.TabIndex = 4;
            this.pictureBoxBear.TabStop = false;
            this.pictureBoxBear.Click += new System.EventHandler(this.pictureBoxBear_Click);
            // 
            // pictureBoxBearPanda
            // 
            this.pictureBoxBearPanda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBearPanda.BackgroundImage")));
            this.pictureBoxBearPanda.Location = new System.Drawing.Point(597, 202);
            this.pictureBoxBearPanda.Name = "pictureBoxBearPanda";
            this.pictureBoxBearPanda.Size = new System.Drawing.Size(212, 269);
            this.pictureBoxBearPanda.TabIndex = 5;
            this.pictureBoxBearPanda.TabStop = false;
            this.pictureBoxBearPanda.Click += new System.EventHandler(this.pictureBoxBearPanda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите медведя";
            // 
            // CreateTam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 564);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxBearPanda);
            this.Controls.Add(this.pictureBoxBear);
            this.Controls.Add(this.pictureBoxBearWhile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelNameTam);
            this.Controls.Add(this.textBoxNameTam);
            this.Name = "CreateTam";
            this.Text = "CreateTam";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBearWhile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBearPanda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNameTam;
        private System.Windows.Forms.Label labelNameTam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxBearWhile;
        private System.Windows.Forms.PictureBox pictureBoxBear;
        private System.Windows.Forms.PictureBox pictureBoxBearPanda;
        private System.Windows.Forms.Label label1;
    }
}