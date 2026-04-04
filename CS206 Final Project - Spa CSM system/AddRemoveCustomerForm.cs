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

            txtAddCustomer.TextChanged += txtAddCustomer_TextChanged;
            txtRemoveCustomer.TextChanged += txtRemoveCustomer_TextChanged;
        }
        //add customer
        private List<string> customers = new List<string>();
        private Customers customer = null!;


        public Customers GetNewCustomer()
        {
            this.ShowDialog();
            return customer;
        }

        private Customers SaveCustomer()
        {
            customer = new Customers(txtName.Text, txtLastName.Text, txtEmail.Text, txtPhone.Text);
            return customer;
        }



        private void txtAddCustomer_TextChanged(object sender, EventArgs e)
        {
            string name = txtAddCustomer.Text.Trim();

            if (name.Length > 0)
            {
                customers.Add(name);
                lstCustomers.Items.Add(name);
                txtAddCustomer.Clear();
            }
        }

        private void txtRemoveCustomer_TextChanged(object sender, EventArgs e)
        {
            string name = txtRemoveCustomer.Text.Trim();

            if (customers.Contains(name))
            {
                customers.Remove(name);
                lstCustomers.Items.Remove(name);
                txtRemoveCustomer.Clear();
            }
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            SaveCustomer();
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
