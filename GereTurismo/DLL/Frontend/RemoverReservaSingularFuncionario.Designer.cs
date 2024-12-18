namespace Frontend
{
	partial class RemoverReservaSingularFuncionario
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
			this.RemoverButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.IdReservaTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// RemoverButton
			// 
			this.RemoverButton.Location = new System.Drawing.Point(178, 313);
			this.RemoverButton.Name = "RemoverButton";
			this.RemoverButton.Size = new System.Drawing.Size(75, 23);
			this.RemoverButton.TabIndex = 0;
			this.RemoverButton.Text = "Remover";
			this.RemoverButton.UseVisualStyleBackColor = true;
			this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 161);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "idReserva";
			// 
			// IdReservaTextBox
			// 
			this.IdReservaTextBox.Location = new System.Drawing.Point(110, 154);
			this.IdReservaTextBox.Name = "IdReservaTextBox";
			this.IdReservaTextBox.Size = new System.Drawing.Size(100, 20);
			this.IdReservaTextBox.TabIndex = 2;
			// 
			// RemoverReservaSingularFuncionario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(286, 386);
			this.Controls.Add(this.IdReservaTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.RemoverButton);
			this.Name = "RemoverReservaSingularFuncionario";
			this.Text = "RemoverReservaSingularFuncionario";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button RemoverButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox IdReservaTextBox;
	}
}