using System;
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
        public SqlDataAdapter adap;
        public SqlCommand comm;
        public SqlConnection conn;
        public SqlDataReader dataReader;
        public DataSet ds;
        public string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THABANG\source\repos\New folder\BeetleCafDB.mdf;Integrated Security=True";
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
            conn = new SqlConnection(conStr);

            conn.Open();
            conn.Close();
            btnPrevious.Enabled = false;
            lstOrders.Items.Add("\t\tORDERS");
            lstOrders.Items.Add("=================================");
        }

        private void cart(string item,decimal price)
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            

            lstOrders.Items.Add(item + "\t" + price.ToString("C"));
            totalPrice += price;

            string sql = $"INSERT INTO Orders(Item,Price) VALUES('{item}','{price}')";

            comm = new SqlCommand(sql, conn);

            adap = new SqlDataAdapter();

            adap.InsertCommand = comm;
            adap.InsertCommand.ExecuteNonQuery();

            conn.Close();
       
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

        private void pbDanish_Click(object sender, EventArgs e)
        {
            cart("Apricot Danish", 31m);
        }

        private void pbBaklava_Click(object sender, EventArgs e)
        {
            cart("Peppermint Tea", 26.45m);
        }
    }
}
