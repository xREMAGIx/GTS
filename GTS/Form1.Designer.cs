namespace GTS
{
    partial class Form1
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
            this.passengerGridView = new System.Windows.Forms.DataGridView();
            this.idPassenger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gate2GridView = new System.Windows.Forms.DataGridView();
            this.idExePassenger2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityOfExecutedPassenger2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.available2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gate3GridView = new System.Windows.Forms.DataGridView();
            this.idExePassenger3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityOfExecutedPassenger3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.available3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.available1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityOfExecutedPassenger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idExePassenger1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gate1GridView = new System.Windows.Forms.DataGridView();
            this.gate1 = new System.Windows.Forms.Label();
            this.gate2 = new System.Windows.Forms.Label();
            this.gate3 = new System.Windows.Forms.Label();
            this.passengerLine = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.passengerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gate2GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gate3GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gate1GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // passengerGridView
            // 
            this.passengerGridView.AllowDrop = true;
            this.passengerGridView.AllowUserToAddRows = false;
            this.passengerGridView.AllowUserToDeleteRows = false;
            this.passengerGridView.BackgroundColor = System.Drawing.Color.White;
            this.passengerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passengerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPassenger,
            this.priority});
            this.passengerGridView.Location = new System.Drawing.Point(750, 88);
            this.passengerGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passengerGridView.Name = "passengerGridView";
            this.passengerGridView.ReadOnly = true;
            this.passengerGridView.RowHeadersWidth = 51;
            this.passengerGridView.RowTemplate.Height = 24;
            this.passengerGridView.Size = new System.Drawing.Size(407, 336);
            this.passengerGridView.TabIndex = 0;
            this.passengerGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.passengerGridView_DataError);
            // 
            // idPassenger
            // 
            this.idPassenger.DataPropertyName = "number";
            this.idPassenger.HeaderText = "ID";
            this.idPassenger.MinimumWidth = 6;
            this.idPassenger.Name = "idPassenger";
            this.idPassenger.ReadOnly = true;
            this.idPassenger.Width = 125;
            // 
            // priority
            // 
            this.priority.DataPropertyName = "priority";
            this.priority.HeaderText = "Priority";
            this.priority.MinimumWidth = 6;
            this.priority.Name = "priority";
            this.priority.ReadOnly = true;
            this.priority.Width = 125;
            // 
            // gate2GridView
            // 
            this.gate2GridView.AllowUserToAddRows = false;
            this.gate2GridView.AllowUserToDeleteRows = false;
            this.gate2GridView.BackgroundColor = System.Drawing.Color.White;
            this.gate2GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gate2GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idExePassenger2,
            this.priorityOfExecutedPassenger2,
            this.available2});
            this.gate2GridView.Location = new System.Drawing.Point(116, 201);
            this.gate2GridView.Margin = new System.Windows.Forms.Padding(4);
            this.gate2GridView.Name = "gate2GridView";
            this.gate2GridView.ReadOnly = true;
            this.gate2GridView.RowHeadersWidth = 51;
            this.gate2GridView.Size = new System.Drawing.Size(575, 80);
            this.gate2GridView.TabIndex = 2;
            this.gate2GridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gate2GridView_CellFormatting);
            // 
            // idExePassenger2
            // 
            this.idExePassenger2.DataPropertyName = "numberOfExecutedPassenger";
            this.idExePassenger2.HeaderText = "Passenger ID";
            this.idExePassenger2.MinimumWidth = 6;
            this.idExePassenger2.Name = "idExePassenger2";
            this.idExePassenger2.ReadOnly = true;
            this.idExePassenger2.Width = 125;
            // 
            // priorityOfExecutedPassenger2
            // 
            this.priorityOfExecutedPassenger2.DataPropertyName = "passengerPriority";
            this.priorityOfExecutedPassenger2.HeaderText = "Passenger Priority";
            this.priorityOfExecutedPassenger2.MinimumWidth = 6;
            this.priorityOfExecutedPassenger2.Name = "priorityOfExecutedPassenger2";
            this.priorityOfExecutedPassenger2.ReadOnly = true;
            this.priorityOfExecutedPassenger2.Width = 125;
            // 
            // available2
            // 
            this.available2.DataPropertyName = "available";
            this.available2.HeaderText = "Available";
            this.available2.MinimumWidth = 6;
            this.available2.Name = "available2";
            this.available2.ReadOnly = true;
            this.available2.Width = 125;
            // 
            // gate3GridView
            // 
            this.gate3GridView.AllowUserToAddRows = false;
            this.gate3GridView.AllowUserToDeleteRows = false;
            this.gate3GridView.BackgroundColor = System.Drawing.Color.White;
            this.gate3GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gate3GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idExePassenger3,
            this.priorityOfExecutedPassenger3,
            this.available3});
            this.gate3GridView.Location = new System.Drawing.Point(116, 362);
            this.gate3GridView.Margin = new System.Windows.Forms.Padding(4);
            this.gate3GridView.Name = "gate3GridView";
            this.gate3GridView.ReadOnly = true;
            this.gate3GridView.RowHeadersWidth = 51;
            this.gate3GridView.Size = new System.Drawing.Size(575, 80);
            this.gate3GridView.TabIndex = 3;
            this.gate3GridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gate3GridView_CellFormatting);
            // 
            // idExePassenger3
            // 
            this.idExePassenger3.DataPropertyName = "numberOfExecutedPassenger";
            this.idExePassenger3.HeaderText = "Passenger ID";
            this.idExePassenger3.MinimumWidth = 6;
            this.idExePassenger3.Name = "idExePassenger3";
            this.idExePassenger3.ReadOnly = true;
            this.idExePassenger3.Width = 125;
            // 
            // priorityOfExecutedPassenger3
            // 
            this.priorityOfExecutedPassenger3.DataPropertyName = "passengerPriority";
            this.priorityOfExecutedPassenger3.HeaderText = "Passenger Priority";
            this.priorityOfExecutedPassenger3.MinimumWidth = 6;
            this.priorityOfExecutedPassenger3.Name = "priorityOfExecutedPassenger3";
            this.priorityOfExecutedPassenger3.ReadOnly = true;
            this.priorityOfExecutedPassenger3.Width = 125;
            // 
            // available3
            // 
            this.available3.DataPropertyName = "available";
            this.available3.HeaderText = "Available";
            this.available3.MinimumWidth = 6;
            this.available3.Name = "available3";
            this.available3.ReadOnly = true;
            this.available3.Width = 125;
            // 
            // available1
            // 
            this.available1.DataPropertyName = "available";
            this.available1.HeaderText = "Available";
            this.available1.MinimumWidth = 6;
            this.available1.Name = "available1";
            this.available1.ReadOnly = true;
            this.available1.Width = 125;
            // 
            // priorityOfExecutedPassenger
            // 
            this.priorityOfExecutedPassenger.DataPropertyName = "passengerPriority";
            this.priorityOfExecutedPassenger.HeaderText = "Passenger Priority";
            this.priorityOfExecutedPassenger.MinimumWidth = 6;
            this.priorityOfExecutedPassenger.Name = "priorityOfExecutedPassenger";
            this.priorityOfExecutedPassenger.ReadOnly = true;
            this.priorityOfExecutedPassenger.Width = 125;
            // 
            // idExePassenger1
            // 
            this.idExePassenger1.DataPropertyName = "numberOfExecutedPassenger";
            this.idExePassenger1.HeaderText = "Passenger ID";
            this.idExePassenger1.MinimumWidth = 6;
            this.idExePassenger1.Name = "idExePassenger1";
            this.idExePassenger1.ReadOnly = true;
            this.idExePassenger1.Width = 125;
            // 
            // gate1GridView
            // 
            this.gate1GridView.AllowUserToAddRows = false;
            this.gate1GridView.AllowUserToDeleteRows = false;
            this.gate1GridView.BackgroundColor = System.Drawing.Color.White;
            this.gate1GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gate1GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idExePassenger1,
            this.priorityOfExecutedPassenger,
            this.available1});
            this.gate1GridView.Location = new System.Drawing.Point(116, 27);
            this.gate1GridView.Margin = new System.Windows.Forms.Padding(4);
            this.gate1GridView.Name = "gate1GridView";
            this.gate1GridView.ReadOnly = true;
            this.gate1GridView.RowHeadersWidth = 51;
            this.gate1GridView.Size = new System.Drawing.Size(575, 80);
            this.gate1GridView.TabIndex = 1;
            this.gate1GridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gate1GridView_CellFormatting);
            // 
            // gate1
            // 
            this.gate1.AutoSize = true;
            this.gate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gate1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gate1.Location = new System.Drawing.Point(1, 47);
            this.gate1.Name = "gate1";
            this.gate1.Size = new System.Drawing.Size(108, 32);
            this.gate1.TabIndex = 4;
            this.gate1.Text = "Gate 1:";
            // 
            // gate2
            // 
            this.gate2.AutoSize = true;
            this.gate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gate2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gate2.Location = new System.Drawing.Point(1, 221);
            this.gate2.Name = "gate2";
            this.gate2.Size = new System.Drawing.Size(108, 32);
            this.gate2.TabIndex = 5;
            this.gate2.Text = "Gate 2:";
            // 
            // gate3
            // 
            this.gate3.AutoSize = true;
            this.gate3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gate3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gate3.Location = new System.Drawing.Point(1, 383);
            this.gate3.Name = "gate3";
            this.gate3.Size = new System.Drawing.Size(108, 32);
            this.gate3.TabIndex = 6;
            this.gate3.Text = "Gate 3:";
            // 
            // passengerLine
            // 
            this.passengerLine.AutoSize = true;
            this.passengerLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerLine.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passengerLine.Location = new System.Drawing.Point(785, 27);
            this.passengerLine.Name = "passengerLine";
            this.passengerLine.Size = new System.Drawing.Size(324, 32);
            this.passengerLine.TabIndex = 7;
            this.passengerLine.Text = "Passenger Waiting Line:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1169, 473);
            this.Controls.Add(this.passengerLine);
            this.Controls.Add(this.gate3);
            this.Controls.Add(this.gate2);
            this.Controls.Add(this.gate1);
            this.Controls.Add(this.gate3GridView);
            this.Controls.Add(this.gate2GridView);
            this.Controls.Add(this.gate1GridView);
            this.Controls.Add(this.passengerGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.passengerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gate2GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gate3GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gate1GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView passengerGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPassenger;
        private System.Windows.Forms.DataGridViewTextBoxColumn priority;
        private System.Windows.Forms.DataGridView gate2GridView;
        private System.Windows.Forms.DataGridView gate3GridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idExePassenger2;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityOfExecutedPassenger2;
        private System.Windows.Forms.DataGridViewTextBoxColumn available2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idExePassenger3;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityOfExecutedPassenger3;
        private System.Windows.Forms.DataGridViewTextBoxColumn available3;
        private System.Windows.Forms.DataGridViewTextBoxColumn available1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityOfExecutedPassenger;
        private System.Windows.Forms.DataGridViewTextBoxColumn idExePassenger1;
        private System.Windows.Forms.DataGridView gate1GridView;
        private System.Windows.Forms.Label gate1;
        private System.Windows.Forms.Label gate2;
        private System.Windows.Forms.Label gate3;
        private System.Windows.Forms.Label passengerLine;
    }
}

