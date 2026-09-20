namespace AirlineManagementApp
{
    partial class PassengerForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTripNo = new System.Windows.Forms.Label();
            this.txtTripNo = new System.Windows.Forms.TextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.lblPassportNum = new System.Windows.Forms.Label();
            this.txtPassportNum = new System.Windows.Forms.TextBox();
            this.lblNationality = new System.Windows.Forms.Label();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.lblFlight = new System.Windows.Forms.Label();
            this.cmbFlight = new System.Windows.Forms.ComboBox();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvPassengers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(30, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(149, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 1;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lblTripNo
            // 
            this.lblTripNo.AutoSize = true;
            this.lblTripNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripNo.Location = new System.Drawing.Point(30, 126);
            this.lblTripNo.Name = "lblTripNo";
            this.lblTripNo.Size = new System.Drawing.Size(73, 20);
            this.lblTripNo.TabIndex = 2;
            this.lblTripNo.Text = "Trip No.:\t";
            // 
            // txtTripNo
            // 
            this.txtTripNo.Location = new System.Drawing.Point(149, 124);
            this.txtTripNo.Name = "txtTripNo";
            this.txtTripNo.Size = new System.Drawing.Size(100, 22);
            this.txtTripNo.TabIndex = 3;
            this.txtTripNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumbersOnly_KeyPress);
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNum.Location = new System.Drawing.Point(30, 180);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(91, 20);
            this.lblPhoneNum.TabIndex = 4;
            this.lblPhoneNum.Text = "Phone No.:\t";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(149, 178);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(100, 22);
            this.txtPhoneNum.TabIndex = 5;
            this.txtPhoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNum_KeyPress);
            // 
            // lblPassportNum
            // 
            this.lblPassportNum.AutoSize = true;
            this.lblPassportNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassportNum.Location = new System.Drawing.Point(30, 222);
            this.lblPassportNum.Name = "lblPassportNum";
            this.lblPassportNum.Size = new System.Drawing.Size(111, 20);
            this.lblPassportNum.TabIndex = 6;
            this.lblPassportNum.Text = "Passport No.:\t";
            // 
            // txtPassportNum
            // 
            this.txtPassportNum.Location = new System.Drawing.Point(149, 220);
            this.txtPassportNum.Name = "txtPassportNum";
            this.txtPassportNum.Size = new System.Drawing.Size(100, 22);
            this.txtPassportNum.TabIndex = 7;
            this.txtPassportNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumbersOnly_KeyPress);
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationality.Location = new System.Drawing.Point(30, 265);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(92, 20);
            this.lblNationality.TabIndex = 8;
            this.lblNationality.Text = "Nationality:\t";
            // 
            // txtNationality
            // 
            this.txtNationality.Location = new System.Drawing.Point(149, 262);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(100, 22);
            this.txtNationality.TabIndex = 9;
            this.txtNationality.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lblFlight
            // 
            this.lblFlight.AutoSize = true;
            this.lblFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight.Location = new System.Drawing.Point(30, 306);
            this.lblFlight.Name = "lblFlight";
            this.lblFlight.Size = new System.Drawing.Size(55, 20);
            this.lblFlight.TabIndex = 10;
            this.lblFlight.Text = "Flight:\t";
            // 
            // cmbFlight
            // 
            this.cmbFlight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFlight.FormattingEnabled = true;
            this.cmbFlight.Location = new System.Drawing.Point(149, 302);
            this.cmbFlight.Name = "cmbFlight";
            this.cmbFlight.Size = new System.Drawing.Size(316, 24);
            this.cmbFlight.TabIndex = 11;
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUpdate.Location = new System.Drawing.Point(34, 367);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(88, 33);
            this.btnAddUpdate.TabIndex = 12;
            this.btnAddUpdate.Text = "Add";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(149, 367);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 33);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete Selected\t";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(296, 367);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 33);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear Fields\t";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvPassengers
            // 
            this.dgvPassengers.AllowUserToAddRows = false;
            this.dgvPassengers.AllowUserToDeleteRows = false;
            this.dgvPassengers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassengers.Location = new System.Drawing.Point(315, 23);
            this.dgvPassengers.MultiSelect = false;
            this.dgvPassengers.Name = "dgvPassengers";
            this.dgvPassengers.ReadOnly = true;
            this.dgvPassengers.RowHeadersWidth = 51;
            this.dgvPassengers.RowTemplate.Height = 24;
            this.dgvPassengers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPassengers.Size = new System.Drawing.Size(958, 273);
            this.dgvPassengers.TabIndex = 15;
            this.dgvPassengers.SelectionChanged += new System.EventHandler(this.dgvPassengers_SelectionChanged);
            // 
            // PassengerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 450);
            this.Controls.Add(this.dgvPassengers);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.cmbFlight);
            this.Controls.Add(this.lblFlight);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.txtPassportNum);
            this.Controls.Add(this.lblPassportNum);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.lblPhoneNum);
            this.Controls.Add(this.txtTripNo);
            this.Controls.Add(this.lblTripNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "PassengerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passenger Management";
            this.Load += new System.EventHandler(this.PassengerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassengers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTripNo;
        private System.Windows.Forms.TextBox txtTripNo;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Label lblPassportNum;
        private System.Windows.Forms.TextBox txtPassportNum;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.Label lblFlight;
        private System.Windows.Forms.ComboBox cmbFlight;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvPassengers;
    }
}

