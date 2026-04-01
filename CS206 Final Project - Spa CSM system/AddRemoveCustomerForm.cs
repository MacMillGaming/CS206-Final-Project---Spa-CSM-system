using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS206_Final_Project___Spa_CSM_system
{
    public partial class AddRemoveCustomerForm : Form
    {
        public AddRemoveCustomerForm()
        {
            InitializeComponent();
        }
        //add customer
        private List<string> customers = new List<string>();

        public AddRemoveCustomerForm()
        {
            InitializeComponent();

            txtAddCustomer.TextChanged += txtAddCustomer_TextChanged;
            txtRemoveCustomer.TextChanged += txtRemoveCustomer_TextChanged;
        }

        private void txtAddCustomer_TextChanged(object sender, EventArgs e)
        {
            string name = txtAddCustomer.Text.Trim();

            if (name.Length > 0)
            {
                customers.Add(name);
                customersList.Items.Add(name);
                txtAddCustomer.Clear();
            }
        }

        private void txtRemoveCustomer_TextChanged(object sender, EventArgs e)
        {
            string name = txtRemoveCustomer.Text.Trim();

            if (customers.Contains(name))
            {
                customers.Remove(name);
                customersList.Items.Remove(name);
                txtRemoveCustomer.Clear();
            }
        }
    }
}
