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
    public partial class AddRemoveApptForm : Form
    {
        public AddRemoveApptForm()
        {
            InitializeComponent();
        }


        private List<Customers> customers = null!;
        private List<Appointments> appointments = null!;
        private List<Appointments> displayedAppointments = new List<Appointments>();

        private void AddRemoveApptForm_Load(object sender, EventArgs e)
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
            displayedAppointments.Clear();

            if (cboNameLookup.SelectedItem != null)
            {
                Customers selectedCustomer = (Customers)cboNameLookup.SelectedItem;

                foreach (Appointments a in appointments)
                {
                    if (a.CustomerName == selectedCustomer.FullName)
                    {
                        lstAppt.Items.Add(a.GetDisplayText());
                        displayedAppointments.Add(a);
                    }
                }
            }
        }

        private Appointments appointment = null!;

        public Appointments GetNewAppointment()
        {
            this.ShowDialog();
            return appointment;
        }

        private Appointments SaveAppointment()
        {
            appointment = new Appointments(txtProfessional.Text, txtService.Text, dateApptDate.Text, cboNameLookup.Text);
            return appointment;
        }

        

        private void btnAddAppt_Click(object sender, EventArgs e)
        {
            SaveAppointment();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveAppt_Click(object sender, EventArgs e)
        {

            int i = lstAppt.SelectedIndex;
            if (i != -1)
            {
                Appointments appointmenttoRemove = displayedAppointments[i];
                string message = $"Are you sure you want to delete {appointmenttoRemove.GetDisplayText()}?";
                DialogResult button = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    appointments.Remove(appointmenttoRemove);
                    ApptDB.SaveAppointments(appointments);
                    FillAppointmentsListBox();
                }
            }



        }

        private void cboNameLookup_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillAppointmentsListBox();
        }
    }
}
