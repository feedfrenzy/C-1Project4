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

namespace Lab4
{
    public partial class VendingMachine : Form
    {
        private SoundPlayer soundPlayer = new SoundPlayer("Drop.wav");

        ProductInventory water = new ProductInventory();
        ProductInventory Orange = new ProductInventory();
        ProductInventory Redbull = new ProductInventory();
        ProductInventory Pepsi = new ProductInventory();
        ProductInventory Coke = new ProductInventory();
        ProductInventory Fanta = new ProductInventory();
        ProductInventory Sprite = new ProductInventory();
        ProductInventory MDew = new ProductInventory();
        ProductInventory Rbeer = new ProductInventory();
        ProductInventory Milk = new ProductInventory();
        ProductInventory CMilk = new ProductInventory();
        ProductInventory DrPepper = new ProductInventory();

        Product totalPrice = new Product();

        //string[,] collection= new string[3,2];



        public VendingMachine()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void VendingMachine_Load(object sender, EventArgs e)
        {
          
        }


        private void btnWater_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            lblResult.ImageIndex = 0;
            //collection[0, 0] = "A1";

            
            int left = water.checkLeft;

            if (left == 0)
            {
                btnWater.Enabled = false;
                totalPrice.total = 1.00;
                lblProfit.Text = "$" + totalPrice.getPrice;
            }
            else
            {
                water.RemoveStock();
                totalPrice.total = 1.00;
                lblProfit.Text = "$" + totalPrice.getPrice;
            }

            

        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            lblResult.ImageIndex = 7;
            //collection[0, 1] = "A2";

            int left = Orange.checkLeft;

            if (left == 0)
            {
                btnOrange.Enabled = false;
                totalPrice.total = 2.00;
                lblProfit.Text = "$" + totalPrice.getPrice;
            }
            else
            {
                Orange.RemoveStock();
                totalPrice.total = 2.00;
                lblProfit.Text = "$" + totalPrice.getPrice;
            }
            
        }

        private void btnRedbull_Click(object sender, EventArgs e)   
        {
            soundPlayer.Play();
            lblResult.ImageIndex = 9;
            //collection[0, 2] = "A3";

            int left = Redbull.checkLeft;

            if (left == 0)
            {
                btnRedbull.Enabled = false;
                totalPrice.total = 1.50;
                lblProfit.Text = "$" + totalPrice.getPrice;
            }
            else
            {
                Redbull.RemoveStock();
                totalPrice.total = 1.50;
                lblProfit.Text = "$" + totalPrice.getPrice;
            }
        }

        private void btnPepsi_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            lblResult.ImageIndex = 3;
            //collection[1, 0] = "B1";

            int left = Pepsi.checkLeft;

            if (left == 0)
            {
                btnPepsi.Enabled = false;
                totalPrice.total = 1.00;
                lblProfit.Text = "$" + totalPrice.getPrice;
            }
            else
            {
                Pepsi.RemoveStock();
                totalPrice.total = 1.00;
                lblProfit.Text = "$" + totalPrice.getPrice;
            }
        }

        private void btnCoke_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            lblResult.ImageIndex = 1;
            //collection[1, 1] = "B2";

            int left = Coke.checkLeft;

            if (left == 0)
            {
                btnCoke.Enabled = false;
                totalPrice.total = 1.00;
                lblProfit.Text = "$" + totalPrice.getPrice;
            }
            else
            {
                Coke.RemoveStock();
                totalPrice.total = 1.00;
                lblProfit.Text = "$" + totalPrice.getPrice;
            }
        }

        private void btnFanta_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            lblResult.ImageIndex = 8;
            //collection[1, 2] = "B3";

            int left = Fanta.checkLeft;

            if (left == 0)
            {
                btnFanta.Enabled = false;
                totalPrice.total = 0.75;
                lblProfit.Text = "$" + totalPrice.getPrice;
            }
            else
            {
                Fanta.RemoveStock();
                totalPrice.total = 0.75;
                lblProfit.Text = "$" + totalPrice.getPrice;
            }
        }

        private void btnSprite_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            lblResult.ImageIndex = 4;
            //collection[2, 0] = "C1";

            int left = Sprite.checkLeft;

            if (left == 0)
            {
                btnSprite.Enabled = false;
                totalPrice.total = 1.25;
                lblProfit.Text = "$" + totalPrice.getPrice;
            }
            else
            {
                Sprite.RemoveStock();
                totalPrice.total = 1.25;
                lblProfit.Text = "$" + totalPrice.getPrice;
            }
        }

        private void btnMountainDew_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            lblResult.ImageIndex = 11;
            //collection[2, 1] = "C2";

            int left = MDew.checkLeft;

            if (left == 0)
            {
                btnMountainDew.Enabled = false;
                totalPrice.total = 1.50;
                lblProfit.Text = "$" + totalPrice.getPrice;
            }
            else
            {
                MDew.RemoveStock();
                totalPrice.total = 1.50;
                lblProfit.Text = "$" + totalPrice.getPrice;
            }
        }

        private void btnRootbeer_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            lblResult.ImageIndex = 5;
            //collection[2, 2] = "C3";

            int left = Rbeer.checkLeft;

            if (left == 0)
            {
                btnRootbeer.Enabled = false;
                totalPrice.total = 2.00;
                lblProfit.Text = "$" + totalPrice.getPrice;
            }
            else
            {
                Rbeer.RemoveStock();
                totalPrice.total = 2.00;
                lblProfit.Text = "$" + totalPrice.getPrice;
            }
        }

        private void btnMilk_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            lblResult.ImageIndex = 2;
            //collection[3, 0] = "D1";

            int left = Milk.checkLeft;

            if (left == 0)
            {
                btnMilk.Enabled = false;
                totalPrice.total = 3.00;
                lblProfit.Text = "$" + totalPrice.getPrice;
            }
            else
            {
                Milk.RemoveStock();
                totalPrice.total = 3.00;
                lblProfit.Text = "$" + totalPrice.getPrice;
            }
        }

        private void BtnCMilk_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            lblResult.ImageIndex = 12;
            //collection[3, 1] = "D2";

            int left = CMilk.checkLeft;

            if (left == 0)
            {
                BtnCMilk.Enabled = false;
                totalPrice.total = 3.25;
                lblProfit.Text = "$" + totalPrice.getPrice;
            }
            else
            {
                CMilk.RemoveStock();
                totalPrice.total = 3.25;
                lblProfit.Text = "$" + totalPrice.getPrice;
            }
        }

        private void btnDrPepper_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            lblResult.ImageIndex = 6;
            //collection[3, 2] = "D3";

            int left = DrPepper.checkLeft;

            if (left == 0)
            {
                btnDrPepper.Enabled = false;
                totalPrice.total = 1.25;
                lblProfit.Text = "$" + totalPrice.getPrice;
            }
            else
            {
                DrPepper.RemoveStock();
                totalPrice.total = 1.25;
                lblProfit.Text = "$" + totalPrice.getPrice;
            }
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            lblTime.Text = datetime.ToString();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Transaction A1 = new Transaction();
            VendingMachine F1 = new VendingMachine();

            F1.Hide();
            A1.Show();
        }

        private void lblProfit_Click(object sender, EventArgs e)
        {
            lblProfit.Text = "$"+totalPrice.getPrice;
        }


    }
}
