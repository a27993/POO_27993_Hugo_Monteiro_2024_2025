namespace Frontend
{
	partial class CheckOutCliente
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
			this.Check_OutButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.PagamentoTextBox = new System.Windows.Forms.TextBox();
			this.IdAlojamentoTextBox = new System.Windows.Forms.TextBox();
			this.DataTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Check_OutButton
			// 
			this.Check_OutButton.Location = new System.Drawing.Point(319, 378);
			this.Check_OutButton.Name = "Check_OutButton";
			this.Check_OutButton.Size = new System.Drawing.Size(86, 36);
			this.Check_OutButton.TabIndex = 0;
			this.Check_OutButton.Text = "Check-Out";
			this.Check_OutButton.UseVisualStyleBackColor = true;
			this.Check_OutButton.Click += new System.EventHandler(this.Check_OutButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(75, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Alojamento";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(75, 161);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Data";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(75, 229);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Pagamento";
			// 
			// PagamentoTextBox
			// 
			this.PagamentoTextBox.Location = new System.Drawing.Point(154, 222);
			this.PagamentoTextBox.Name = "PagamentoTextBox";
			this.PagamentoTextBox.Size = new System.Drawing.Size(176, 20);
			this.PagamentoTextBox.TabIndex = 4;
			// 
			// IdAlojamentoTextBox
			// 
			this.IdAlojamentoTextBox.Location = new System.Drawing.Point(154, 84);
			this.IdAlojamentoTextBox.Name = "IdAlojamentoTextBox";
			this.IdAlojamentoTextBox.Size = new System.Drawing.Size(176, 20);
			this.IdAlojamentoTextBox.TabIndex = 5;
			// 
			// DataTextBox
			// 
			this.DataTextBox.Location = new System.Drawing.Point(154, 154);
			this.DataTextBox.Name = "DataTextBox";
			this.DataTextBox.Size = new System.Drawing.Size(176, 20);
			this.DataTextBox.TabIndex = 6;
			// 
			// CheckOutCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(417, 426);
			this.Controls.Add(this.DataTextBox);
			this.Controls.Add(this.IdAlojamentoTextBox);
			this.Controls.Add(this.PagamentoTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Check_OutButton);
			this.Name = "CheckOutCliente";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Check_OutButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox PagamentoTextBox;
		private System.Windows.Forms.TextBox IdAlojamentoTextBox;
		private System.Windows.Forms.TextBox DataTextBox;
	}
}