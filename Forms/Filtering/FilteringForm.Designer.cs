namespace AirlineManagementApp
{
    partial class FilteringForm
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
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.lblSelectNationality = new System.Windows.Forms.Label();
            this.cmbNationalityFilter = new System.Windows.Forms.ComboBox();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.dgvFilteredPassengers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilteredPassengers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(36, 49);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(146, 20);
            this.lblFilterBy.TabIndex = 0;
            this.lblFilterBy.Text = "Filter Passengers \t";
            // 
            // lblSelectNationality
            // 
            this.lblSelectNationality.AutoSize = true;
            this.lblSelectNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectNationality.Location = new System.Drawing.Point(36, 118);
            this.lblSelectNationality.Name = "lblSelectNationality";
            this.lblSelectNationality.Size = new System.Drawing.Size(144, 20);
            this.lblSelectNationality.TabIndex = 1;
            this.lblSelectNationality.Text = "Select Nationality:\t";
            // 
            // cmbNationalityFilter
            // 
            this.cmbNationalityFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNationalityFilter.FormattingEnabled = true;
            this.cmbNationalityFilter.Location = new System.Drawing.Point(200, 114);
            this.cmbNationalityFilter.Name = "cmbNationalityFilter";
            this.cmbNationalityFilter.Size = new System.Drawing.Size(121, 24);
            this.cmbNationalityFilter.TabIndex = 2;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyFilter.Location = new System.Drawing.Point(40, 173);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(121, 32);
            this.btnApplyFilter.TabIndex = 3;
            this.btnApplyFilter.Text = "Apply Filter\t";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(40, 316);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(203, 63);
            this.btnShowAll.TabIndex = 4;
            this.btnShowAll.Text = "Show All / Clear Filter\t";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // dgvFilteredPassengers
            // 
            this.dgvFilteredPassengers.AllowUserToAddRows = false;
            this.dgvFilteredPassengers.AllowUserToDeleteRows = false;
            this.dgvFilteredPassengers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFilteredPassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilteredPassengers.Location = new System.Drawing.Point(340, 49);
            this.dgvFilteredPassengers.MultiSelect = false;
            this.dgvFilteredPassengers.Name = "dgvFilteredPassengers";
            this.dgvFilteredPassengers.ReadOnly = true;
            this.dgvFilteredPassengers.RowHeadersWidth = 51;
            this.dgvFilteredPassengers.RowTemplate.Height = 24;
            this.dgvFilteredPassengers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilteredPassengers.Size = new System.Drawing.Size(1002, 342);
            this.dgvFilteredPassengers.TabIndex = 5;
            // 
            // FilteringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 450);
            this.Controls.Add(this.dgvFilteredPassengers);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnApplyFilter);
            this.Controls.Add(this.cmbNationalityFilter);
            this.Controls.Add(this.lblSelectNationality);
            this.Controls.Add(this.lblFilterBy);
            this.Name = "FilteringForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter Passengers";
            this.Load += new System.EventHandler(this.FilteringForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilteredPassengers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.Label lblSelectNationality;
        private System.Windows.Forms.ComboBox cmbNationalityFilter;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridView dgvFilteredPassengers;
    }
}