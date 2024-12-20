using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjetosNegocio;
using RegrasNegocio;

namespace Frontend
{
	public partial class Menu : Form
	{
		/// <summary>
		/// Initializes a new instance of the Menu class.
		/// This constructor is responsible for loading necessary data files (users, reservations, and accommodations) from specified file paths.
		/// It calls methods from the business logic layer to load the data into the respective lists.
		/// Additionally, it initializes the components for the form.
		/// </summary>
		public Menu()
		{
			string filePath = @"C:\Users\Hugo\Desktop\repositorio\githugo\POO_27993_Hugo_Monteiro_2024_2025\GereTurismo\";
			RegrasUtilizadores.CarregaUtilizadoresParaLista(filePath + "Utilizadores.txt");
			RegrasReservas.CarregaReservasParaLista(filePath + "Reservas.txt");
			RegrasAlojamentos.CarregaAlojamentosParaLista(filePath + "Alojamentos.txt");
			RegrasCheck_Ins.CarregaCheckInsParaLista(filePath + "Check_ins.txt");
			RegrasCheck_outs.CarregaCheckOutsParaLista(filePath + "Check_outs.txt");
			InitializeComponent();
		}

		private void email_Click(object sender, EventArgs e)
		{

		}

		private void password_Click(object sender, EventArgs e)
		{

		}

		private void emailTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void passwordTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Handles the Click event for the "Create Account" button.
		/// This method opens the "Create Account" form (CriarContaCliente) for the user to register a new account.
		/// It hides the current form, shows the "CriarContaCliente" form, and then shows the original form again when the user closes the "CriarContaCliente" form.
		/// </summary>
		/// <param name="sender">The source of the event (criarConta button).</param>
		/// <param name="e">The event data.</param>
		private void criarConta_Click(object sender, EventArgs e)
		{
			CriarContaCliente criarContaCliente = new CriarContaCliente();
			this.Hide();
			criarContaCliente.ShowDialog();
			this.Show();
		}

		/// <summary>
		/// Handles the Click event for the "Login" button.
		/// This method attempts to log in the user by verifying their email and password.
		/// If the login is successful, it redirects the user to the appropriate menu based on their user type (employee or client).
		/// If the login fails, an error message is displayed indicating the issue (invalid data, non-existent email, or incorrect password).
		/// </summary>
		/// <param name="sender">The source of the event (login button).</param>
		/// <param name="e">The event data.</param>
		private void login_Click(object sender, EventArgs e)
		{
			int verificacao = RegrasUtilizadores.Login(emailTextBox.Text, passwordTextBox.Text);
			if (verificacao == -1)
			{
				MessageBox.Show("Dados Invalidos");
			}
			else if (verificacao == -2)
			{
				MessageBox.Show("Email nao existe");
			}
			else if (verificacao == -3)
			{
				MessageBox.Show("Password errada");
			}
			else
			{
				int tipoLogado = RegrasUtilizadores.ObterTipoLogado();
				if (tipoLogado == 1)
				{
					MenuFuncionario menuFuncionario = new MenuFuncionario();
					this.Hide();
					menuFuncionario.ShowDialog();
					this.Show();
				}
				else if (tipoLogado == 0)
				{
					MenuCliente menuCliente = new MenuCliente();
					this.Hide();
					menuCliente.ShowDialog();
					this.Show();
				}
			}
		}

		private void Menu_Load(object sender, EventArgs e)
		{
			
		}

		/// <summary>
		/// Handles the Click event for the "Exit" button.
		/// This method is responsible for saving all necessary data to external files before the application is closed.
		/// It calls methods from the business logic layer to save the users, accommodations, and reservations data to the respective text files.
		/// The check-in and check-out data saving is currently commented out, but could be included in the future.
		/// After saving the data, the form is closed.
		/// </summary>
		/// <param name="sender">The source of the event (Exit button).</param>
		/// <param name="e">The event data.</param>
		private void ExitButton_Click(object sender, EventArgs e)
		{
			string filePath = @"C:\Users\Hugo\Desktop\repositorio\githugo\POO_27993_Hugo_Monteiro_2024_2025\GereTurismo\";
			RegrasUtilizadores.GuardaUtilizadoresParaFicheiro(filePath + "Utilizadores.txt");
			RegrasAlojamentos.GuardaAlojamentosParaFicheiro(filePath + "Alojamentos.txt");
			RegrasReservas.GuardaReservasParaFicheiro(filePath + "Reservas.txt");
			RegrasCheck_Ins.GuardaCheckInParaFicheiro(filePath + "Check_ins.txt");
			RegrasCheck_outs.GuardaCheckOutParaFicheiro(filePath + "Check_outs.txt");
			this.Close();
		}
	}
}
