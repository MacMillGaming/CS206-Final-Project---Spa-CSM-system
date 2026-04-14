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

        // These lists hold all loaded data for the current session.
        // null! tells the compiler "I know this is null now but I'll assign it before using it"
        // — the assignment happens in AddRemoveApptForm_Load, which runs before any button click.
        private List<Customers> customers = null!;
        private List<Appointments> appointments = null!;
        private List<Appointments> displayedAppointments = new List<Appointments>();

        // ── Form Load ─────────────────────────────────────────────────────────
        // Runs once automatically the moment the form is displayed.
        private void AddRemoveApptForm_Load(object sender, EventArgs e)
        {
            // Read customers and appointments from the text files on disk.
            customers = CustomerDB.GetCustomers();
            appointments = ApptDB.GetAppointments();

            // Bind the customer list to the combo box.
            // DataSource links the combo box to the list so that selecting an item
            // gives us the actual Customers object, not just a string.
            // DisplayMember tells the combo box which property text to show ("Jane Doe").
            cboNameLookup.DataSource = customers;
            cboNameLookup.DisplayMember = "FullName";

            // ── Populate the Service combo box from the Services class ─────────
            // Services.GetAllServices() returns the master catalog (List<Services>).
            // We set DataSource directly so each item IS a Services object.
            // DisplayMember = "Name" means the combo shows "Swedish Massage" etc.
            // When the user picks one, cboService.SelectedItem is a Services object
            // and we can read .Name, .Category, .Price, .DurationMinutes off it.
            cboService.DataSource = Services.GetAllServices();
            cboService.DisplayMember = "Name";

            // Set date picker to show tomorrow at 9 AM as a sensible default.
            dateApptDate.Value = DateTime.Today.AddDays(1).Date.AddHours(9);

            // Show the appointments for whichever customer is selected by default.
            FillAppointmentsListBox();
        }

        // ── FillAppointmentsListBox ───────────────────────────────────────────
        // Clears the list and repopulates it with only the appointments
        // that belong to the currently selected customer.
        // Called on load, on customer change, and after add/remove operations.
        private void FillAppointmentsListBox()
        {
            lstAppt.Items.Clear();
            displayedAppointments.Clear();

            if (cboNameLookup.SelectedItem != null)
            {
                // Cast SelectedItem from object to Customers so we can read .FullName.
                Customers selectedCustomer = (Customers)cboNameLookup.SelectedItem;

                // Loop through every appointment and only show the ones for this customer.
                foreach (Appointments a in appointments)
                {
                    if (a.CustomerName == selectedCustomer.FullName)
                    {
                        lstAppt.Items.Add(a.GetDisplayText());

                        // Also keep a parallel list of the actual Appointments objects
                        // so that when the user selects index 2 in the ListBox,
                        // we can instantly find displayedAppointments[2] to delete it.
                        displayedAppointments.Add(a);
                    }
                }
            }
        }

        // Fires every time the user picks a different customer — refreshes the appointment list.
        private void cboNameLookup_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillAppointmentsListBox();
        }

        // ── GetNewAppointment / SaveAppointment ───────────────────────────────
        // These two methods are the bridge between this form and Form1.
        // Form1 calls GetNewAppointment(), which opens this form as a dialog.
        // When the user clicks Add Appointment the form closes,
        // and GetNewAppointment() returns the saved appointment object back to Form1.
        private Appointments appointment = null!;

        public Appointments GetNewAppointment()
        {
            this.ShowDialog();
            return appointment;
        }

        // SaveAppointment() reads the current values from all the controls and
        // packages them into a new Appointments object.
        // Note how it reads the Service NAME from the Services object in cboService —
        // that is the link between the Services class and the appointment record.
        private Appointments SaveAppointment()
        {
            // Read the selected Services object out of the combo box.
            // Casting with (Services) is safe here because DataSource is List<Services>.
            Services selectedService = (Services)cboService.SelectedItem;

            appointment = new Appointments(
                txtProfessional.Text,          // who performs the service
                selectedService.Name,          // service name from the Services object
                dateApptDate.Value.ToString("MM/dd/yyyy hh:mm tt"),  // formatted date/time
                cboNameLookup.Text             // customer full name
            );
            return appointment;
        }

        // ── Add Appointment button ────────────────────────────────────────────
        private void btnAddAppt_Click(object sender, EventArgs e)
        {
            // Validate required fields using the Validator class before doing anything.
            string errorMsg = "";
            errorMsg += Validator.IsPresent(txtProfessional.Text.Trim(), "Professional");

            // cboService always has a selection (it is pre-loaded), but guard anyway.
            if (cboService.SelectedItem == null)
                errorMsg += "Service is a required field.\n";

            if (errorMsg != "")
            {
                MessageBox.Show(errorMsg, "Entry Error");
                return;
            }

            // Build and persist the new appointment, then close.
            SaveAppointment();
            this.Close();
        }

        // ── Remove Appointment button ─────────────────────────────────────────
        private void btnRemoveAppt_Click(object sender, EventArgs e)
        {
            int i = lstAppt.SelectedIndex;

            // -1 means nothing is selected.
            if (i == -1)
            {
                MessageBox.Show("Please select an appointment to remove.", "No Selection");
                return;
            }

            // Use the parallel displayedAppointments list to find the actual object.
            Appointments appointmentToRemove = displayedAppointments[i];

            string message = $"Are you sure you want to delete:\n{appointmentToRemove.GetDisplayText()}?";
            DialogResult button = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo);

            if (button == DialogResult.Yes)
            {
                // Remove from the master list, write the updated list to disk, then refresh.
                appointments.Remove(appointmentToRemove);
                ApptDB.SaveAppointments(appointments);
                FillAppointmentsListBox();
            }
        }

        // ── Cancel button ─────────────────────────────────────────────────────
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
