namespace Frontend
{
	partial class MenuCliente
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
			this.ConsultaAlojamentosButton = new System.Windows.Forms.Button();
			this.ReservaClienteButton = new System.Windows.Forms.Button();
			this.LogoutButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ConsultaAlojamentosButton
			// 
			this.ConsultaAlojamentosButton.Location = new System.Drawing.Point(87, 83);
			this.ConsultaAlojamentosButton.Name = "ConsultaAlojamentosButton";
			this.ConsultaAlojamentosButton.Size = new System.Drawing.Size(98, 37);
			this.ConsultaAlojamentosButton.TabIndex = 0;
			this.ConsultaAlojamentosButton.Text = "Consulta ";
			this.ConsultaAlojamentosButton.UseVisualStyleBackColor = true;
			this.ConsultaAlojamentosButton.Click += new System.EventHandler(this.ConsultaAlojamentosButton_Click);
			// 
			// ReservaClienteButton
			// 
			this.ReservaClienteButton.Location = new System.Drawing.Point(87, 185);
			this.ReservaClienteButton.Name = "ReservaClienteButton";
			this.ReservaClienteButton.Size = new System.Drawing.Size(98, 41);
			this.ReservaClienteButton.TabIndex = 1;
			this.ReservaClienteButton.Text = "Reserva";
			this.ReservaClienteButton.UseVisualStyleBackColor = true;
			this.ReservaClienteButton.Click += new System.EventHandler(this.ReservaClienteButton_Click);
			// 
			// LogoutButton
			// 
			this.LogoutButton.Location = new System.Drawing.Point(227, 287);
			this.LogoutButton.Name = "LogoutButton";
			this.LogoutButton.Size = new System.Drawing.Size(75, 23);
			this.LogoutButton.TabIndex = 2;
			this.LogoutButton.Text = "Logout";
			this.LogoutButton.UseVisualStyleBackColor = true;
			this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
			// 
			// MenuCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(324, 332);
			this.Controls.Add(this.LogoutButton);
			this.Controls.Add(this.ReservaClienteButton);
			this.Controls.Add(this.ConsultaAlojamentosButton);
			this.Name = "MenuCliente";
			this.Text = "MenuCliente";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button ConsultaAlojamentosButton;
		private System.Windows.Forms.Button ReservaClienteButton;
		private System.Windows.Forms.Button LogoutButton;
	}
}