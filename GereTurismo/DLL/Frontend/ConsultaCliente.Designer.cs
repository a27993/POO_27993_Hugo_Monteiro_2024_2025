namespace Frontend
{
	partial class ConsultaCliente
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.ClienteComboBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(191, -1);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(456, 433);
			this.listBox1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(29, 383);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Exit";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ClienteComboBox
			// 
			this.ClienteComboBox.FormattingEnabled = true;
			this.ClienteComboBox.Location = new System.Drawing.Point(29, 94);
			this.ClienteComboBox.Name = "ClienteComboBox";
			this.ClienteComboBox.Size = new System.Drawing.Size(135, 21);
			this.ClienteComboBox.TabIndex = 2;
			this.ClienteComboBox.SelectedIndexChanged += new System.EventHandler(this.ClienteComboBox_SelectedIndexChanged);
			// 
			// ConsultaCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(643, 432);
			this.Controls.Add(this.ClienteComboBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBox1);
			this.Name = "ConsultaCliente";
			this.Text = "ConsultaCliente";
			this.Load += new System.EventHandler(this.ConsultaCliente_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox ClienteComboBox;
	}
}