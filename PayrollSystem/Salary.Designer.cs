namespace PayrollSystem
{
	partial class Salary
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
			this.lbEmpName = new System.Windows.Forms.Label();
			this.lbAllowence = new System.Windows.Forms.Label();
			this.lbCtc = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lbBasic = new System.Windows.Forms.Label();
			this.lbPf = new System.Windows.Forms.Label();
			this.txtEmpName = new System.Windows.Forms.TextBox();
			this.txtCtc = new System.Windows.Forms.TextBox();
			this.txtAllowence = new System.Windows.Forms.TextBox();
			this.txtBasic = new System.Windows.Forms.TextBox();
			this.txtPf = new System.Windows.Forms.TextBox();
			this.lbEmpSalary = new System.Windows.Forms.Label();
			this.btSave = new System.Windows.Forms.Button();
			this.btBack = new System.Windows.Forms.Button();
			this.btExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbEmpName
			// 
			this.lbEmpName.AutoSize = true;
			this.lbEmpName.BackColor = System.Drawing.Color.Transparent;
			this.lbEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbEmpName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbEmpName.Location = new System.Drawing.Point(44, 45);
			this.lbEmpName.Name = "lbEmpName";
			this.lbEmpName.Size = new System.Drawing.Size(125, 20);
			this.lbEmpName.TabIndex = 0;
			this.lbEmpName.Text = "EmployeeName ";
			// 
			// lbAllowence
			// 
			this.lbAllowence.AutoSize = true;
			this.lbAllowence.BackColor = System.Drawing.Color.Transparent;
			this.lbAllowence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAllowence.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbAllowence.Location = new System.Drawing.Point(44, 102);
			this.lbAllowence.Name = "lbAllowence";
			this.lbAllowence.Size = new System.Drawing.Size(81, 20);
			this.lbAllowence.TabIndex = 1;
			this.lbAllowence.Text = "Allowence";
			// 
			// lbCtc
			// 
			this.lbCtc.AutoSize = true;
			this.lbCtc.BackColor = System.Drawing.Color.Transparent;
			this.lbCtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCtc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbCtc.Location = new System.Drawing.Point(44, 75);
			this.lbCtc.Name = "lbCtc";
			this.lbCtc.Size = new System.Drawing.Size(40, 20);
			this.lbCtc.TabIndex = 2;
			this.lbCtc.Text = "CTC";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(44, 135);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(0, 13);
			this.label4.TabIndex = 3;
			// 
			// lbBasic
			// 
			this.lbBasic.AutoSize = true;
			this.lbBasic.BackColor = System.Drawing.Color.Transparent;
			this.lbBasic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbBasic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbBasic.Location = new System.Drawing.Point(44, 128);
			this.lbBasic.Name = "lbBasic";
			this.lbBasic.Size = new System.Drawing.Size(48, 20);
			this.lbBasic.TabIndex = 4;
			this.lbBasic.Text = "Basic";
			// 
			// lbPf
			// 
			this.lbPf.AutoSize = true;
			this.lbPf.BackColor = System.Drawing.Color.Transparent;
			this.lbPf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbPf.Location = new System.Drawing.Point(44, 154);
			this.lbPf.Name = "lbPf";
			this.lbPf.Size = new System.Drawing.Size(29, 20);
			this.lbPf.TabIndex = 5;
			this.lbPf.Text = "PF";
			// 
			// txtEmpName
			// 
			this.txtEmpName.Location = new System.Drawing.Point(194, 47);
			this.txtEmpName.Name = "txtEmpName";
			this.txtEmpName.Size = new System.Drawing.Size(100, 20);
			this.txtEmpName.TabIndex = 6;
			// 
			// txtCtc
			// 
			this.txtCtc.Location = new System.Drawing.Point(194, 73);
			this.txtCtc.Name = "txtCtc";
			this.txtCtc.Size = new System.Drawing.Size(100, 20);
			this.txtCtc.TabIndex = 7;
			this.txtCtc.Leave += new System.EventHandler(this.txtCtc_Leave);
			// 
			// txtAllowence
			// 
			this.txtAllowence.Enabled = false;
			this.txtAllowence.Location = new System.Drawing.Point(194, 102);
			this.txtAllowence.Name = "txtAllowence";
			this.txtAllowence.Size = new System.Drawing.Size(100, 20);
			this.txtAllowence.TabIndex = 8;
			this.txtAllowence.Leave += new System.EventHandler(this.txtCtc_Leave);
			// 
			// txtBasic
			// 
			this.txtBasic.Enabled = false;
			this.txtBasic.Location = new System.Drawing.Point(194, 128);
			this.txtBasic.Name = "txtBasic";
			this.txtBasic.Size = new System.Drawing.Size(100, 20);
			this.txtBasic.TabIndex = 9;
			// 
			// txtPf
			// 
			this.txtPf.Enabled = false;
			this.txtPf.Location = new System.Drawing.Point(194, 156);
			this.txtPf.Name = "txtPf";
			this.txtPf.Size = new System.Drawing.Size(100, 20);
			this.txtPf.TabIndex = 10;
			// 
			// lbEmpSalary
			// 
			this.lbEmpSalary.AutoSize = true;
			this.lbEmpSalary.BackColor = System.Drawing.Color.Transparent;
			this.lbEmpSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbEmpSalary.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lbEmpSalary.Location = new System.Drawing.Point(99, 9);
			this.lbEmpSalary.Name = "lbEmpSalary";
			this.lbEmpSalary.Size = new System.Drawing.Size(176, 20);
			this.lbEmpSalary.TabIndex = 11;
			this.lbEmpSalary.Text = "Employee SalaryDetails";
			// 
			// btSave
			// 
			this.btSave.Location = new System.Drawing.Point(47, 194);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(75, 23);
			this.btSave.TabIndex = 12;
			this.btSave.Text = "Save";
			this.btSave.UseVisualStyleBackColor = true;
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			// 
			// btBack
			// 
			this.btBack.Location = new System.Drawing.Point(128, 194);
			this.btBack.Name = "btBack";
			this.btBack.Size = new System.Drawing.Size(75, 23);
			this.btBack.TabIndex = 13;
			this.btBack.Text = "Back";
			this.btBack.UseVisualStyleBackColor = true;
			this.btBack.Click += new System.EventHandler(this.btBack_Click);
			// 
			// btExit
			// 
			this.btExit.Location = new System.Drawing.Point(219, 194);
			this.btExit.Name = "btExit";
			this.btExit.Size = new System.Drawing.Size(75, 23);
			this.btExit.TabIndex = 14;
			this.btExit.Text = "Exit";
			this.btExit.UseVisualStyleBackColor = true;
			this.btExit.Click += new System.EventHandler(this.btExit_Click);
			// 
			// Salary
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(355, 248);
			this.Controls.Add(this.btExit);
			this.Controls.Add(this.btBack);
			this.Controls.Add(this.btSave);
			this.Controls.Add(this.lbEmpSalary);
			this.Controls.Add(this.txtPf);
			this.Controls.Add(this.txtBasic);
			this.Controls.Add(this.txtAllowence);
			this.Controls.Add(this.txtCtc);
			this.Controls.Add(this.txtEmpName);
			this.Controls.Add(this.lbPf);
			this.Controls.Add(this.lbBasic);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lbCtc);
			this.Controls.Add(this.lbAllowence);
			this.Controls.Add(this.lbEmpName);
			this.Name = "Salary";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SalaryDetails";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbEmpName;
		private System.Windows.Forms.Label lbAllowence;
		private System.Windows.Forms.Label lbCtc;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbBasic;
		private System.Windows.Forms.Label lbPf;
		private System.Windows.Forms.TextBox txtEmpName;
		private System.Windows.Forms.TextBox txtCtc;
		private System.Windows.Forms.TextBox txtAllowence;
		private System.Windows.Forms.TextBox txtBasic;
		private System.Windows.Forms.TextBox txtPf;
		private System.Windows.Forms.Label lbEmpSalary;
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.Button btBack;
		private System.Windows.Forms.Button btExit;
	}
}