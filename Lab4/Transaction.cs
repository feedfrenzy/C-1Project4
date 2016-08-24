using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Transaction : Form
    {
        

        public Transaction()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            lblATime.Text = time.ToString();
        }


        private void btnRWater_Click(object sender, EventArgs e)
        {
            ListViewItem water = new ListViewItem("Water Restocked");
            water.SubItems.Add(lblATime.Text);
            listView1.Items.Add(water);
            ProductInventory water1 = new ProductInventory();

        }

        private void BtnRPepsi_Click(object sender, EventArgs e)
        {
            ListViewItem pepsi = new ListViewItem("Pepsi Restocked");
            pepsi.SubItems.Add(lblATime.Text);
            listView1.Items.Add(pepsi);
            ProductInventory Pepsi = new ProductInventory();
        }

        private void btnSprite_Click(object sender, EventArgs e)
        {
            ListViewItem sprite = new ListViewItem("Sprite Restocked");
            sprite.SubItems.Add(lblATime.Text);
            listView1.Items.Add(sprite);
            ProductInventory Sprite = new ProductInventory();
        }

        private void btnMilk_Click(object sender, EventArgs e)
        {
            ListViewItem milk = new ListViewItem("Milk Restocked");
            milk.SubItems.Add(lblATime.Text);
            listView1.Items.Add(milk);
            ProductInventory Milk = new ProductInventory();
        }

        private void btnROJuice_Click(object sender, EventArgs e)
        {
            ListViewItem ojuice = new ListViewItem("OJuice Restocked");
            ojuice.SubItems.Add(lblATime.Text);
            listView1.Items.Add(ojuice);
            ProductInventory OJuice = new ProductInventory();
        }

        private void BtnRCoke_Click(object sender, EventArgs e)
        {
            ListViewItem coke = new ListViewItem("Coke Restocked");
            coke.SubItems.Add(lblATime.Text);
            listView1.Items.Add(coke);
            ProductInventory Coke = new ProductInventory();
        }

        private void BtnMDew_Click(object sender, EventArgs e)
        {
            ListViewItem mdew = new ListViewItem("Mountain Dew Restocked");
            mdew.SubItems.Add(lblATime.Text);
            listView1.Items.Add(mdew);
            ProductInventory MDew = new ProductInventory();
        }

        private void btnCMilk_Click(object sender, EventArgs e)
        {
            ListViewItem cmilk = new ListViewItem("Chocolate Restocked");
            cmilk.SubItems.Add(lblATime.Text);
            listView1.Items.Add(cmilk);
            ProductInventory CMilk = new ProductInventory();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListViewItem redbull = new ListViewItem("Red Bull Restocked");
            redbull.SubItems.Add(lblATime.Text);
            listView1.Items.Add(redbull);
            ProductInventory Redbull = new ProductInventory();
        }

        private void btnFanta_Click(object sender, EventArgs e)
        {
            ListViewItem fanta = new ListViewItem("Fanta Restocked");
            fanta.SubItems.Add(lblATime.Text);
            listView1.Items.Add(fanta);
            ProductInventory Fanta = new ProductInventory();
        }

        private void btnRRBeer_Click(object sender, EventArgs e)
        {
            ListViewItem rbeer = new ListViewItem("Root Beer Restocked");
            rbeer.SubItems.Add(lblATime.Text);
            listView1.Items.Add(rbeer);
            ProductInventory RBeer = new ProductInventory();
        }

        private void btnPepper_Click(object sender, EventArgs e)
        {
            ListViewItem pepper = new ListViewItem("Dr.Pepper Restocked");
            pepper.SubItems.Add(lblATime.Text);
            listView1.Items.Add(pepper);
            ProductInventory Pepper = new ProductInventory();
        }

        private void btnReverything_Click(object sender, EventArgs e)
        {
            ListViewItem everything = new ListViewItem("Everything Restocked");
            everything.SubItems.Add(lblATime.Text);
            listView1.Items.Add(everything);
            ProductInventory Everthing = new ProductInventory();
        }

        private void lblProfit_Click(object sender, EventArgs e)
        {

        }



    }
}
