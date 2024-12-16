namespace Frontend
{
	partial class RemoverReservasFuncionario
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
			this.RemoverReservaButton = new System.Windows.Forms.Button();
			this.RemoverTodasReservasButton = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// RemoverReservaButton
			// 
			this.RemoverReservaButton.Location = new System.Drawing.Point(128, 147);
			this.RemoverReservaButton.Name = "RemoverReservaButton";
			this.RemoverReservaButton.Size = new System.Drawing.Size(122, 43);
			this.RemoverReservaButton.TabIndex = 0;
			this.RemoverReservaButton.Text = "Remover Reserva";
			this.RemoverReservaButton.UseVisualStyleBackColor = true;
			this.RemoverReservaButton.Click += new System.EventHandler(this.RemoverReservaButton_Click);
			// 
			// RemoverTodasReservasButton
			// 
			this.RemoverTodasReservasButton.Location = new System.Drawing.Point(128, 281);
			this.RemoverTodasReservasButton.Name = "RemoverTodasReservasButton";
			this.RemoverTodasReservasButton.Size = new System.Drawing.Size(122, 52);
			this.RemoverTodasReservasButton.TabIndex = 1;
			this.RemoverTodasReservasButton.Text = "Remover todas as reservas";
			this.RemoverTodasReservasButton.UseVisualStyleBackColor = true;
			this.RemoverTodasReservasButton.Click += new System.EventHandler(this.RemoverTodasReservasButton_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(300, 421);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "Exit";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// RemoverReservasFuncionario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 473);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.RemoverTodasReservasButton);
			this.Controls.Add(this.RemoverReservaButton);
			this.Name = "RemoverReservasFuncionario";
			this.Text = "RemoverReservasFuncionario";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button RemoverReservaButton;
		private System.Windows.Forms.Button RemoverTodasReservasButton;
		private System.Windows.Forms.Button button3;
	}
}