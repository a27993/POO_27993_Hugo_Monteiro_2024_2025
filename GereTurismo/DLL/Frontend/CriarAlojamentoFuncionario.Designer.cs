namespace Frontend
{
	partial class CriarAlojamentoFuncionario
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
			this.CriarAlojamentoButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.CapacidadeTextBox = new System.Windows.Forms.TextBox();
			this.PrecoPorNoiteTextBox = new System.Windows.Forms.TextBox();
			this.LocalizacaoTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// CriarAlojamentoButton
			// 
			this.CriarAlojamentoButton.Location = new System.Drawing.Point(231, 368);
			this.CriarAlojamentoButton.Name = "CriarAlojamentoButton";
			this.CriarAlojamentoButton.Size = new System.Drawing.Size(87, 37);
			this.CriarAlojamentoButton.TabIndex = 0;
			this.CriarAlojamentoButton.Text = "Criar Alojamento";
			this.CriarAlojamentoButton.UseVisualStyleBackColor = true;
			this.CriarAlojamentoButton.Click += new System.EventHandler(this.CriarAlojamentoButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Localizacao";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 173);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Preco por noite";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(38, 253);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "capacidade";
			// 
			// CapacidadeTextBox
			// 
			this.CapacidadeTextBox.Location = new System.Drawing.Point(117, 246);
			this.CapacidadeTextBox.Name = "CapacidadeTextBox";
			this.CapacidadeTextBox.Size = new System.Drawing.Size(154, 20);
			this.CapacidadeTextBox.TabIndex = 4;
			// 
			// PrecoPorNoiteTextBox
			// 
			this.PrecoPorNoiteTextBox.Location = new System.Drawing.Point(117, 166);
			this.PrecoPorNoiteTextBox.Name = "PrecoPorNoiteTextBox";
			this.PrecoPorNoiteTextBox.Size = new System.Drawing.Size(154, 20);
			this.PrecoPorNoiteTextBox.TabIndex = 5;
			// 
			// LocalizacaoTextBox
			// 
			this.LocalizacaoTextBox.Location = new System.Drawing.Point(117, 88);
			this.LocalizacaoTextBox.Name = "LocalizacaoTextBox";
			this.LocalizacaoTextBox.Size = new System.Drawing.Size(154, 20);
			this.LocalizacaoTextBox.TabIndex = 6;
			// 
			// CriarAlojamentoFuncionario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 433);
			this.Controls.Add(this.LocalizacaoTextBox);
			this.Controls.Add(this.PrecoPorNoiteTextBox);
			this.Controls.Add(this.CapacidadeTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CriarAlojamentoButton);
			this.Name = "CriarAlojamentoFuncionario";
			this.Text = "CriarAlojamentoFuncionario";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CriarAlojamentoButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox CapacidadeTextBox;
		private System.Windows.Forms.TextBox PrecoPorNoiteTextBox;
		private System.Windows.Forms.TextBox LocalizacaoTextBox;
	}
}