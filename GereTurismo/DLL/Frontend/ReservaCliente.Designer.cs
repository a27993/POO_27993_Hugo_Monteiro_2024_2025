namespace Frontend
{
	partial class ReservaCliente
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
			this.CriarReservaButton = new System.Windows.Forms.Button();
			this.ConfirmarCheckIn = new System.Windows.Forms.Button();
			this.CheckOutButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// CriarReservaButton
			// 
			this.CriarReservaButton.Location = new System.Drawing.Point(143, 84);
			this.CriarReservaButton.Name = "CriarReservaButton";
			this.CriarReservaButton.Size = new System.Drawing.Size(85, 34);
			this.CriarReservaButton.TabIndex = 0;
			this.CriarReservaButton.Text = "Criar Reserva";
			this.CriarReservaButton.UseVisualStyleBackColor = true;
			this.CriarReservaButton.Click += new System.EventHandler(this.CriarReservaButton_Click);
			// 
			// ConfirmarCheckIn
			// 
			this.ConfirmarCheckIn.Location = new System.Drawing.Point(143, 166);
			this.ConfirmarCheckIn.Name = "ConfirmarCheckIn";
			this.ConfirmarCheckIn.Size = new System.Drawing.Size(85, 36);
			this.ConfirmarCheckIn.TabIndex = 1;
			this.ConfirmarCheckIn.Text = "Check-in";
			this.ConfirmarCheckIn.UseVisualStyleBackColor = true;
			this.ConfirmarCheckIn.Click += new System.EventHandler(this.ConfirmarCheckIn_Click);
			// 
			// CheckOutButton
			// 
			this.CheckOutButton.Location = new System.Drawing.Point(143, 246);
			this.CheckOutButton.Name = "CheckOutButton";
			this.CheckOutButton.Size = new System.Drawing.Size(85, 35);
			this.CheckOutButton.TabIndex = 2;
			this.CheckOutButton.Text = "Check-out";
			this.CheckOutButton.UseVisualStyleBackColor = true;
			this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(301, 343);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(75, 23);
			this.ExitButton.TabIndex = 3;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// ReservaCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(388, 389);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.CheckOutButton);
			this.Controls.Add(this.ConfirmarCheckIn);
			this.Controls.Add(this.CriarReservaButton);
			this.Name = "ReservaCliente";
			this.Text = "ReservaCliente";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button CriarReservaButton;
		private System.Windows.Forms.Button ConfirmarCheckIn;
		private System.Windows.Forms.Button CheckOutButton;
		private System.Windows.Forms.Button ExitButton;
	}
}