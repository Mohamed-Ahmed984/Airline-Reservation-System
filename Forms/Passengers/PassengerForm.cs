
using System;
using System.Data; // Not strictly needed for EF but often included
using System.Data.Entity; // For EF6 features like .Include()
using System.Linq;
using System.Windows.Forms;
using AirlineManagementApp.Models; // To access Passenger and Flight classes
using System.Text.RegularExpressions; // For phone number validation


namespace AirlineManagementApp
{
    public partial class PassengerForm : Form
    {
        // To store the ID of the passenger being edited. -1 means Add mode.
        private int _editingPassengerId = -1;

        public PassengerForm()
        {
            InitializeComponent();
        }

        // --- FORM LOAD EVENT ---
        private void PassengerForm_Load(object sender, EventArgs e)
        {
            LoadFlightsIntoComboBox();
            LoadPassengersIntoGrid();
            ClearFormFields(); // To set initial state (e.g., "Add" button text)
        }

        // --- HELPER METHODS ---
        private void LoadFlightsIntoComboBox()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var flights = context.Flights
                                         .Select(f => new { f.FlightId, DisplayText = f.FlightNumber + " (" + f.OriginCity + " to " + f.DestinationCity + ")" })
                                         .ToList();

                    cmbFlight.DataSource = null; // Clear existing
                    cmbFlight.DisplayMember = "DisplayText";
                    cmbFlight.ValueMember = "FlightId";
                    cmbFlight.DataSource = flights;
                    cmbFlight.SelectedIndex = -1; // No flight selected initially
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading flights: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPassengersIntoGrid()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    // Use .Include() to also load the related Flight information for display
                    var passengers = context.Passengers
                                            .Include(p => p.Flight) // Eagerly load related Flight data
                                            .Select(p => new
                                            {
                                                p.Id,
                                                p.Name,
                                                p.TripNO,
                                                p.PhoneNum,
                                                p.PassportNum,
                                                p.Nationality,
                                                FlightInfo = p.Flight != null ? p.Flight.FlightNumber : "N/A" // Display FlightNumber or N/A
                                            })
                                            .ToList();
                    dgvPassengers.DataSource = null;
                    dgvPassengers.DataSource = passengers;
                    AdjustDataGridViewColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading passengers: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdjustDataGridViewColumns()
        {
            if (dgvPassengers.Columns["Id"] != null)
                dgvPassengers.Columns["Id"].Visible = false; // Hide the ID column

            if (dgvPassengers.Columns["FlightInfo"] != null)
                dgvPassengers.Columns["FlightInfo"].HeaderText = "Assigned Flight";

            // You can add more column adjustments here if needed (e.g., width, header text)
        }

        private void ClearFormFields()
        {
            txtName.Clear();
            txtTripNo.Clear();
            txtPhoneNum.Clear();
            txtPassportNum.Clear();
            txtNationality.Clear();
            cmbFlight.SelectedIndex = -1; // No flight selected

            _editingPassengerId = -1; // Reset to Add mode
            btnAddUpdate.Text = "Add";
            txtName.Focus();
        }

