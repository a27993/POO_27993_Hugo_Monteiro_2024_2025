namespace Frontend
{
	partial class CriarReservaCliente
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.DataFimTextBox = new System.Windows.Forms.TextBox();
			this.DataInicioTextBox = new System.Windows.Forms.TextBox();
			this.AlojamentoTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// CriarReservaButton
			// 
			this.CriarReservaButton.Location = new System.Drawing.Point(352, 345);
			this.CriarReservaButton.Name = "CriarReservaButton";
			this.CriarReservaButton.Size = new System.Drawing.Size(82, 34);
			this.CriarReservaButton.TabIndex = 0;
			this.CriarReservaButton.Text = "Criar Reserva";
			this.CriarReservaButton.UseVisualStyleBackColor = true;
			this.CriarReservaButton.Click += new System.EventHandler(this.CriarReservaButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(81, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Alojamento";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(82, 170);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Data Inicio";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(90, 233);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Data Fim";
			// 
			// DataFimTextBox
			// 
			this.DataFimTextBox.Location = new System.Drawing.Point(165, 226);
			this.DataFimTextBox.Name = "DataFimTextBox";
			this.DataFimTextBox.Size = new System.Drawing.Size(179, 20);
			this.DataFimTextBox.TabIndex = 5;
			// 
			// DataInicioTextBox
			// 
			this.DataInicioTextBox.Location = new System.Drawing.Point(165, 163);
			this.DataInicioTextBox.Name = "DataInicioTextBox";
			this.DataInicioTextBox.Size = new System.Drawing.Size(179, 20);
			this.DataInicioTextBox.TabIndex = 6;
			// 
			// AlojamentoTextBox
			// 
			this.AlojamentoTextBox.Location = new System.Drawing.Point(165, 103);
			this.AlojamentoTextBox.Name = "AlojamentoTextBox";
			this.AlojamentoTextBox.Size = new System.Drawing.Size(179, 20);
			this.AlojamentoTextBox.TabIndex = 7;
			// 
			// CriarReservaCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(457, 410);
			this.Controls.Add(this.AlojamentoTextBox);
			this.Controls.Add(this.DataInicioTextBox);
			this.Controls.Add(this.DataFimTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.CriarReservaButton);
			this.Name = "CriarReservaCliente";
			this.Text = "CriarReservaCliente";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CriarReservaButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox DataFimTextBox;
		private System.Windows.Forms.TextBox DataInicioTextBox;
		private System.Windows.Forms.TextBox AlojamentoTextBox;
	}
}