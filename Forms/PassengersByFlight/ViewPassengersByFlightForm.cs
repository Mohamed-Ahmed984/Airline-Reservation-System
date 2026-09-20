using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace AirlineManagementApp
{
    public partial class ViewPassengersByFlightForm : Form
    {
        public ViewPassengersByFlightForm()
        {
            InitializeComponent();
        }

        private void ViewPassengersByFlightForm_Load(object sender, EventArgs e)
        {
            LoadFlights();
        }

        private void LoadFlights()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var flights = context.Flights
                        .OrderBy(f => f.DepartureDateTime)
                        .Select(f => new
                        {
                            f.FlightId,
                            DisplayText = f.FlightNumber + " — " + f.OriginCity + " to " + f.DestinationCity
                        })
                        .ToList();

                    cmbFlights.DisplayMember = "DisplayText";
                    cmbFlights.ValueMember = "FlightId";
                    cmbFlights.DataSource = flights;
                    cmbFlights.SelectedIndex = flights.Count > 0 ? 0 : -1;

                    if (flights.Count == 0)
                    {
                        dgvPassengers.DataSource = null;
                        lblPassengerCount.Text = "No flights are available.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading flights: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbFlights_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFlights.SelectedValue is int flightId)
            {
                LoadPassengers(flightId);
            }
        }

        private void LoadPassengers(int flightId)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var passengers = context.Passengers
                        .AsNoTracking()
                        .Where(p => p.FlightId == flightId)
                        .OrderBy(p => p.Name)
                        .Select(p => new
                        {
                            p.Name,
                            p.TripNO,
                            p.PhoneNum,
                            p.PassportNum,
                            p.Nationality
                        })
                        .ToList();

                    dgvPassengers.DataSource = passengers;
                    lblPassengerCount.Text = passengers.Count == 1
                        ? "1 passenger"
                        : passengers.Count + " passengers";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading passengers: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
