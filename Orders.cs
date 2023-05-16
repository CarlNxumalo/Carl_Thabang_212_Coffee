﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Carl_Thabang_212_Coffee
{
    public partial class Orders : Form
    {
        SqlDataAdapter adap;
        SqlCommand comm;
        SqlConnection conn;
        SqlDataReader dataReader;
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THABANG\source\repos\New folder\BeetleCafDB.mdf;Integrated Security=True";
        decimal totalPrice = 0m;
        

        public Orders()
        {
            InitializeComponent();

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
           if(tabControl1.SelectedIndex != 0)
            {
                tabControl1.TabIndex--;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex != tabControl1.TabIndex-1)
            {
                tabControl1.TabIndex++;
            }

            btnPrevious.Enabled = true;
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            btnPrevious.Enabled = false;
            lstOrders.Items.Add("\t\tORDERS");
            lstOrders.Items.Add("=================================");
        }

        private void cart(string item,decimal price)
        {
            lstOrders.Items.Add(item + "\t" + price.ToString("C"));
            totalPrice += price;
            

        }

        private void pbAmericano_Click(object sender, EventArgs e)
        {
            cart("Americano",30.90m);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstOrders.Items.RemoveAt(lstOrders.SelectedIndex);
        }

        private void pbIcedCoffee_Click(object sender, EventArgs e)
        {
            cart("Iced Coffee", 28.99m);
        }

        private void pbDripCoffee_Click(object sender, EventArgs e)
        {
            cart("Drip Coffee", 31.21m);
        }

        private void pbIrishCoffee_Click(object sender, EventArgs e)
        {
            cart("Irish Coffee", 31.21m);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cart("Cuppacino", 34.5m);
        }

        private void pbBlackTea_Click(object sender, EventArgs e)
        {
            cart("Black Tea", 15.98m);
        }

        private void pbYellowTea_Click(object sender, EventArgs e)
        {
            cart("Yellow Tea", 18.75m);
        }

        private void pbGreenTea_Click(object sender, EventArgs e)
        {
            cart("Green Tea", 22.98m);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cart("Peppermint Tea", 27m);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(lstOrders.Items.Count==0)
            {
                lblChange.ForeColor = Color.Red;
                lblChange.Text = "No item in Cart!";
            }
            else
            {
                Receipt finalRec = new Receipt();
                finalRec.ShowDialog();

                //string sql = $"INSERT INTO Orders(Item,Price) VALUES('{}')"

            }
        }

        private void pbCroissant_Click(object sender, EventArgs e)
        {
            cart("Croissant", 27m);
        }

        private void pbCannoli_Click(object sender, EventArgs e)
        {
            cart("Cannoli", 24m);
        }

        private void pbChoco_Click(object sender, EventArgs e)
        {
            cart("Chocolate Tarts", 30.50m);
        }

        
    }
}
