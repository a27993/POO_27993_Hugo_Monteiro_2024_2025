namespace Frontend
{
	partial class AlterarPassCliente
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
			this.AlterarPassButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.PassNovaTextBox = new System.Windows.Forms.TextBox();
			this.PassAntigaTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// AlterarPassButton
			// 
			this.AlterarPassButton.Location = new System.Drawing.Point(205, 339);
			this.AlterarPassButton.Name = "AlterarPassButton";
			this.AlterarPassButton.Size = new System.Drawing.Size(84, 38);
			this.AlterarPassButton.TabIndex = 0;
			this.AlterarPassButton.Text = "Alterar password";
			this.AlterarPassButton.UseVisualStyleBackColor = true;
			this.AlterarPassButton.Click += new System.EventHandler(this.AlterarPassButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 146);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Password antiga";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 225);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password nova";
			// 
			// PassNovaTextBox
			// 
			this.PassNovaTextBox.Location = new System.Drawing.Point(131, 218);
			this.PassNovaTextBox.Name = "PassNovaTextBox";
			this.PassNovaTextBox.Size = new System.Drawing.Size(134, 20);
			this.PassNovaTextBox.TabIndex = 3;
			// 
			// PassAntigaTextBox
			// 
			this.PassAntigaTextBox.Location = new System.Drawing.Point(131, 143);
			this.PassAntigaTextBox.Name = "PassAntigaTextBox";
			this.PassAntigaTextBox.Size = new System.Drawing.Size(134, 20);
			this.PassAntigaTextBox.TabIndex = 4;
			// 
			// AlterarPassCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(322, 402);
			this.Controls.Add(this.PassAntigaTextBox);
			this.Controls.Add(this.PassNovaTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AlterarPassButton);
			this.Name = "AlterarPassCliente";
			this.Text = "AlterarPassCliente";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button AlterarPassButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox PassNovaTextBox;
		private System.Windows.Forms.TextBox PassAntigaTextBox;
	}
}