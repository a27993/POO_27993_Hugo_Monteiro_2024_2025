﻿using RegrasNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
	public partial class CriarContaFuncionario : Form
	{
		public CriarContaFuncionario()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Handles the Click event for the criarContaButton (Create Account button) for creating a new employee account.
		/// This method attempts to create a new employee by calling the relevant business logic method.
		/// It retrieves the input values for name, ID card, email, phone number, tax ID, and password, and passes them to the business logic layer.
		/// If the data is invalid or the email is already registered, appropriate error messages are displayed.
		/// If the employee is successfully created, a success message is shown.
		/// The form is closed after the operation is complete.
		/// </summary>
		/// <param name="sender">The source of the event (criarContaButton).</param>
		/// <param name="e">The event data.</param>
		private void criarContaButton_Click(object sender, EventArgs e)
		{
			int verificacao = RegrasUtilizadores.criarFuncionario(nomeText.Text, ccText.Text, emailText.Text, telemovelText.Text, nifText.Text, passwordText.Text);
			if (verificacao == -2)
			{
				MessageBox.Show("Dados invalidos");
			}
			else if (verificacao == -1)
			{
				MessageBox.Show("Email ja registado");
			}
			else MessageBox.Show("Sucesso");
			this.Close();
		}
	}
}
