namespace Tamagotchi
{
    partial class Shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("10", 10);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("12", 11);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("13", 13);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("20", 7);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("18", 12);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("10", 5);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("13", 14);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("20", 9);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("25", 8);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("12", 4);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("10", 18);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("30", 17);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("18", 16);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("10", 15);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Bread_icon-icons.com_68777.png");
            this.imageList1.Images.SetKeyName(1, "Chili_Pepper_icon-icons.com_68769.png");
            this.imageList1.Images.SetKeyName(2, "Cupcake_icon-icons.com_68756.png");
            this.imageList1.Images.SetKeyName(3, "Ice_Cream_Cone_icon-icons.com_68735.png");
            this.imageList1.Images.SetKeyName(4, "if-food-c227-2427865_85689.png");
            this.imageList1.Images.SetKeyName(5, "Tako-icon_30267.png");
            this.imageList1.Images.SetKeyName(6, "Watermelon_icon-icons.com_68672.png");
            this.imageList1.Images.SetKeyName(7, "icons8-хотдог-16.png");
            this.imageList1.Images.SetKeyName(8, "icons8-гамбургер-16.png");
            this.imageList1.Images.SetKeyName(9, "icons8-помидор-16.png");
            this.imageList1.Images.SetKeyName(10, "icons8-картофель-фри-30.png");
            this.imageList1.Images.SetKeyName(11, "icons8-банановый-сплит-40.png");
            this.imageList1.Images.SetKeyName(12, "icons8-вишня-50.png");
            this.imageList1.Images.SetKeyName(13, "icons8-горячий-шоколад-50.png");
            this.imageList1.Images.SetKeyName(14, "icons8-слива-50.png");
            this.imageList1.Images.SetKeyName(15, "icons8-кокосовый-коктейль-40.png");
            this.imageList1.Images.SetKeyName(16, "icons8-мороженое-в-рожке-40.png");
            this.imageList1.Images.SetKeyName(17, "icons8-суши-40.png");
            this.imageList1.Images.SetKeyName(18, "icons8-цитрусовые-40.png");
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(155, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Покормить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(39, 37);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(382, 332);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 453);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Name = "Shop";
            this.Text = "Shop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
    }
}