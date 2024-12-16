namespace Frontend
{
	partial class ReservasFuncionario
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
			this.Exit = new System.Windows.Forms.Button();
			this.CriarReservaButton = new System.Windows.Forms.Button();
			this.RemoverReservaButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Exit
			// 
			this.Exit.Location = new System.Drawing.Point(330, 456);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(85, 38);
			this.Exit.TabIndex = 0;
			this.Exit.Text = "Exit";
			this.Exit.UseVisualStyleBackColor = true;
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// CriarReservaButton
			// 
			this.CriarReservaButton.Location = new System.Drawing.Point(158, 150);
			this.CriarReservaButton.Name = "CriarReservaButton";
			this.CriarReservaButton.Size = new System.Drawing.Size(98, 46);
			this.CriarReservaButton.TabIndex = 1;
			this.CriarReservaButton.Text = "Criar Reserva";
			this.CriarReservaButton.UseVisualStyleBackColor = true;
			this.CriarReservaButton.Click += new System.EventHandler(this.CriarReservaButton_Click);
			// 
			// RemoverReservaButton
			// 
			this.RemoverReservaButton.Location = new System.Drawing.Point(158, 300);
			this.RemoverReservaButton.Name = "RemoverReservaButton";
			this.RemoverReservaButton.Size = new System.Drawing.Size(98, 52);
			this.RemoverReservaButton.TabIndex = 2;
			this.RemoverReservaButton.Text = "Remover Reservas";
			this.RemoverReservaButton.UseVisualStyleBackColor = true;
			this.RemoverReservaButton.Click += new System.EventHandler(this.RemoverReservaButton_Click);
			// 
			// ReservasFuncionario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(465, 537);
			this.Controls.Add(this.RemoverReservaButton);
			this.Controls.Add(this.CriarReservaButton);
			this.Controls.Add(this.Exit);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "ReservasFuncionario";
			this.Text = "ReservasFuncionario";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.Button CriarReservaButton;
		private System.Windows.Forms.Button RemoverReservaButton;
	}
}