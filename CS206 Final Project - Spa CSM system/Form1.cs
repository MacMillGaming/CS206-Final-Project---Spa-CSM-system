namespace CS206_Final_Project___Spa_CSM_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Customers> customers = null!;
        private List<Appointments> appointments = null!;

        private void form1_Load(object sender, EventArgs e)
        {
            customers = CustomerDB.GetCustomers();
            appointments = ApptDB.GetAppointments();

            cboNameLookup.DataSource = customers;
            cboNameLookup.DisplayMember = "FullName";

            FillAppointmentsListBox();

        }

        private void FillAppointmentsListBox()
        {
            lstAppt.Items.Clear();

            if (cboNameLookup.SelectedItem != null)
            {
                Customers selectedCustomer = (Customers)cboNameLookup.SelectedItem;

                foreach (Appointments a in appointments)
                {
                    if (a.CustomerName == selectedCustomer.FullName)
                    {
                        lstAppt.Items.Add(a.GetDisplayText());
                    }
                }
            }
        }

        private void btnAddRemoveCust_Click(object sender, EventArgs e)
        {
            AddRemoveCustomerForm addRemoveCustForm = new();
            Customers customer = addRemoveCustForm.GetNewCustomer(); 

            if (customer != null)
            {
                
               if (customers == null)
               {
                  customers = new List<Customers>();
               }

               customers.Add(customer);
               CustomerDB.SaveCustomers(customers);             
                              
               MessageBox.Show("Customer Saved");                             
                
            }

            customers = CustomerDB.GetCustomers();

            cboNameLookup.DataSource = null;
            cboNameLookup.DisplayMember = "FullName";
            cboNameLookup.DataSource = customers;            

            FillAppointmentsListBox();

        }

        private void btnAddRemoveAppt_Click(object sender, EventArgs e)
        {
            AddRemoveApptForm addRemoveApptForm = new();
            Appointments appointment = addRemoveApptForm.GetNewAppointment(); 
            if (appointment != null)
            {

                appointments.Add(appointment);
                ApptDB.SaveAppointments(appointments);
                MessageBox.Show("Appointment Saved");
            }

            appointments = ApptDB.GetAppointments();
            FillAppointmentsListBox();

        }

        private void btnViewSummaries_Click(object sender, EventArgs e)
        {

            ApptSummaryForm apptSummaryForm = new();
            apptSummaryForm.ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboNameLookup_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillAppointmentsListBox();
        }
    }
}
