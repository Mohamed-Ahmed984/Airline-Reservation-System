namespace AirlineManagementApp
{
    partial class ViewPassengersByFlightForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSelectFlight;
        private System.Windows.Forms.ComboBox cmbFlights;
        private System.Windows.Forms.DataGridView dgvPassengers;
        private System.Windows.Forms.Label lblPassengerCount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblSelectFlight = new System.Windows.Forms.Label();
            this.cmbFlights = new System.Windows.Forms.ComboBox();
            this.dgvPassengers = new System.Windows.Forms.DataGridView();
            this.lblPassengerCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengers)).BeginInit();
            this.SuspendLayout();
            //
            // lblSelectFlight
            //
            this.lblSelectFlight.AutoSize = true;
            this.lblSelectFlight.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectFlight.Location = new System.Drawing.Point(24, 25);
            this.lblSelectFlight.Name = "lblSelectFlight";
            this.lblSelectFlight.Size = new System.Drawing.Size(93, 19);
            this.lblSelectFlight.TabIndex = 0;
            this.lblSelectFlight.Text = "Select Flight";
            //
            // cmbFlights
            //
            this.cmbFlights.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFlights.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFlights.FormattingEnabled = true;
            this.cmbFlights.Location = new System.Drawing.Point(128, 22);
            this.cmbFlights.Name = "cmbFlights";
            this.cmbFlights.Size = new System.Drawing.Size(490, 25);
            this.cmbFlights.TabIndex = 1;
            this.cmbFlights.SelectedIndexChanged += new System.EventHandler(this.cmbFlights_SelectedIndexChanged);
            //
            // dgvPassengers
            //
            this.dgvPassengers.AllowUserToAddRows = false;
            this.dgvPassengers.AllowUserToDeleteRows = false;
            this.dgvPassengers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassengers.Location = new System.Drawing.Point(28, 74);
            this.dgvPassengers.MultiSelect = false;
            this.dgvPassengers.Name = "dgvPassengers";
            this.dgvPassengers.ReadOnly = true;
            this.dgvPassengers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPassengers.Size = new System.Drawing.Size(720, 330);
            this.dgvPassengers.TabIndex = 2;
            //
            // lblPassengerCount
            //
            this.lblPassengerCount.AutoSize = true;
            this.lblPassengerCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPassengerCount.Location = new System.Drawing.Point(25, 418);
            this.lblPassengerCount.Name = "lblPassengerCount";
            this.lblPassengerCount.Size = new System.Drawing.Size(0, 15);
            this.lblPassengerCount.TabIndex = 3;
            //
            // ViewPassengersByFlightForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 455);
            this.Controls.Add(this.lblPassengerCount);
            this.Controls.Add(this.dgvPassengers);
            this.Controls.Add(this.cmbFlights);
            this.Controls.Add(this.lblSelectFlight);
            this.Name = "ViewPassengersByFlightForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Passengers by Flight";
            this.Load += new System.EventHandler(this.ViewPassengersByFlightForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
