namespace PayrollSystem
{
	partial class MainMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
			this.label1 = new System.Windows.Forms.Label();
			this.btAddEmp = new System.Windows.Forms.Button();
			this.btAddSalary = new System.Windows.Forms.Button();
			this.btPaySlip = new System.Windows.Forms.Button();
			this.btOk = new System.Windows.Forms.Button();
			this.btExit = new System.Windows.Forms.Button();
			this.btLogout = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(78, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Employee Details";
			// 
			// btAddEmp
			// 
			this.btAddEmp.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btAddEmp.Location = new System.Drawing.Point(36, 62);
			this.btAddEmp.Name = "btAddEmp";
			this.btAddEmp.Size = new System.Drawing.Size(236, 23);
			this.btAddEmp.TabIndex = 1;
			this.btAddEmp.Text = "Add Employee";
			this.btAddEmp.UseVisualStyleBackColor = false;
			this.btAddEmp.Click += new System.EventHandler(this.btAddEmp_Click);
			// 
			// btAddSalary
			// 
			this.btAddSalary.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btAddSalary.Location = new System.Drawing.Point(36, 103);
			this.btAddSalary.Name = "btAddSalary";
			this.btAddSalary.Size = new System.Drawing.Size(236, 23);
			this.btAddSalary.TabIndex = 2;
			this.btAddSalary.Text = "Add Salary";
			this.btAddSalary.UseVisualStyleBackColor = false;
			this.btAddSalary.Click += new System.EventHandler(this.btAddSalary_Click);
			// 
			// btPaySlip
			// 
			this.btPaySlip.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btPaySlip.Location = new System.Drawing.Point(36, 142);
			this.btPaySlip.Name = "btPaySlip";
			this.btPaySlip.Size = new System.Drawing.Size(236, 23);
			this.btPaySlip.TabIndex = 3;
			this.btPaySlip.Text = "Generate Payslips";
			this.btPaySlip.UseVisualStyleBackColor = false;
			this.btPaySlip.Click += new System.EventHandler(this.btPaySlip_Click);
			// 
			// btOk
			// 
			this.btOk.Location = new System.Drawing.Point(36, 194);
			this.btOk.Name = "btOk";
			this.btOk.Size = new System.Drawing.Size(75, 23);
			this.btOk.TabIndex = 4;
			this.btOk.Text = "Ok";
			this.btOk.UseVisualStyleBackColor = true;
			this.btOk.Click += new System.EventHandler(this.btOk_Click);
			// 
			// btExit
			// 
			this.btExit.Location = new System.Drawing.Point(197, 194);
			this.btExit.Name = "btExit";
			this.btExit.Size = new System.Drawing.Size(75, 23);
			this.btExit.TabIndex = 5;
			this.btExit.Text = "Exit";
			this.btExit.UseVisualStyleBackColor = true;
			this.btExit.Click += new System.EventHandler(this.btExit_Click);
			// 
			// btLogout
			// 
			this.btLogout.Location = new System.Drawing.Point(117, 194);
			this.btLogout.Name = "btLogout";
			this.btLogout.Size = new System.Drawing.Size(75, 23);
			this.btLogout.TabIndex = 6;
			this.btLogout.Text = "Logout";
			this.btLogout.UseVisualStyleBackColor = true;
			this.btLogout.Click += new System.EventHandler(this.btlogout_Click);
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(306, 268);
			this.Controls.Add(this.btLogout);
			this.Controls.Add(this.btExit);
			this.Controls.Add(this.btOk);
			this.Controls.Add(this.btPaySlip);
			this.Controls.Add(this.btAddSalary);
			this.Controls.Add(this.btAddEmp);
			this.Controls.Add(this.label1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Name = "MainMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainMenu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btAddEmp;
		private System.Windows.Forms.Button btAddSalary;
		private System.Windows.Forms.Button btPaySlip;
		private System.Windows.Forms.Button btOk;
		private System.Windows.Forms.Button btExit;
		private System.Windows.Forms.Button btLogout;
	}
}