namespace Frontend
{
	partial class MenuFuncionario
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
			this.ConsultasButton = new System.Windows.Forms.Button();
			this.ReservasButton = new System.Windows.Forms.Button();
			this.AdicionarAlojamentosButton = new System.Windows.Forms.Button();
			this.CriarFuncionarioButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ConsultasButton
			// 
			this.ConsultasButton.Location = new System.Drawing.Point(177, 73);
			this.ConsultasButton.Name = "ConsultasButton";
			this.ConsultasButton.Size = new System.Drawing.Size(75, 29);
			this.ConsultasButton.TabIndex = 0;
			this.ConsultasButton.Text = "Consultas";
			this.ConsultasButton.UseVisualStyleBackColor = true;
			this.ConsultasButton.Click += new System.EventHandler(this.ConsultasButton_Click);
			// 
			// ReservasButton
			// 
			this.ReservasButton.Location = new System.Drawing.Point(177, 149);
			this.ReservasButton.Name = "ReservasButton";
			this.ReservasButton.Size = new System.Drawing.Size(75, 28);
			this.ReservasButton.TabIndex = 1;
			this.ReservasButton.Text = "Reservas";
			this.ReservasButton.UseVisualStyleBackColor = true;
			this.ReservasButton.Click += new System.EventHandler(this.ReservasButton_Click);
			// 
			// AdicionarAlojamentosButton
			// 
			this.AdicionarAlojamentosButton.Location = new System.Drawing.Point(177, 223);
			this.AdicionarAlojamentosButton.Name = "AdicionarAlojamentosButton";
			this.AdicionarAlojamentosButton.Size = new System.Drawing.Size(75, 35);
			this.AdicionarAlojamentosButton.TabIndex = 2;
			this.AdicionarAlojamentosButton.Text = "Adicionar alojamentos";
			this.AdicionarAlojamentosButton.UseVisualStyleBackColor = true;
			this.AdicionarAlojamentosButton.Click += new System.EventHandler(this.AdicionarAlojamentosButton_Click);
			// 
			// CriarFuncionarioButton
			// 
			this.CriarFuncionarioButton.Location = new System.Drawing.Point(177, 301);
			this.CriarFuncionarioButton.Name = "CriarFuncionarioButton";
			this.CriarFuncionarioButton.Size = new System.Drawing.Size(75, 39);
			this.CriarFuncionarioButton.TabIndex = 4;
			this.CriarFuncionarioButton.Text = "Criar Funcionario";
			this.CriarFuncionarioButton.UseVisualStyleBackColor = true;
			this.CriarFuncionarioButton.Click += new System.EventHandler(this.CriarFuncionarioButton_Click);
			// 
			// MenuFuncionario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 461);
			this.Controls.Add(this.CriarFuncionarioButton);
			this.Controls.Add(this.AdicionarAlojamentosButton);
			this.Controls.Add(this.ReservasButton);
			this.Controls.Add(this.ConsultasButton);
			this.Name = "MenuFuncionario";
			this.Text = "MenuFuncionario";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button ConsultasButton;
		private System.Windows.Forms.Button ReservasButton;
		private System.Windows.Forms.Button AdicionarAlojamentosButton;
		private System.Windows.Forms.Button CriarFuncionarioButton;
	}
}