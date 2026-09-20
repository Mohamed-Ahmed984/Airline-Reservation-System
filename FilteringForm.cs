using System;
using System.Data.Entity; // For .Include()
using System.Linq;
using System.Windows.Forms;
using AirlineManagementApp.Models;

namespace AirlineManagementApp
{
    public partial class FilteringForm : Form
    {
        public FilteringForm()
        {
            InitializeComponent();
        }

        private void FilteringForm_Load(object sender, EventArgs e)
        {
            PopulateNationalityComboBox();
            LoadAllPassengers(); // Initially show all passengers
        }

        private void PopulateNationalityComboBox()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var nationalities = context.Passengers
                                             .Where(p => !string.IsNullOrEmpty(p.Nationality)) // Only consider non-empty nationalities
                                             .Select(p => p.Nationality)
                                             .Distinct()
                                             .OrderBy(n => n)
                                             .ToList();

                    cmbNationalityFilter.DataSource = null;
                    cmbNationalityFilter.Items.Clear(); // Clear items if any
                    // Optionally add an "All" or "Select..." item if you prefer
                    // cmbNationalityFilter.Items.Add("All Nationalities");
                    cmbNationalityFilter.DataSource = nationalities;
                    cmbNationalityFilter.SelectedIndex = -1; // No nationality selected initially
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading nationalities: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllPassengers()
        {
            LoadPassengers(null); // Pass null to indicate no filter
        }

        private void LoadPassengers(string nationalityFilter)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var query = context.Passengers.Include(p => p.Flight).AsQueryable();

                    if (!string.IsNullOrEmpty(nationalityFilter) && nationalityFilter != "All Nationalities") // Adjust if you add "All"
                    {
                        query = query.Where(p => p.Nationality == nationalityFilter);
                    }

                    var passengers = query.Select(p => new
                    {
                        p.Id,
                        p.Name,
                        p.TripNO,
                        p.PhoneNum,
                        p.PassportNum,
                        p.Nationality,
                        FlightInfo = p.Flight != null ? p.Flight.FlightNumber : "N/A"
                    })
                                            .ToList();
                    dgvFilteredPassengers.DataSource = null;
                    dgvFilteredPassengers.DataSource = passengers;
                    AdjustDataGridViewColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading passengers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdjustDataGridViewColumns()
        {
            if (dgvFilteredPassengers.Columns["Id"] != null)
                dgvFilteredPassengers.Columns["Id"].Visible = false;
            if (dgvFilteredPassengers.Columns["FlightInfo"] != null)
                dgvFilteredPassengers.Columns["FlightInfo"].HeaderText = "Assigned Flight";
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            string selectedNationality = cmbNationalityFilter.SelectedItem?.ToString();
            // If you added "All Nationalities" as a string item, you might check against that.
            // For now, if nothing is selected (null), it will effectively show all (or handle as you prefer).

            if (string.IsNullOrEmpty(selectedNationality))
            {
                MessageBox.Show("Please select a nationality to filter by.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Optionally, load all passengers if nothing is selected, or do nothing.
                // LoadAllPassengers(); 
                return;
            }
            LoadPassengers(selectedNationality);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            cmbNationalityFilter.SelectedIndex = -1; // Clear selection
            LoadAllPassengers();
        }
    }
}