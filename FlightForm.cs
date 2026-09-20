using System;
using System.Data.Entity; // For EF6 features
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AirlineManagementApp.Models; // To access Flight class

namespace AirlineManagementApp
{
    public partial class FlightForm : Form
    {
        private int _editingFlightId = -1; // -1 means Add mode

        public FlightForm()
        {
            InitializeComponent();
        }

        // --- FORM LOAD EVENT ---
        private void FlightForm_Load(object sender, EventArgs e)
        {
            LoadFlightsIntoGrid();
            ClearFormFields(); // Set initial state
        }

        // --- HELPER METHODS ---
        private void LoadFlightsIntoGrid()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var flights = context.Flights
                                         .Select(f => new
                                         {
                                             f.FlightId,
                                             f.FlightNumber,
                                             f.OriginCity,
                                             f.DestinationCity,
                                             f.DepartureDateTime,
                                             f.Airline
                                         })
                                         .ToList();
                    dgvFlights.DataSource = null;
                    dgvFlights.DataSource = flights;
                    AdjustDataGridViewColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading flights: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdjustDataGridViewColumns()
        {
            if (dgvFlights.Columns["FlightId"] != null)
                dgvFlights.Columns["FlightId"].Visible = false; // Hide ID

            if (dgvFlights.Columns["DepartureDateTime"] != null)
            {
                dgvFlights.Columns["DepartureDateTime"].HeaderText = "Departure Time";
                // Optional: Format the date/time column if needed, though it usually displays fine
                dgvFlights.Columns["DepartureDateTime"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
            if (dgvFlights.Columns["FlightNumber"] != null)
                dgvFlights.Columns["FlightNumber"].HeaderText = "Flight No.";
            if (dgvFlights.Columns["OriginCity"] != null)
                dgvFlights.Columns["OriginCity"].HeaderText = "Origin";
            if (dgvFlights.Columns["DestinationCity"] != null)
                dgvFlights.Columns["DestinationCity"].HeaderText = "Destination";
        }

        private void ClearFormFields()
        {
            txtFlightNumber.Clear();
            txtOriginCity.Clear();
            txtDestinationCity.Clear();
            dtpDeparture.Value = DateTime.Now; // Reset to current time
            txtAirline.Clear();

            _editingFlightId = -1; // Reset to Add mode
            btnAddUpdateFlight.Text = "Add Flight"; // Reset button text
            txtFlightNumber.Focus();
        }

        private void txtLettersAndSpaces_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow letters, spaces, and control characters (like backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Block the character
            }
        }

        // General purpose KeyPress event handler for TextBoxes that allow letters, numbers, spaces, and hyphens
        private void txtAlphaNumericSpacesHyphens_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow letters, digits, spaces, hyphens, and control characters (like backspace)
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; // Block the character
            }
        }

