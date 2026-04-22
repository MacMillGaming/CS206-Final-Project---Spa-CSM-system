using CS206_Final_Project___Spa_CSM_system;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace CS206_Final_Project___Spa_CSM_system
{
    public partial class ApptSummaryForm : Form
    {
        public ApptSummaryForm()
        {
            InitializeComponent();
            LoadServices(); // Fills the service dropdown with data
                            // Attach event handlers so validation runs when user changes dates
            dateStartDate.ValueChanged += dateStartDate_ValueChanged; // Start date changed
            dateEndDate.ValueChanged += dateEndDate_ValueChanged; // End date changed
        }
        private void ApptSummaryForm_Load(object sender, EventArgs e) // Runs when formloads
{
dateStartDate.Value = DateTime.Today; // Set start date to today's date
dateEndDate.Value = DateTime.Today; // Set end date to today's date
}
private void LoadServices() // Method to load services into combo box
        {
            cboService.Items.Clear(); // Remove any existing items
            cboService.Items.Add("All"); // Add option to show all services
            foreach (var service in Services.GetAllServices()) // Loop through services fromdatabase
{
                cboService.Items.Add(service.Name); // Add each service name to dropdown
            }
            cboService.SelectedIndex = 0; // Select first item "All" by default
        }
        private void dateStartDate_ValueChanged(object sender, EventArgs e) // Runs when start date changes
        {
if (dateStartDate.Value > dateEndDate.Value) // If start date is later than end date
{
                dateEndDate.Value = dateStartDate.Value; // Fix by moving end date forward
            }
        }
        private void dateEndDate_ValueChanged(object sender, EventArgs e) // Runs when end date changes
        {
if (dateEndDate.Value < dateStartDate.Value) // If end date is earlier than start date
{
                dateStartDate.Value = dateEndDate.Value; // Fix by moving start date back
            }
        }
        private void btnRun_Click(object sender, EventArgs e) // runs when user clicks the Run button
{
            if (dateStartDate.Value.Date > dateEndDate.Value.Date)
            {
                MessageBox.Show("Start date cannot be after end date.", "Entry Error");
                return;
            }
            listBox1.Items.Clear(); // clears previous results so new search starts fresh
DateTime startDate = dateStartDate.Value.Date; // gets start date (removes time part)
    DateTime endDate = dateEndDate.Value.Date; // gets end date (removes time part)
if (startDate > endDate) // Checks if user selected invalid date range
{
MessageBox.Show("Start date cannot be after end date."); // Shows error message
return; // Stops method from continuing
}
string selectedService = cboService.SelectedItem?.ToString() ?? "All";
// Gets selected service from dropdown
// If nothing selected, defaults to "All"
var appointments = ApptDB.GetAppointments();
// loads all appointments from database
var filtered = appointments.Where(a =>
{
    DateTime parsedDate; // temporary variable to hold converted date
    bool valid = DateTime.TryParse(a.DateTime, out parsedDate);
    // Converts string date → DateTime safely (prevents crash)
    return valid && parsedDate >= startDate && parsedDate <= endDate;
    // Keeps only valid dates inside selected range
});
if (selectedService != "All") // Checks if user wants a specific service
{
    filtered = filtered.Where(a => a.Service == selectedService);
    // Filters appointments by service name
}
var result = filtered
.OrderBy(a => DateTime.Parse(a.DateTime))
// Sorts appointments by date (earliest → latest)
.ToList();
// Converts result to a list so we can use Count and loop it
listBox1.Items.Add("Date Customer Name Service");
// Adds column header for display
listBox1.Items.Add("----------------------------------------");
// Adds separator line to look presenmtable
if (result.Count == 0) // Checks if no appointments matched filters
{
    listBox1.Items.Add("No appointments found."); // Shows message
    return; // Stops method
}
foreach (var appt in result) // Loops through each appointment
{
    DateTime parsedDate = DateTime.Parse(appt.DateTime);
    // Converts string date into DateTime for formatting
    listBox1.Items.Add(
    $"{parsedDate.ToShortDateString(),-12} " +
    // Displays date in short format, left-aligned
    $"{appt.CustomerName,-20} " +
    // Displays customer name, left-aligned
    $"{appt.Service,-15}"
    // Displays service name, left-aligned
    );
}
listBox1.Items.Add("----------------------------------------");
// Adds bottom separator
listBox1.Items.Add($"Total Appointments: {result.Count}");
// Shows total number of results
}
private void btnCancel_Click(object sender, EventArgs e) // Runs when Cancel button is clicked
{
this.Close(); // Closes the form window
}
}
}