        private bool ValidateInputs(out int tripNo, out int passportNo)
        {
            tripNo = 0;
            passportNo = 0;

            // 1. Validate Name: Letters and spaces only, and required.
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            if (!Regex.IsMatch(txtName.Text.Trim(), @"^[a-zA-Z\s]+$")) // Allows letters (upper/lower) and spaces
            {
                MessageBox.Show("Name can only contain letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            // 2. Validate Trip Number: Required and must be a positive integer.
            if (string.IsNullOrWhiteSpace(txtTripNo.Text))
            {
                MessageBox.Show("Trip No. is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTripNo.Focus();
                return false;
            }
            if (!int.TryParse(txtTripNo.Text.Trim(), out tripNo) || tripNo <= 0)
            {
                MessageBox.Show("Trip No. must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTripNo.Focus();
                return false;
            }

            // 3. Validate Phone Number: Required, 11 digits, specific Egyptian prefixes.
            if (string.IsNullOrWhiteSpace(txtPhoneNum.Text))
            {
                MessageBox.Show("Phone No. is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNum.Focus();
                return false;
            }
            // Pattern: Starts with 010, 011, 012, or 015, followed by 8 digits. Total 11 digits.
            string phonePattern = @"^(010|011|012|015)\d{8}$";
            if (!Regex.IsMatch(txtPhoneNum.Text.Trim(), phonePattern))
            {
                MessageBox.Show("Phone No. must be a valid 11-digit Egyptian mobile number starting with 010, 011, 012, or 015.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNum.Focus();
                return false;
            }

            // 4. Validate Passport Number: Required, must be a positive integer.
            // If passport numbers can have letters, the data type in Passenger.cs (int) would need to change.
            // For now, assuming it's purely numeric as per the 'int' type.
            if (string.IsNullOrWhiteSpace(txtPassportNum.Text))
            {
                MessageBox.Show("Passport No. is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassportNum.Focus();
                return false;
            }
            if (!int.TryParse(txtPassportNum.Text.Trim(), out passportNo) || passportNo <= 0)
            {
                MessageBox.Show("Passport No. must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassportNum.Focus();
                return false;
            }
            // Optional: Add length check for passport number if needed, e.g.
            // if (txtPassportNum.Text.Trim().Length < 7 || txtPassportNum.Text.Trim().Length > 9)
            // {
            //     MessageBox.Show("Passport No. must be between 7 and 9 digits long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //     txtPassportNum.Focus();
            //     return false;
            // }


            // 5. Validate Nationality: Optional field, but if provided, letters and spaces only.
            if (string.IsNullOrWhiteSpace(txtNationality.Text)) // Check if it's empty
            {
                MessageBox.Show("Nationality is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNationality.Focus();
                return false;
            }
            if (!Regex.IsMatch(txtNationality.Text.Trim(), @"^[a-zA-Z\s]+$")) // Then check format
            {
                MessageBox.Show("Nationality can only contain letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNationality.Focus();
                return false;
            }

            // Flight selection (cmbFlight) is optional as FlightId is nullable in the Passenger model.
            // No specific validation here unless a flight becomes mandatory.

            return true; // All validations passed
        }

        // --- BUTTON CLICK EVENTS ---
        // If you double-click the "Add" button in the designer, it will create this method.
        // Paste the code inside.
        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out int tripNo, out int passportNo))
            {
                return; // Stop if validation fails
            }

            try
            {
                using (var context = new ApplicationDbContext())
                {
                    bool tripNumberExists = context.Passengers.Any(p =>
                        p.TripNO == tripNo && p.Id != _editingPassengerId);
                    if (tripNumberExists)
                    {
                        MessageBox.Show("A passenger with this trip number already exists.", "Duplicate Trip Number",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTripNo.Focus();
                        return;
                    }

                    bool passportNumberExists = context.Passengers.Any(p =>
                        p.PassportNum == passportNo && p.Id != _editingPassengerId);
                    if (passportNumberExists)
                    {
                        MessageBox.Show("A passenger with this passport number already exists.", "Duplicate Passport Number",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPassportNum.Focus();
                        return;
                    }

                    Passenger passenger;
                    string successMessage;

                    if (_editingPassengerId == -1) // Add mode
                    {
                        passenger = new Passenger();
                        context.Passengers.Add(passenger);
                        successMessage = "Passenger added successfully!";
                    }
                    else // Update mode
                    {
                        passenger = context.Passengers.Find(_editingPassengerId);
                        if (passenger == null)
                        {
                            MessageBox.Show("Passenger not found for update. Please refresh the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearFormFields();
                            LoadPassengersIntoGrid();
                            return;
                        }
                        successMessage = "Passenger updated successfully!";
                    }

                    // Assign values
                    passenger.Name = txtName.Text.Trim();
                    passenger.TripNO = tripNo;
                    passenger.PhoneNum = txtPhoneNum.Text.Trim();
                    passenger.PassportNum = passportNo;
                    passenger.Nationality = txtNationality.Text.Trim();
                    passenger.FlightId = (int?)cmbFlight.SelectedValue; // Nullable if no flight is selected

                    context.SaveChanges();
                    MessageBox.Show(successMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadPassengersIntoGrid();
                ClearFormFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving passenger: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // If you double-click the "Delete Selected" button in the designer, it will create this method.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPassengers.CurrentRow == null)
            {
                MessageBox.Show("Please select a passenger to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int passengerId = (int)dgvPassengers.CurrentRow.Cells["Id"].Value;

            var confirmResult = MessageBox.Show("Are you sure you want to delete this passenger?",
                                         "Confirm Delete",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (var context = new ApplicationDbContext())
                    {
                        var passenger = context.Passengers.Find(passengerId);
                        if (passenger != null)
                        {
                            context.Passengers.Remove(passenger);
                            context.SaveChanges();
                            MessageBox.Show("Passenger deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Passenger not found or already deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    LoadPassengersIntoGrid();
                    ClearFormFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting passenger: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // If you double-click the "Clear Fields" button in the designer, it will create this method.
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFormFields();
        }

        // --- DATAGRIDVIEW EVENT for selecting a passenger to edit ---
        // Select dgvPassengers, go to Properties window, click the "Events" icon (lightning bolt),
        // and double-click on "SelectionChanged". Then paste this code inside.
        private void dgvPassengers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPassengers.CurrentRow != null && dgvPassengers.CurrentRow.Cells["Id"].Value != null)
            {
                try
                {
                    _editingPassengerId = (int)dgvPassengers.CurrentRow.Cells["Id"].Value;

                    // Load selected passenger data into input fields
                    txtName.Text = dgvPassengers.CurrentRow.Cells["Name"].Value.ToString();
                    txtTripNo.Text = dgvPassengers.CurrentRow.Cells["TripNO"].Value.ToString();
                    txtPhoneNum.Text = dgvPassengers.CurrentRow.Cells["PhoneNum"].Value.ToString();
                    txtPassportNum.Text = dgvPassengers.CurrentRow.Cells["PassportNum"].Value.ToString();
                    txtNationality.Text = dgvPassengers.CurrentRow.Cells["Nationality"].Value?.ToString() ?? "";

                    // Select the flight in ComboBox
                    // First, get the FlightId for the selected passenger
                    int? flightIdForSelectedPassenger = null;
                    using (var context = new ApplicationDbContext())
                    {
                        var passenger = context.Passengers.Find(_editingPassengerId);
                        if (passenger != null)
                        {
                            flightIdForSelectedPassenger = passenger.FlightId;
                        }
                    }
                    if (flightIdForSelectedPassenger.HasValue)
                    {
                        cmbFlight.SelectedValue = flightIdForSelectedPassenger.Value;
                    }
                    else
                    {
                        cmbFlight.SelectedIndex = -1; // No flight assigned
                    }

                    btnAddUpdate.Text = "Update"; // Change button text to indicate Update mode
                }
                catch (Exception ex)
                {
                    // This can sometimes happen if you delete the last row and selection changes to an invalid state
                    // Or if a cell value is unexpectedly null and .ToString() is called on it
                    Console.WriteLine("Error in dgvPassengers_SelectionChanged: " + ex.Message);
                    ClearFormFields(); // Reset if there's an issue
                }
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow letters, spaces, and the backspace control character
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Block the character
            }
        }

        private void txtNumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow numbers and the backspace control character
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Block the character
            }
        }

        private void txtPhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow numbers and the backspace control character
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Block non-digit, non-control characters
            }

            // Additionally, limit length to 11 digits (excluding control characters like backspace)
            TextBox textBox = sender as TextBox;
            if (textBox != null && !char.IsControl(e.KeyChar) && textBox.Text.Length >= 11)
            {
                e.Handled = true; // Block if already 11 digits and not a control key
            }
        }
    }
}
