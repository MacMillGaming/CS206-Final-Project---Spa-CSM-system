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

        private List<Customers> cboCustomer = null!;

        private void AddRemoveCustomer_Load(object sender, EventArgs e)
        {
            cboCustomer = CustomerDB.GetCustomers();

            cboNameLookup.DataSource = cboCustomer;
            cboNameLookup.DisplayMember = "FullName";

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




        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            SaveCustomer();
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {

            int i = cboNameLookup.SelectedIndex;
            if (i != -1)
            {
                Customers customertoRemove = cboCustomer[i];
                string message = $"Are you sure you want to delete {customertoRemove.FullName}?";
                DialogResult button = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    cboCustomer.Remove(customertoRemove);
                    CustomerDB.SaveCustomers(cboCustomer);

                    cboNameLookup.DataSource = null;
                    cboNameLookup.DataSource = cboCustomer.ToList();
                    if (cboNameLookup.Items.Count > 0)
                    {
                        cboNameLookup.SelectedIndex = 0;
                    }
                    else
                    {
                        cboNameLookup.Text = "";
                    }

                }

                
            }


        }















        //__________________________________________________________________







        private void txtAddCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRemoveCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        
    }
}