        private bool ValidateInputs()
        {
            // 1. Validate Flight Number: Required. Can be alphanumeric.
            // You might add a regex if there's a very specific format, e.g., 2 letters followed by 3-4 numbers.
            // Example: string flightNumPattern = @"^[A-Z]{2}\d{3,4}$"; (for AA123 or BA1234)
            if (string.IsNullOrWhiteSpace(txtFlightNumber.Text))
            {
                MessageBox.Show("Flight Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFlightNumber.Focus();
                return false;
            }
            // Optional: Add a regex for flight number format if needed
            // if (!Regex.IsMatch(txtFlightNumber.Text.Trim(), @"^[A-Za-z0-9\-]+$")) // Allows alphanumeric and hyphen
            // {
            //     MessageBox.Show("Flight Number can only contain letters, numbers, and hyphens.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //     txtFlightNumber.Focus();
            //     return false;
            // }


            // 2. Validate Origin City: Required, letters and spaces only.
            if (string.IsNullOrWhiteSpace(txtOriginCity.Text))
            {
                MessageBox.Show("Origin City is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOriginCity.Focus();
                return false;
            }
            if (!Regex.IsMatch(txtOriginCity.Text.Trim(), @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Origin City can only contain letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOriginCity.Focus();
                return false;
            }

            // 3. Validate Destination City: Required, letters and spaces only.
            if (string.IsNullOrWhiteSpace(txtDestinationCity.Text))
            {
                MessageBox.Show("Destination City is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDestinationCity.Focus();
                return false;
            }
            if (!Regex.IsMatch(txtDestinationCity.Text.Trim(), @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Destination City can only contain letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDestinationCity.Focus();
                return false;
            }

            // 4. Check Origin and Destination are not the same
            if (txtOriginCity.Text.Trim().Equals(txtDestinationCity.Text.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Origin and Destination city cannot be the same.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOriginCity.Focus(); // Or txtDestinationCity
                return false;
            }

            // 5. Validate Departure DateTime: Optional - ensure it's not in the past.
            if (dtpDeparture.Value < DateTime.Now.Date) // Comparing only date part, or DateTime.Now for exact time
            {
                MessageBox.Show("Departure date cannot be in the past.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDeparture.Focus();
                return false;
            }

            // 6. Validate Airline: Optional field, but if provided, letters, numbers, and spaces.
            if (string.IsNullOrWhiteSpace(txtAirline.Text)) // Check if it's empty
            {
                MessageBox.Show("Airline is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAirline.Focus();
                return false;
            }
            // Then, validate the format if it's not empty
            if (!Regex.IsMatch(txtAirline.Text.Trim(), @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("Airline can only contain letters, numbers, and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAirline.Focus();
                return false;
            }

            return true; // All validations passed
        }

        // --- BUTTON CLICK EVENTS ---
        private void btnAddUpdateFlight_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            try
            {
                using (var context = new ApplicationDbContext())
                {
                    Flight flight;
                    string successMessage;

                    if (_editingFlightId == -1) // Add mode
                    {
                        flight = new Flight();
                        context.Flights.Add(flight);
                        successMessage = "Flight added successfully!";
                    }
                    else // Update mode
                    {
                        flight = context.Flights.Find(_editingFlightId);
                        if (flight == null)
                        {
                            MessageBox.Show("Flight not found for update. Please refresh.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearFormFields();
                            LoadFlightsIntoGrid();
                            return;
                        }
                        successMessage = "Flight updated successfully!";
                    }

                    flight.FlightNumber = txtFlightNumber.Text.Trim();
                    flight.OriginCity = txtOriginCity.Text.Trim();
                    flight.DestinationCity = txtDestinationCity.Text.Trim();
                    flight.DepartureDateTime = dtpDeparture.Value;
                    flight.Airline = txtAirline.Text.Trim();

                    context.SaveChanges();
                    MessageBox.Show(successMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadFlightsIntoGrid();
                ClearFormFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving flight: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            if (dgvFlights.CurrentRow == null)
            {
                MessageBox.Show("Please select a flight to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int flightId = (int)dgvFlights.CurrentRow.Cells["FlightId"].Value;

            // Check if any passengers are assigned to this flight
            using (var context = new ApplicationDbContext())
            {
                bool hasPassengers = context.Passengers.Any(p => p.FlightId == flightId);
                if (hasPassengers)
                {
                    MessageBox.Show("Cannot delete this flight because passengers are assigned to it. Please re-assign or delete those passengers first.", "Deletion Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            var confirmResult = MessageBox.Show("Are you sure you want to delete this flight?",
                                         "Confirm Delete",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (var context = new ApplicationDbContext())
                    {
                        var flight = context.Flights.Find(flightId);
                        if (flight != null)
                        {
                            context.Flights.Remove(flight);
                            context.SaveChanges();
                            MessageBox.Show("Flight deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Flight not found or already deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    LoadFlightsIntoGrid();
                    ClearFormFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting flight: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClearFlight_Click(object sender, EventArgs e)
        {
            ClearFormFields();
        }

        // --- DATAGRIDVIEW EVENT for selecting a flight to edit ---
        // ... inside the FlightForm class ...

        private void dgvFlights_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFlights.CurrentRow != null && dgvFlights.CurrentRow.Cells["FlightId"].Value != null)
            {
                try
                {
                    // Get the ID of the selected flight
                    _editingFlightId = (int)dgvFlights.CurrentRow.Cells["FlightId"].Value;

                    // Populate the input fields with the data from the selected row
                    // These cell names must match the property names from the anonymous type
                    // used to populate the dgvFlights in LoadFlightsIntoGrid()
                    txtFlightNumber.Text = dgvFlights.CurrentRow.Cells["FlightNumber"].Value.ToString();
                    txtOriginCity.Text = dgvFlights.CurrentRow.Cells["OriginCity"].Value.ToString();
                    txtDestinationCity.Text = dgvFlights.CurrentRow.Cells["DestinationCity"].Value.ToString();

                    // Safely handle DateTime conversion for the DateTimePicker
                    if (dgvFlights.CurrentRow.Cells["DepartureDateTime"].Value is DateTime)
                    {
                        dtpDeparture.Value = (DateTime)dgvFlights.CurrentRow.Cells["DepartureDateTime"].Value;
                    }

                    txtAirline.Text = dgvFlights.CurrentRow.Cells["Airline"].Value?.ToString() ?? ""; // Handle possible null for Airline

                    // Change the "Add Flight" button's text to "Update Flight" to indicate edit mode
                    btnAddUpdateFlight.Text = "Update Flight";
                }
                catch (Exception ex)
                {
                    // This can happen if, for example, a cell value is unexpectedly null and .ToString() is called
                    // or if data is being cleared and the CurrentRow becomes invalid.
                    Console.WriteLine("Error in dgvFlights_SelectionChanged: " + ex.Message);
                    // Optionally, reset to a known state or just log the error
                    ClearFormFields(); // Good idea to reset to "Add" mode if an error occurs here
                }
            }
            else
            {
                // If no row is selected or data is invalid, reset to "Add" mode
                // This can happen if the grid is cleared or loses selection
                // ClearFormFields(); // Uncomment if you want the form to reset when selection is lost
            }
        }
        // General purpose KeyPress event handler for TextBoxes that should only allow letters and spaces

    }
}
