using System;
using System.Windows.Forms;

namespace AirlineManagementApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnManagePassengers_Click(object sender, EventArgs e)
        {
            // Create an instance of PassengerForm
            PassengerForm passengerForm = new PassengerForm();
            // Show it as a modal dialog (user must close it before returning to MainForm)
            passengerForm.ShowDialog();
        }

        private void btnManageFlights_Click(object sender, EventArgs e)
        {
            // Create an instance of FlightForm
            FlightForm flightForm = new FlightForm();
            // Show it as a modal dialog
            flightForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Ask for confirmation before exiting
            DialogResult confirmExit = MessageBox.Show("Are you sure you want to exit the application?",
                                                     "Confirm Exit",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            if (confirmExit == DialogResult.Yes)
            {
                Application.Exit(); // Closes the entire application
            }
        }

        private void btnFilterData_Click(object sender, EventArgs e)
        {
            FilteringForm filterForm = new FilteringForm();
            filterForm.ShowDialog(); // Or .Show()
        }

        private void btnViewPassengersByFlight_Click(object sender, EventArgs e)
        {
            ViewPassengersByFlightForm viewForm = new ViewPassengersByFlightForm();
            viewForm.ShowDialog(); // Or .Show()
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog(); // Show as a modal dialog
        }

        // We will add event handlers for other buttons (like Filtering) here later
    }
}
