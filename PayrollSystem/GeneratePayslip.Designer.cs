namespace PayrollSystem
{
	partial class GeneratePayslip
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratePayslip));
			this.lbPayslip = new System.Windows.Forms.Label();
			this.lbEmployeename = new System.Windows.Forms.Label();
			this.lbctc = new System.Windows.Forms.Label();
			this.lbAttendance = new System.Windows.Forms.Label();
			this.lbMonth = new System.Windows.Forms.Label();
			this.lbtax = new System.Windows.Forms.Label();
			this.lbNetpay = new System.Windows.Forms.Label();
			this.txtEmpName = new System.Windows.Forms.TextBox();
			this.txtAttendance = new System.Windows.Forms.TextBox();
			this.txtTax = new System.Windows.Forms.TextBox();
			this.txtNetpay = new System.Windows.Forms.TextBox();
			this.txtCtc = new System.Windows.Forms.TextBox();
			this.btGenerate = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.btExit = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// lbPayslip
			// 
			this.lbPayslip.AutoSize = true;
			this.lbPayslip.BackColor = System.Drawing.Color.Transparent;
			this.lbPayslip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPayslip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbPayslip.Location = new System.Drawing.Point(194, 30);
			this.lbPayslip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbPayslip.Name = "lbPayslip";
			this.lbPayslip.Size = new System.Drawing.Size(151, 20);
			this.lbPayslip.TabIndex = 0;
			this.lbPayslip.Text = "Employee PaySlip";
			this.lbPayslip.Click += new System.EventHandler(this.lbPayslip_Click);
			// 
			// lbEmployeename
			// 
			this.lbEmployeename.AutoSize = true;
			this.lbEmployeename.BackColor = System.Drawing.Color.Transparent;
			this.lbEmployeename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbEmployeename.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbEmployeename.Location = new System.Drawing.Point(75, 100);
			this.lbEmployeename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbEmployeename.Name = "lbEmployeename";
			this.lbEmployeename.Size = new System.Drawing.Size(133, 20);
			this.lbEmployeename.TabIndex = 1;
			this.lbEmployeename.Text = "EmployeeName";
			this.lbEmployeename.Click += new System.EventHandler(this.lbEmployeename_Click);
			// 
			// lbctc
			// 
			this.lbctc.AutoSize = true;
			this.lbctc.BackColor = System.Drawing.Color.Transparent;
			this.lbctc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbctc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbctc.Location = new System.Drawing.Point(75, 134);
			this.lbctc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbctc.Name = "lbctc";
			this.lbctc.Size = new System.Drawing.Size(43, 20);
			this.lbctc.TabIndex = 2;
			this.lbctc.Text = "CTC";
			this.lbctc.Click += new System.EventHandler(this.lbctc_Click);
			// 
			// lbAttendance
			// 
			this.lbAttendance.AutoSize = true;
			this.lbAttendance.BackColor = System.Drawing.Color.Transparent;
			this.lbAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAttendance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbAttendance.Location = new System.Drawing.Point(75, 168);
			this.lbAttendance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbAttendance.Name = "lbAttendance";
			this.lbAttendance.Size = new System.Drawing.Size(102, 20);
			this.lbAttendance.TabIndex = 3;
			this.lbAttendance.Text = "Attendance";
			this.lbAttendance.Click += new System.EventHandler(this.lbAttendance_Click);
			// 
			// lbMonth
			// 
			this.lbMonth.AutoSize = true;
			this.lbMonth.BackColor = System.Drawing.Color.Transparent;
			this.lbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMonth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbMonth.Location = new System.Drawing.Point(75, 202);
			this.lbMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbMonth.Name = "lbMonth";
			this.lbMonth.Size = new System.Drawing.Size(59, 20);
			this.lbMonth.TabIndex = 4;
			this.lbMonth.Text = "Month";
			this.lbMonth.Click += new System.EventHandler(this.lbMonth_Click);
			// 
			// lbtax
			// 
			this.lbtax.AutoSize = true;
			this.lbtax.BackColor = System.Drawing.Color.Transparent;
			this.lbtax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbtax.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbtax.Location = new System.Drawing.Point(75, 240);
			this.lbtax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbtax.Name = "lbtax";
			this.lbtax.Size = new System.Drawing.Size(119, 20);
			this.lbtax.TabIndex = 5;
			this.lbtax.Text = "TaxDeduction";
			this.lbtax.Click += new System.EventHandler(this.lbtax_Click);
			// 
			// lbNetpay
			// 
			this.lbNetpay.AutoSize = true;
			this.lbNetpay.BackColor = System.Drawing.Color.Transparent;
			this.lbNetpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNetpay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbNetpay.Location = new System.Drawing.Point(75, 275);
			this.lbNetpay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbNetpay.Name = "lbNetpay";
			this.lbNetpay.Size = new System.Drawing.Size(66, 20);
			this.lbNetpay.TabIndex = 6;
			this.lbNetpay.Text = "NetPay";
			// 
			// txtEmpName
			// 
			this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmpName.Location = new System.Drawing.Point(269, 100);
			this.txtEmpName.Name = "txtEmpName";
			this.txtEmpName.Size = new System.Drawing.Size(222, 20);
			this.txtEmpName.TabIndex = 7;
			// 
			// txtAttendance
			// 
			this.txtAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAttendance.Location = new System.Drawing.Point(269, 166);
			this.txtAttendance.Name = "txtAttendance";
			this.txtAttendance.Size = new System.Drawing.Size(222, 20);
			this.txtAttendance.TabIndex = 8;
			// 
			// txtTax
			// 
			this.txtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTax.Location = new System.Drawing.Point(269, 234);
			this.txtTax.Name = "txtTax";
			this.txtTax.Size = new System.Drawing.Size(222, 20);
			this.txtTax.TabIndex = 10;
			// 
			// txtNetpay
			// 
			this.txtNetpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNetpay.Location = new System.Drawing.Point(269, 266);
			this.txtNetpay.Name = "txtNetpay";
			this.txtNetpay.Size = new System.Drawing.Size(222, 20);
			this.txtNetpay.TabIndex = 11;
			// 
			// txtCtc
			// 
			this.txtCtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCtc.Location = new System.Drawing.Point(269, 134);
			this.txtCtc.Name = "txtCtc";
			this.txtCtc.Size = new System.Drawing.Size(222, 20);
			this.txtCtc.TabIndex = 12;
			this.txtCtc.Leave += new System.EventHandler(this.txtCtc_Leave);
			// 
			// btGenerate
			// 
			this.btGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btGenerate.Location = new System.Drawing.Point(79, 319);
			this.btGenerate.Name = "btGenerate";
			this.btGenerate.Size = new System.Drawing.Size(98, 23);
			this.btGenerate.TabIndex = 13;
			this.btGenerate.Text = "Generate";
			this.btGenerate.UseVisualStyleBackColor = true;
			this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
			// 
			// btCancel
			// 
			this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btCancel.Location = new System.Drawing.Point(198, 319);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(75, 23);
			this.btCancel.TabIndex = 14;
			this.btCancel.Text = "Cancel";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
			// 
			// btExit
			// 
			this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btExit.Location = new System.Drawing.Point(305, 319);
			this.btExit.Name = "btExit";
			this.btExit.Size = new System.Drawing.Size(75, 23);
			this.btExit.TabIndex = 15;
			this.btExit.Text = "Exit";
			this.btExit.UseVisualStyleBackColor = true;
			this.btExit.Click += new System.EventHandler(this.btExit_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Location = new System.Drawing.Point(269, 198);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(222, 20);
			this.dateTimePicker1.TabIndex = 16;
			// 
			// GeneratePayslip
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(556, 362);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.btExit);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.btGenerate);
			this.Controls.Add(this.txtCtc);
			this.Controls.Add(this.txtNetpay);
			this.Controls.Add(this.txtTax);
			this.Controls.Add(this.txtAttendance);
			this.Controls.Add(this.txtEmpName);
			this.Controls.Add(this.lbNetpay);
			this.Controls.Add(this.lbtax);
			this.Controls.Add(this.lbMonth);
			this.Controls.Add(this.lbAttendance);
			this.Controls.Add(this.lbctc);
			this.Controls.Add(this.lbEmployeename);
			this.Controls.Add(this.lbPayslip);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "GeneratePayslip";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GeneratePayslip";
			this.Load += new System.EventHandler(this.GeneratePayslip_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbPayslip;
		private System.Windows.Forms.Label lbEmployeename;
		private System.Windows.Forms.Label lbctc;
		private System.Windows.Forms.Label lbAttendance;
		private System.Windows.Forms.Label lbMonth;
		private System.Windows.Forms.Label lbtax;
		private System.Windows.Forms.Label lbNetpay;
		private System.Windows.Forms.TextBox txtEmpName;
		private System.Windows.Forms.TextBox txtAttendance;
		private System.Windows.Forms.TextBox txtTax;
		private System.Windows.Forms.TextBox txtNetpay;
		private System.Windows.Forms.TextBox txtCtc;
		private System.Windows.Forms.Button btGenerate;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.Button btExit;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
	}
}