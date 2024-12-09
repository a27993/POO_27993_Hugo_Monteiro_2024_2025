namespace Frontend
{
	partial class CriarContaCliente
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
			this.nifText = new System.Windows.Forms.TextBox();
			this.ccText = new System.Windows.Forms.TextBox();
			this.telemovelText = new System.Windows.Forms.TextBox();
			this.passwordText = new System.Windows.Forms.TextBox();
			this.emailText = new System.Windows.Forms.TextBox();
			this.nomeText = new System.Windows.Forms.TextBox();
			this.nome_Label = new System.Windows.Forms.Label();
			this.password = new System.Windows.Forms.Label();
			this.telemovel = new System.Windows.Forms.Label();
			this.nif = new System.Windows.Forms.Label();
			this.email = new System.Windows.Forms.Label();
			this.cc = new System.Windows.Forms.Label();
			this.criarContaButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// nifText
			// 
			this.nifText.Location = new System.Drawing.Point(222, 384);
			this.nifText.Name = "nifText";
			this.nifText.Size = new System.Drawing.Size(167, 20);
			this.nifText.TabIndex = 0;
			// 
			// ccText
			// 
			this.ccText.Location = new System.Drawing.Point(222, 318);
			this.ccText.Name = "ccText";
			this.ccText.Size = new System.Drawing.Size(167, 20);
			this.ccText.TabIndex = 1;
			// 
			// telemovelText
			// 
			this.telemovelText.Location = new System.Drawing.Point(222, 250);
			this.telemovelText.Name = "telemovelText";
			this.telemovelText.Size = new System.Drawing.Size(167, 20);
			this.telemovelText.TabIndex = 2;
			// 
			// passwordText
			// 
			this.passwordText.Location = new System.Drawing.Point(222, 195);
			this.passwordText.Name = "passwordText";
			this.passwordText.Size = new System.Drawing.Size(167, 20);
			this.passwordText.TabIndex = 3;
			// 
			// emailText
			// 
			this.emailText.Location = new System.Drawing.Point(222, 134);
			this.emailText.Name = "emailText";
			this.emailText.Size = new System.Drawing.Size(167, 20);
			this.emailText.TabIndex = 4;
			// 
			// nomeText
			// 
			this.nomeText.Location = new System.Drawing.Point(222, 75);
			this.nomeText.Name = "nomeText";
			this.nomeText.Size = new System.Drawing.Size(167, 20);
			this.nomeText.TabIndex = 5;
			// 
			// nome_Label
			// 
			this.nome_Label.AutoSize = true;
			this.nome_Label.Location = new System.Drawing.Point(164, 82);
			this.nome_Label.Name = "nome_Label";
			this.nome_Label.Size = new System.Drawing.Size(35, 13);
			this.nome_Label.TabIndex = 6;
			this.nome_Label.Text = "Nome";
			// 
			// password
			// 
			this.password.AutoSize = true;
			this.password.Location = new System.Drawing.Point(146, 202);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(53, 13);
			this.password.TabIndex = 8;
			this.password.Text = "Password";
			// 
			// telemovel
			// 
			this.telemovel.AutoSize = true;
			this.telemovel.Location = new System.Drawing.Point(143, 257);
			this.telemovel.Name = "telemovel";
			this.telemovel.Size = new System.Drawing.Size(56, 13);
			this.telemovel.TabIndex = 9;
			this.telemovel.Text = "Telemovel";
			// 
			// nif
			// 
			this.nif.AutoSize = true;
			this.nif.Location = new System.Drawing.Point(175, 391);
			this.nif.Name = "nif";
			this.nif.Size = new System.Drawing.Size(24, 13);
			this.nif.TabIndex = 11;
			this.nif.Text = "NIF";
			// 
			// email
			// 
			this.email.AutoSize = true;
			this.email.Location = new System.Drawing.Point(167, 141);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(32, 13);
			this.email.TabIndex = 12;
			this.email.Text = "Email";
			// 
			// cc
			// 
			this.cc.AutoSize = true;
			this.cc.Location = new System.Drawing.Point(178, 325);
			this.cc.Name = "cc";
			this.cc.Size = new System.Drawing.Size(21, 13);
			this.cc.TabIndex = 13;
			this.cc.Text = "CC";
			// 
			// criarContaButton
			// 
			this.criarContaButton.Location = new System.Drawing.Point(382, 441);
			this.criarContaButton.Name = "criarContaButton";
			this.criarContaButton.Size = new System.Drawing.Size(80, 29);
			this.criarContaButton.TabIndex = 14;
			this.criarContaButton.Text = "Criar Conta";
			this.criarContaButton.UseVisualStyleBackColor = true;
			this.criarContaButton.Click += new System.EventHandler(this.criarContaButton_Click);
			// 
			// CriarContaCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(611, 517);
			this.Controls.Add(this.criarContaButton);
			this.Controls.Add(this.cc);
			this.Controls.Add(this.email);
			this.Controls.Add(this.nif);
			this.Controls.Add(this.telemovel);
			this.Controls.Add(this.password);
			this.Controls.Add(this.nome_Label);
			this.Controls.Add(this.nomeText);
			this.Controls.Add(this.emailText);
			this.Controls.Add(this.passwordText);
			this.Controls.Add(this.telemovelText);
			this.Controls.Add(this.ccText);
			this.Controls.Add(this.nifText);
			this.Name = "CriarContaCliente";
			this.Text = "CriarContaCliente";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox nifText;
		private System.Windows.Forms.TextBox ccText;
		private System.Windows.Forms.TextBox telemovelText;
		private System.Windows.Forms.TextBox passwordText;
		private System.Windows.Forms.TextBox emailText;
		private System.Windows.Forms.TextBox nomeText;
		private System.Windows.Forms.Label nome_Label;
		private System.Windows.Forms.Label password;
		private System.Windows.Forms.Label telemovel;
		private System.Windows.Forms.Label nif;
		private System.Windows.Forms.Label email;
		private System.Windows.Forms.Label cc;
		private System.Windows.Forms.Button criarContaButton;
	}
}