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

        private List<Customers> allCustomers = new List<Customers>();
        private Customers customer = null!;

        public AddRemoveCustomerForm()
        {
            InitializeComponent();

            allCustomers = CustomerDB.GetCustomers();
            cboCustomer.DisplayMember = "FullName";
            cboCustomer.DataSource = allCustomers;
        }



        private void AddRemoveCustomer_Load(object sender, EventArgs e)
        {
            allCustomers = CustomerDB.GetCustomers();

            cboCustomer.DataSource = null;
            cboCustomer.DisplayMember = "FullName";
            cboCustomer.DataSource = allCustomers;
        }


        //add customer




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
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter a First and Last name before saving.", "Missing Info");
                return;
            }

            SaveCustomer();

            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            customer = null!;
            this.Close();
        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            int i = cboCustomer.SelectedIndex;
            if (i != -1)
            {
                Customers customertoRemove = allCustomers[i];
                string message = $"Are you sure you want to delete {customertoRemove.FullName}?";
                DialogResult button = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo);

                if (button == DialogResult.Yes)
                {
                    // 1. UNBIND FIRST so the ComboBox lets go of our list
                    cboCustomer.DataSource = null;

                    // 2. GUARANTEED DELETE: Remove the exact index rather than guessing the object
                    allCustomers.RemoveAt(i);

                    // 3. Save the new, shorter list
                    CustomerDB.SaveCustomers(allCustomers);

                    // 4. REBIND properly with the DisplayMember
                    cboCustomer.DisplayMember = "FullName"; // Do not forget this!
                    cboCustomer.DataSource = allCustomers;

                    if (cboCustomer.Items.Count > 0)
                    {
                        cboCustomer.SelectedIndex = 0;
                    }
                    else
                    {
                        cboCustomer.Text = "";
                    }

                    // Optional: Pop up a quick success message so you know it worked!
                    MessageBox.Show("Customer successfully deleted.", "Success");
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
