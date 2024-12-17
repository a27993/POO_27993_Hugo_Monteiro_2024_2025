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
		public Menu()
		{
			string filePath = @"C:\Users\Hugo\Desktop\repositorio\githugo\POO_27993_Hugo_Monteiro_2024_2025\GereTurismo\Utilizadores.txt";
			RegrasUtilizadores.CarregaUtilizadoresParaLista(filePath);
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

		private void criarConta_Click(object sender, EventArgs e)
		{
			CriarContaCliente criarContaCliente = new CriarContaCliente();
			criarContaCliente.Show();
		}

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
				MessageBox.Show(tipoLogado.ToString());
				if (tipoLogado == 1)
				{
					MenuFuncionario menuFuncionario = new MenuFuncionario();
					menuFuncionario.Show();
				}
				else if (tipoLogado == 0)
				{
					MenuCliente menuCliente = new MenuCliente();
					menuCliente.Show();
				}
			}
		}

		private void Menu_Load(object sender, EventArgs e)
		{
			
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			
			this.Close();
		}
	}
}
