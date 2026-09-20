namespace AirlineManagementApp
{
    partial class FlightForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFlightNumber = new System.Windows.Forms.Label();
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.lblOriginCity = new System.Windows.Forms.Label();
            this.txtOriginCity = new System.Windows.Forms.TextBox();
            this.lblDestinationCity = new System.Windows.Forms.Label();
            this.txtDestinationCity = new System.Windows.Forms.TextBox();
            this.lblDepartureDateTime = new System.Windows.Forms.Label();
            this.dtpDeparture = new System.Windows.Forms.DateTimePicker();
            this.lblAirline = new System.Windows.Forms.Label();
            this.txtAirline = new System.Windows.Forms.TextBox();
            this.btnAddUpdateFlight = new System.Windows.Forms.Button();
            this.btnDeleteFlight = new System.Windows.Forms.Button();
            this.btnClearFlight = new System.Windows.Forms.Button();
            this.dgvFlights = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFlightNumber
            // 
            this.lblFlightNumber.AutoSize = true;
            this.lblFlightNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNumber.Location = new System.Drawing.Point(27, 73);
            this.lblFlightNumber.Name = "lblFlightNumber";
            this.lblFlightNumber.Size = new System.Drawing.Size(85, 20);
            this.lblFlightNumber.TabIndex = 0;
            this.lblFlightNumber.Text = "Flight No.:\t";
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.Location = new System.Drawing.Point(172, 71);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(100, 22);
            this.txtFlightNumber.TabIndex = 1;
            this.txtFlightNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlphaNumericSpacesHyphens_KeyPress);
            // 
            // lblOriginCity
            // 
            this.lblOriginCity.AutoSize = true;
            this.lblOriginCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginCity.Location = new System.Drawing.Point(27, 128);
            this.lblOriginCity.Name = "lblOriginCity";
            this.lblOriginCity.Size = new System.Drawing.Size(93, 20);
            this.lblOriginCity.TabIndex = 2;
            this.lblOriginCity.Text = "Origin City:\t";
            // 
            // txtOriginCity
            // 
            this.txtOriginCity.Location = new System.Drawing.Point(172, 126);
            this.txtOriginCity.Name = "txtOriginCity";
            this.txtOriginCity.Size = new System.Drawing.Size(100, 22);
            this.txtOriginCity.TabIndex = 3;
            this.txtOriginCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLettersAndSpaces_KeyPress);
            // 
            // lblDestinationCity
            // 
            this.lblDestinationCity.AutoSize = true;
            this.lblDestinationCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationCity.Location = new System.Drawing.Point(27, 181);
            this.lblDestinationCity.Name = "lblDestinationCity";
            this.lblDestinationCity.Size = new System.Drawing.Size(133, 20);
            this.lblDestinationCity.TabIndex = 4;
            this.lblDestinationCity.Text = "Destination City:\t";
            // 
            // txtDestinationCity
            // 
            this.txtDestinationCity.Location = new System.Drawing.Point(172, 179);
            this.txtDestinationCity.Name = "txtDestinationCity";
            this.txtDestinationCity.Size = new System.Drawing.Size(100, 22);
            this.txtDestinationCity.TabIndex = 5;
            this.txtDestinationCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLettersAndSpaces_KeyPress);
            // 
            // lblDepartureDateTime
            // 
            this.lblDepartureDateTime.AutoSize = true;
            this.lblDepartureDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureDateTime.Location = new System.Drawing.Point(42, 229);
            this.lblDepartureDateTime.Name = "lblDepartureDateTime";
            this.lblDepartureDateTime.Size = new System.Drawing.Size(89, 20);
            this.lblDepartureDateTime.TabIndex = 6;
            this.lblDepartureDateTime.Text = "Departure:\t";
            // 
            // dtpDeparture
            // 
            this.dtpDeparture.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeparture.Location = new System.Drawing.Point(172, 223);
            this.dtpDeparture.Name = "dtpDeparture";
            this.dtpDeparture.Size = new System.Drawing.Size(200, 22);
            this.dtpDeparture.TabIndex = 7;
            // 
            // lblAirline
            // 
            this.lblAirline.AutoSize = true;
            this.lblAirline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirline.Location = new System.Drawing.Point(42, 275);
            this.lblAirline.Name = "lblAirline";
            this.lblAirline.Size = new System.Drawing.Size(61, 20);
            this.lblAirline.TabIndex = 8;
            this.lblAirline.Text = "Airline:\t";
            // 
            // txtAirline
            // 
            this.txtAirline.Location = new System.Drawing.Point(172, 273);
            this.txtAirline.Name = "txtAirline";
            this.txtAirline.Size = new System.Drawing.Size(100, 22);
            this.txtAirline.TabIndex = 9;
            this.txtAirline.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlphaNumericSpacesHyphens_KeyPress);
            // 
            // btnAddUpdateFlight
            // 
            this.btnAddUpdateFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUpdateFlight.Location = new System.Drawing.Point(31, 353);
            this.btnAddUpdateFlight.Name = "btnAddUpdateFlight";
            this.btnAddUpdateFlight.Size = new System.Drawing.Size(75, 27);
            this.btnAddUpdateFlight.TabIndex = 10;
            this.btnAddUpdateFlight.Text = "Add Flight\t";
            this.btnAddUpdateFlight.UseVisualStyleBackColor = true;
            this.btnAddUpdateFlight.Click += new System.EventHandler(this.btnAddUpdateFlight_Click);
            // 
            // btnDeleteFlight
            // 
            this.btnDeleteFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFlight.Location = new System.Drawing.Point(154, 353);
            this.btnDeleteFlight.Name = "btnDeleteFlight";
            this.btnDeleteFlight.Size = new System.Drawing.Size(118, 27);
            this.btnDeleteFlight.TabIndex = 11;
            this.btnDeleteFlight.Text = "Delete Selected\t";
            this.btnDeleteFlight.UseVisualStyleBackColor = true;
            this.btnDeleteFlight.Click += new System.EventHandler(this.btnDeleteFlight_Click);
            // 
            // btnClearFlight
            // 
            this.btnClearFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFlight.Location = new System.Drawing.Point(322, 353);
            this.btnClearFlight.Name = "btnClearFlight";
            this.btnClearFlight.Size = new System.Drawing.Size(96, 28);
            this.btnClearFlight.TabIndex = 12;
            this.btnClearFlight.Text = "Clear Fields\t";
            this.btnClearFlight.UseVisualStyleBackColor = true;
            this.btnClearFlight.Click += new System.EventHandler(this.btnClearFlight_Click);
            // 
            // dgvFlights
            // 
            this.dgvFlights.AllowUserToAddRows = false;
            this.dgvFlights.AllowUserToDeleteRows = false;
            this.dgvFlights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlights.Location = new System.Drawing.Point(446, 71);
            this.dgvFlights.MultiSelect = false;
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.ReadOnly = true;
            this.dgvFlights.RowHeadersWidth = 51;
            this.dgvFlights.RowTemplate.Height = 24;
            this.dgvFlights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFlights.Size = new System.Drawing.Size(903, 293);
            this.dgvFlights.TabIndex = 13;
            this.dgvFlights.SelectionChanged += new System.EventHandler(this.dgvFlights_SelectionChanged);
            // 
            // FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 450);
            this.Controls.Add(this.dgvFlights);
            this.Controls.Add(this.btnClearFlight);
            this.Controls.Add(this.btnDeleteFlight);
            this.Controls.Add(this.btnAddUpdateFlight);
            this.Controls.Add(this.txtAirline);
            this.Controls.Add(this.lblAirline);
            this.Controls.Add(this.dtpDeparture);
            this.Controls.Add(this.lblDepartureDateTime);
            this.Controls.Add(this.txtDestinationCity);
            this.Controls.Add(this.lblDestinationCity);
            this.Controls.Add(this.txtOriginCity);
            this.Controls.Add(this.lblOriginCity);
            this.Controls.Add(this.txtFlightNumber);
            this.Controls.Add(this.lblFlightNumber);
            this.Name = "FlightForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Management";
            this.Load += new System.EventHandler(this.FlightForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFlightNumber;
        private System.Windows.Forms.TextBox txtFlightNumber;
        private System.Windows.Forms.Label lblOriginCity;
        private System.Windows.Forms.TextBox txtOriginCity;
        private System.Windows.Forms.Label lblDestinationCity;
        private System.Windows.Forms.TextBox txtDestinationCity;
        private System.Windows.Forms.Label lblDepartureDateTime;
        private System.Windows.Forms.DateTimePicker dtpDeparture;
        private System.Windows.Forms.Label lblAirline;
        private System.Windows.Forms.TextBox txtAirline;
        private System.Windows.Forms.Button btnAddUpdateFlight;
        private System.Windows.Forms.Button btnDeleteFlight;
        private System.Windows.Forms.Button btnClearFlight;
        private System.Windows.Forms.DataGridView dgvFlights;
    }
}