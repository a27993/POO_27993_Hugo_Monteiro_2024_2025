namespace Frontend
{
	partial class Menu
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
			this.criarConta = new System.Windows.Forms.Button();
			this.email = new System.Windows.Forms.Label();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.login = new System.Windows.Forms.Button();
			this.password = new System.Windows.Forms.Label();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.ExitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// criarConta
			// 
			this.criarConta.Location = new System.Drawing.Point(304, 250);
			this.criarConta.Name = "criarConta";
			this.criarConta.Size = new System.Drawing.Size(75, 23);
			this.criarConta.TabIndex = 0;
			this.criarConta.Text = "Criar Conta";
			this.criarConta.UseVisualStyleBackColor = true;
			this.criarConta.Click += new System.EventHandler(this.criarConta_Click);
			// 
			// email
			// 
			this.email.AutoSize = true;
			this.email.Location = new System.Drawing.Point(218, 153);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(32, 13);
			this.email.TabIndex = 1;
			this.email.Text = "Email";
			this.email.Click += new System.EventHandler(this.email_Click);
			// 
			// emailTextBox
			// 
			this.emailTextBox.Location = new System.Drawing.Point(304, 146);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(230, 20);
			this.emailTextBox.TabIndex = 2;
			this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
			// 
			// login
			// 
			this.login.Location = new System.Drawing.Point(459, 250);
			this.login.Name = "login";
			this.login.Size = new System.Drawing.Size(75, 23);
			this.login.TabIndex = 3;
			this.login.Text = "Login";
			this.login.UseVisualStyleBackColor = true;
			this.login.Click += new System.EventHandler(this.login_Click);
			// 
			// password
			// 
			this.password.AutoSize = true;
			this.password.Location = new System.Drawing.Point(218, 209);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(53, 13);
			this.password.TabIndex = 4;
			this.password.Text = "Password";
			this.password.Click += new System.EventHandler(this.password_Click);
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(304, 202);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(230, 20);
			this.passwordTextBox.TabIndex = 5;
			this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(687, 399);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(75, 23);
			this.ExitButton.TabIndex = 6;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.password);
			this.Controls.Add(this.login);
			this.Controls.Add(this.emailTextBox);
			this.Controls.Add(this.email);
			this.Controls.Add(this.criarConta);
			this.Name = "Menu";
			this.Text = "Menu";
			this.Load += new System.EventHandler(this.Menu_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button criarConta;
		private System.Windows.Forms.Label email;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.Button login;
		private System.Windows.Forms.Label password;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Button ExitButton;
	}
}