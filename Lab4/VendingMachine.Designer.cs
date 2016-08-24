namespace Lab4
{
    partial class VendingMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendingMachine));
            this.imlButtons = new System.Windows.Forms.ImageList(this.components);
            this.lblWater = new System.Windows.Forms.Label();
            this.lblOrange = new System.Windows.Forms.Label();
            this.lblRedBull = new System.Windows.Forms.Label();
            this.lblPepsi = new System.Windows.Forms.Label();
            this.lblCoke = new System.Windows.Forms.Label();
            this.lblFanta = new System.Windows.Forms.Label();
            this.lblSprite = new System.Windows.Forms.Label();
            this.lblMountain = new System.Windows.Forms.Label();
            this.lblRootBeer = new System.Windows.Forms.Label();
            this.lblMilk = new System.Windows.Forms.Label();
            this.lblCMilk = new System.Windows.Forms.Label();
            this.lblPepper = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblRetrieve = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnMountainDew = new System.Windows.Forms.Button();
            this.BtnCMilk = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnDrPepper = new System.Windows.Forms.Button();
            this.btnRootbeer = new System.Windows.Forms.Button();
            this.btnSprite = new System.Windows.Forms.Button();
            this.btnPepsi = new System.Windows.Forms.Button();
            this.btnCoke = new System.Windows.Forms.Button();
            this.btnRedbull = new System.Windows.Forms.Button();
            this.btnFanta = new System.Windows.Forms.Button();
            this.btnMilk = new System.Windows.Forms.Button();
            this.btnWater = new System.Windows.Forms.Button();
            this.lblProfit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imlButtons
            // 
            this.imlButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButtons.ImageStream")));
            this.imlButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButtons.Images.SetKeyName(0, "bottled-water.jpg");
            this.imlButtons.Images.SetKeyName(1, "CocaColaBottle_background_free.jpg");
            this.imlButtons.Images.SetKeyName(2, "milk-bottle.jpg");
            this.imlButtons.Images.SetKeyName(3, "pepsi-bottle.jpg");
            this.imlButtons.Images.SetKeyName(4, "Sprite-8oz-Glass.gif");
            this.imlButtons.Images.SetKeyName(5, "1_henry_weinhard_93566f0d-b99c-422b-b46b-d7aa00d127f0_large.png");
            this.imlButtons.Images.SetKeyName(6, "6e67814d1d0d2f4a37d652d5899be897.jpg");
            this.imlButtons.Images.SetKeyName(7, "9294788-Orange-juice-glass-bottle-Isolated-on-white-background-Stock-Photo.jpg");
            this.imlButtons.Images.SetKeyName(8, "fanta-040130_1.jpg");
            this.imlButtons.Images.SetKeyName(9, "INT_250_RBED_SingleUnit_closed_cold_front.png");
            this.imlButtons.Images.SetKeyName(10, "milk-bottle.jpg");
            this.imlButtons.Images.SetKeyName(11, "Mountain_Dew__97480_zoom__07112_zoom.jpg");
            this.imlButtons.Images.SetKeyName(12, "Premium-Chocolate-Milk-Harmony_Organic_Returnable_Glass_Milk_Bottle.png");
            this.imlButtons.Images.SetKeyName(13, "DSC05974-1024x679.jpg");
            // 
            // lblWater
            // 
            this.lblWater.AutoSize = true;
            this.lblWater.Location = new System.Drawing.Point(56, 25);
            this.lblWater.Name = "lblWater";
            this.lblWater.Size = new System.Drawing.Size(66, 13);
            this.lblWater.TabIndex = 12;
            this.lblWater.Text = "Water $1.00";
            // 
            // lblOrange
            // 
            this.lblOrange.AutoSize = true;
            this.lblOrange.Location = new System.Drawing.Point(164, 25);
            this.lblOrange.Name = "lblOrange";
            this.lblOrange.Size = new System.Drawing.Size(73, 13);
            this.lblOrange.TabIndex = 13;
            this.lblOrange.Text = "O Juice $2.00";
            // 
            // lblRedBull
            // 
            this.lblRedBull.AutoSize = true;
            this.lblRedBull.Location = new System.Drawing.Point(279, 25);
            this.lblRedBull.Name = "lblRedBull";
            this.lblRedBull.Size = new System.Drawing.Size(77, 13);
            this.lblRedBull.TabIndex = 14;
            this.lblRedBull.Text = "Red Bull $1.50";
            // 
            // lblPepsi
            // 
            this.lblPepsi.AutoSize = true;
            this.lblPepsi.Location = new System.Drawing.Point(56, 124);
            this.lblPepsi.Name = "lblPepsi";
            this.lblPepsi.Size = new System.Drawing.Size(63, 13);
            this.lblPepsi.TabIndex = 15;
            this.lblPepsi.Text = "Pepsi $1.00";
            // 
            // lblCoke
            // 
            this.lblCoke.AutoSize = true;
            this.lblCoke.Location = new System.Drawing.Point(164, 124);
            this.lblCoke.Name = "lblCoke";
            this.lblCoke.Size = new System.Drawing.Size(62, 13);
            this.lblCoke.TabIndex = 16;
            this.lblCoke.Text = "Coke $1.00";
            // 
            // lblFanta
            // 
            this.lblFanta.AutoSize = true;
            this.lblFanta.Location = new System.Drawing.Point(281, 124);
            this.lblFanta.Name = "lblFanta";
            this.lblFanta.Size = new System.Drawing.Size(64, 13);
            this.lblFanta.TabIndex = 17;
            this.lblFanta.Text = "Fanta $0.75";
            // 
            // lblSprite
            // 
            this.lblSprite.AutoSize = true;
            this.lblSprite.Location = new System.Drawing.Point(55, 223);
            this.lblSprite.Name = "lblSprite";
            this.lblSprite.Size = new System.Drawing.Size(64, 13);
            this.lblSprite.TabIndex = 18;
            this.lblSprite.Text = "Sprite $1.25";
            // 
            // lblMountain
            // 
            this.lblMountain.AutoSize = true;
            this.lblMountain.Location = new System.Drawing.Point(164, 223);
            this.lblMountain.Name = "lblMountain";
            this.lblMountain.Size = new System.Drawing.Size(71, 13);
            this.lblMountain.TabIndex = 19;
            this.lblMountain.Text = "M Dew $1.50";
            // 
            // lblRootBeer
            // 
            this.lblRootBeer.AutoSize = true;
            this.lblRootBeer.Location = new System.Drawing.Point(281, 223);
            this.lblRootBeer.Name = "lblRootBeer";
            this.lblRootBeer.Size = new System.Drawing.Size(70, 13);
            this.lblRootBeer.TabIndex = 20;
            this.lblRootBeer.Text = "R Beer $2.00";
            // 
            // lblMilk
            // 
            this.lblMilk.AutoSize = true;
            this.lblMilk.Location = new System.Drawing.Point(64, 325);
            this.lblMilk.Name = "lblMilk";
            this.lblMilk.Size = new System.Drawing.Size(56, 13);
            this.lblMilk.TabIndex = 21;
            this.lblMilk.Text = "Milk $3.00";
            // 
            // lblCMilk
            // 
            this.lblCMilk.AutoSize = true;
            this.lblCMilk.Location = new System.Drawing.Point(164, 325);
            this.lblCMilk.Name = "lblCMilk";
            this.lblCMilk.Size = new System.Drawing.Size(66, 13);
            this.lblCMilk.TabIndex = 22;
            this.lblCMilk.Text = "C Milk $3.25";
            // 
            // lblPepper
            // 
            this.lblPepper.AutoSize = true;
            this.lblPepper.Location = new System.Drawing.Point(276, 325);
            this.lblPepper.Name = "lblPepper";
            this.lblPepper.Size = new System.Drawing.Size(85, 13);
            this.lblPepper.TabIndex = 23;
            this.lblPepper.Text = "Dr.Pepper $1.25";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(398, 25);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 27;
            this.lblTime.Text = "Time";
            // 
            // lblRetrieve
            // 
            this.lblRetrieve.AutoSize = true;
            this.lblRetrieve.Location = new System.Drawing.Point(398, 325);
            this.lblRetrieve.Name = "lblRetrieve";
            this.lblRetrieve.Size = new System.Drawing.Size(102, 13);
            this.lblRetrieve.TabIndex = 28;
            this.lblRetrieve.Text = "Retrieve From Here:";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(401, 58);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(93, 37);
            this.btnAdmin.TabIndex = 29;
            this.btnAdmin.Text = "Admin Window";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // lblResult
            // 
            this.lblResult.ImageIndex = 13;
            this.lblResult.ImageList = this.imlButtons;
            this.lblResult.Location = new System.Drawing.Point(407, 341);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(75, 71);
            this.lblResult.TabIndex = 24;
            // 
            // btnMountainDew
            // 
            this.btnMountainDew.ImageIndex = 11;
            this.btnMountainDew.ImageList = this.imlButtons;
            this.btnMountainDew.Location = new System.Drawing.Point(163, 239);
            this.btnMountainDew.Name = "btnMountainDew";
            this.btnMountainDew.Size = new System.Drawing.Size(77, 71);
            this.btnMountainDew.TabIndex = 11;
            this.btnMountainDew.UseVisualStyleBackColor = true;
            this.btnMountainDew.Click += new System.EventHandler(this.btnMountainDew_Click);
            // 
            // BtnCMilk
            // 
            this.BtnCMilk.ImageIndex = 12;
            this.BtnCMilk.ImageList = this.imlButtons;
            this.BtnCMilk.Location = new System.Drawing.Point(163, 341);
            this.BtnCMilk.Name = "BtnCMilk";
            this.BtnCMilk.Size = new System.Drawing.Size(77, 71);
            this.BtnCMilk.TabIndex = 10;
            this.BtnCMilk.UseVisualStyleBackColor = true;
            this.BtnCMilk.Click += new System.EventHandler(this.BtnCMilk_Click);
            // 
            // btnOrange
            // 
            this.btnOrange.ImageIndex = 7;
            this.btnOrange.ImageList = this.imlButtons;
            this.btnOrange.Location = new System.Drawing.Point(163, 41);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(77, 71);
            this.btnOrange.TabIndex = 9;
            this.btnOrange.UseVisualStyleBackColor = true;
            this.btnOrange.Click += new System.EventHandler(this.btnOrange_Click);
            // 
            // btnDrPepper
            // 
            this.btnDrPepper.ImageIndex = 6;
            this.btnDrPepper.ImageList = this.imlButtons;
            this.btnDrPepper.Location = new System.Drawing.Point(279, 341);
            this.btnDrPepper.Name = "btnDrPepper";
            this.btnDrPepper.Size = new System.Drawing.Size(77, 71);
            this.btnDrPepper.TabIndex = 8;
            this.btnDrPepper.UseVisualStyleBackColor = true;
            this.btnDrPepper.Click += new System.EventHandler(this.btnDrPepper_Click);
            // 
            // btnRootbeer
            // 
            this.btnRootbeer.ImageIndex = 5;
            this.btnRootbeer.ImageList = this.imlButtons;
            this.btnRootbeer.Location = new System.Drawing.Point(279, 239);
            this.btnRootbeer.Name = "btnRootbeer";
            this.btnRootbeer.Size = new System.Drawing.Size(77, 71);
            this.btnRootbeer.TabIndex = 7;
            this.btnRootbeer.UseVisualStyleBackColor = true;
            this.btnRootbeer.Click += new System.EventHandler(this.btnRootbeer_Click);
            // 
            // btnSprite
            // 
            this.btnSprite.ImageIndex = 4;
            this.btnSprite.ImageList = this.imlButtons;
            this.btnSprite.Location = new System.Drawing.Point(45, 239);
            this.btnSprite.Name = "btnSprite";
            this.btnSprite.Size = new System.Drawing.Size(77, 71);
            this.btnSprite.TabIndex = 6;
            this.btnSprite.UseVisualStyleBackColor = true;
            this.btnSprite.Click += new System.EventHandler(this.btnSprite_Click);
            // 
            // btnPepsi
            // 
            this.btnPepsi.ImageIndex = 3;
            this.btnPepsi.ImageList = this.imlButtons;
            this.btnPepsi.Location = new System.Drawing.Point(45, 140);
            this.btnPepsi.Name = "btnPepsi";
            this.btnPepsi.Size = new System.Drawing.Size(77, 71);
            this.btnPepsi.TabIndex = 5;
            this.btnPepsi.UseVisualStyleBackColor = true;
            this.btnPepsi.Click += new System.EventHandler(this.btnPepsi_Click);
            // 
            // btnCoke
            // 
            this.btnCoke.ImageIndex = 1;
            this.btnCoke.ImageList = this.imlButtons;
            this.btnCoke.Location = new System.Drawing.Point(163, 140);
            this.btnCoke.Name = "btnCoke";
            this.btnCoke.Size = new System.Drawing.Size(77, 71);
            this.btnCoke.TabIndex = 4;
            this.btnCoke.UseVisualStyleBackColor = true;
            this.btnCoke.Click += new System.EventHandler(this.btnCoke_Click);
            // 
            // btnRedbull
            // 
            this.btnRedbull.ImageIndex = 9;
            this.btnRedbull.ImageList = this.imlButtons;
            this.btnRedbull.Location = new System.Drawing.Point(279, 41);
            this.btnRedbull.Name = "btnRedbull";
            this.btnRedbull.Size = new System.Drawing.Size(77, 71);
            this.btnRedbull.TabIndex = 3;
            this.btnRedbull.UseVisualStyleBackColor = true;
            this.btnRedbull.Click += new System.EventHandler(this.btnRedbull_Click);
            // 
            // btnFanta
            // 
            this.btnFanta.ImageIndex = 8;
            this.btnFanta.ImageList = this.imlButtons;
            this.btnFanta.Location = new System.Drawing.Point(279, 140);
            this.btnFanta.Name = "btnFanta";
            this.btnFanta.Size = new System.Drawing.Size(77, 71);
            this.btnFanta.TabIndex = 2;
            this.btnFanta.UseVisualStyleBackColor = true;
            this.btnFanta.Click += new System.EventHandler(this.btnFanta_Click);
            // 
            // btnMilk
            // 
            this.btnMilk.ImageIndex = 2;
            this.btnMilk.ImageList = this.imlButtons;
            this.btnMilk.Location = new System.Drawing.Point(45, 341);
            this.btnMilk.Name = "btnMilk";
            this.btnMilk.Size = new System.Drawing.Size(77, 71);
            this.btnMilk.TabIndex = 1;
            this.btnMilk.UseVisualStyleBackColor = true;
            this.btnMilk.Click += new System.EventHandler(this.btnMilk_Click);
            // 
            // btnWater
            // 
            this.btnWater.ImageIndex = 0;
            this.btnWater.ImageList = this.imlButtons;
            this.btnWater.Location = new System.Drawing.Point(45, 41);
            this.btnWater.Name = "btnWater";
            this.btnWater.Size = new System.Drawing.Size(77, 71);
            this.btnWater.TabIndex = 0;
            this.btnWater.UseVisualStyleBackColor = true;
            this.btnWater.Click += new System.EventHandler(this.btnWater_Click);
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Location = new System.Drawing.Point(398, 41);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(31, 13);
            this.lblProfit.TabIndex = 30;
            this.lblProfit.Text = "Profit";
            this.lblProfit.Click += new System.EventHandler(this.lblProfit_Click);
            // 
            // VendingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 451);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.lblRetrieve);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblPepper);
            this.Controls.Add(this.lblCMilk);
            this.Controls.Add(this.lblMilk);
            this.Controls.Add(this.lblRootBeer);
            this.Controls.Add(this.lblMountain);
            this.Controls.Add(this.lblSprite);
            this.Controls.Add(this.lblFanta);
            this.Controls.Add(this.lblCoke);
            this.Controls.Add(this.lblPepsi);
            this.Controls.Add(this.lblRedBull);
            this.Controls.Add(this.lblOrange);
            this.Controls.Add(this.lblWater);
            this.Controls.Add(this.btnMountainDew);
            this.Controls.Add(this.BtnCMilk);
            this.Controls.Add(this.btnOrange);
            this.Controls.Add(this.btnDrPepper);
            this.Controls.Add(this.btnRootbeer);
            this.Controls.Add(this.btnSprite);
            this.Controls.Add(this.btnPepsi);
            this.Controls.Add(this.btnCoke);
            this.Controls.Add(this.btnRedbull);
            this.Controls.Add(this.btnFanta);
            this.Controls.Add(this.btnMilk);
            this.Controls.Add(this.btnWater);
            this.Name = "VendingMachine";
            this.Text = "Vending Machine";
            this.Load += new System.EventHandler(this.VendingMachine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWater;
        private System.Windows.Forms.ImageList imlButtons;
        private System.Windows.Forms.Button btnMilk;
        private System.Windows.Forms.Button btnFanta;
        private System.Windows.Forms.Button btnRedbull;
        private System.Windows.Forms.Button btnCoke;
        private System.Windows.Forms.Button btnPepsi;
        private System.Windows.Forms.Button btnSprite;
        private System.Windows.Forms.Button btnRootbeer;
        private System.Windows.Forms.Button btnDrPepper;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Button BtnCMilk;
        private System.Windows.Forms.Button btnMountainDew;
        private System.Windows.Forms.Label lblWater;
        private System.Windows.Forms.Label lblOrange;
        private System.Windows.Forms.Label lblRedBull;
        private System.Windows.Forms.Label lblPepsi;
        private System.Windows.Forms.Label lblCoke;
        private System.Windows.Forms.Label lblFanta;
        private System.Windows.Forms.Label lblSprite;
        private System.Windows.Forms.Label lblMountain;
        private System.Windows.Forms.Label lblRootBeer;
        private System.Windows.Forms.Label lblMilk;
        private System.Windows.Forms.Label lblCMilk;
        private System.Windows.Forms.Label lblPepper;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblRetrieve;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label lblProfit;
    }
}

