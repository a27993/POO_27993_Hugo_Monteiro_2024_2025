﻿namespace Frontend
{
	partial class ConfirmarDadosCliente
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
			this.ConfirmarDadosButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.IdReservaTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// ConfirmarDadosButton
			// 
			this.ConfirmarDadosButton.Location = new System.Drawing.Point(170, 235);
			this.ConfirmarDadosButton.Name = "ConfirmarDadosButton";
			this.ConfirmarDadosButton.Size = new System.Drawing.Size(77, 38);
			this.ConfirmarDadosButton.TabIndex = 0;
			this.ConfirmarDadosButton.Text = "Confirmar dados";
			this.ConfirmarDadosButton.UseVisualStyleBackColor = true;
			this.ConfirmarDadosButton.Click += new System.EventHandler(this.ConfirmarDadosButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 115);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Id Reserva";
			// 
			// IdReservaTextBox
			// 
			this.IdReservaTextBox.Location = new System.Drawing.Point(93, 112);
			this.IdReservaTextBox.Name = "IdReservaTextBox";
			this.IdReservaTextBox.Size = new System.Drawing.Size(100, 20);
			this.IdReservaTextBox.TabIndex = 2;
			// 
			// ConfirmarDadosCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(268, 300);
			this.Controls.Add(this.IdReservaTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ConfirmarDadosButton);
			this.Name = "ConfirmarDadosCliente";
			this.Text = "ConfirmarDadosCliente";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ConfirmarDadosButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox IdReservaTextBox;
	}
}