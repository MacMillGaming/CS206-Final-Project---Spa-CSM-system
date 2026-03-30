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
            FillAppointmentsListBox();

        }

        private void FillAppointmentsListBox()
        {
            lstAppt.Items.Clear();
            foreach (Appointments a in appointments)
            {
                lstAppt.Items.Add(a.GetDisplayText());
            }
        }

        private void btnAddRemoveCust_Click(object sender, EventArgs e)
        {

           

        }

        private void btnAddRemoveAppt_Click(object sender, EventArgs e)
        {
            AddRemoveApptForm addRemoveApptForm = new();
            Appointments appointment = addRemoveApptForm.GetNewAppointment(); //Add this method in Add/Remove Customer Form
            if (appointment != null)
            {
                appointments.Add(appointment);
                ApptDB.SaveAppointments(appointments);
                FillAppointmentsListBox();
            }

        }

        private void btnViewSummaries_Click(object sender, EventArgs e)
        {

            ApptSummaryForm apptSummaryForm = new();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
