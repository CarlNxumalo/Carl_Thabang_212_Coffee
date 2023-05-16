using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carl_Thabang_212_Coffee
{
    public partial class Receipt : Form
    {
        
        public Receipt()
        {
            InitializeComponent();
        }

        private void display()
        {
            Orders fromOrder = new Orders();

            if (fromOrder.conn.State == ConnectionState.Closed)
            {
                fromOrder.conn.Open();
            }

            string sql = "SELECt * FROM Orders";

            fromOrder.comm = new System.Data.SqlClient.SqlCommand(sql, fromOrder.conn);
            fromOrder.adap = new System.Data.SqlClient.SqlDataAdapter();
            fromOrder.ds = new DataSet();

            fromOrder.adap.SelectCommand = fromOrder.comm;

            fromOrder.adap.Fill(fromOrder.ds, "Orders");

            dataGridView1.DataSource = fromOrder.ds;
            dataGridView1.DataMember = "Orders";

            fromOrder.conn.Close();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            display();
        }
    }
}
