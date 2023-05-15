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
    public partial class Orders : Form
    {
        decimal price = 0m;

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
        }

        private void pbAmericano_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
