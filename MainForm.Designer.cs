namespace AirlineManagementApp
{
    partial class MainForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnManagePassengers = new System.Windows.Forms.Button();
            this.btnManageFlights = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFilterData = new System.Windows.Forms.Button();
            this.btnViewPassengersByFlight = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(178, 47);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Airline Management System\t";
            // 
            // btnManagePassengers
            // 
            this.btnManagePassengers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagePassengers.Location = new System.Drawing.Point(224, 102);
            this.btnManagePassengers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManagePassengers.Name = "btnManagePassengers";
            this.btnManagePassengers.Size = new System.Drawing.Size(152, 35);
            this.btnManagePassengers.TabIndex = 1;
            this.btnManagePassengers.Text = "Manage Passengers";
            this.btnManagePassengers.UseVisualStyleBackColor = true;
            this.btnManagePassengers.Click += new System.EventHandler(this.btnManagePassengers_Click);
            // 
            // btnManageFlights
            // 
            this.btnManageFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageFlights.Location = new System.Drawing.Point(224, 154);
            this.btnManageFlights.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManageFlights.Name = "btnManageFlights";
            this.btnManageFlights.Size = new System.Drawing.Size(152, 30);
            this.btnManageFlights.TabIndex = 2;
            this.btnManageFlights.Text = "Manage Flights";
            this.btnManageFlights.UseVisualStyleBackColor = true;
            this.btnManageFlights.Click += new System.EventHandler(this.btnManageFlights_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(224, 364);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 28);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit Application\t";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFilterData
            // 
            this.btnFilterData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterData.Location = new System.Drawing.Point(224, 211);
            this.btnFilterData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFilterData.Name = "btnFilterData";
            this.btnFilterData.Size = new System.Drawing.Size(152, 31);
            this.btnFilterData.TabIndex = 4;
            this.btnFilterData.Text = "Filter Passenger Data";
            this.btnFilterData.UseVisualStyleBackColor = true;
            this.btnFilterData.Click += new System.EventHandler(this.btnFilterData_Click);
            // 
            // btnViewPassengersByFlight
            // 
            this.btnViewPassengersByFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPassengersByFlight.Location = new System.Drawing.Point(224, 261);
            this.btnViewPassengersByFlight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewPassengersByFlight.Name = "btnViewPassengersByFlight";
            this.btnViewPassengersByFlight.Size = new System.Drawing.Size(152, 43);
            this.btnViewPassengersByFlight.TabIndex = 5;
            this.btnViewPassengersByFlight.Text = "View Passengers by Flight";
            this.btnViewPassengersByFlight.UseVisualStyleBackColor = true;
            this.btnViewPassengersByFlight.Click += new System.EventHandler(this.btnViewPassengersByFlight_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(224, 321);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(152, 27);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 409);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnViewPassengersByFlight);
            this.Controls.Add(this.btnFilterData);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnManageFlights);
            this.Controls.Add(this.btnManagePassengers);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu - Airline Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnManagePassengers;
        private System.Windows.Forms.Button btnManageFlights;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFilterData;
        private System.Windows.Forms.Button btnViewPassengersByFlight;
        private System.Windows.Forms.Button btnAbout;
    }
}