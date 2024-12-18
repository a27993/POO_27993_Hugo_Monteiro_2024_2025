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
			string filePath = @"C:\Users\Hugo\Desktop\repositorio\githugo\POO_27993_Hugo_Monteiro_2024_2025\GereTurismo\";
			RegrasUtilizadores.CarregaUtilizadoresParaLista(filePath + "Utilizadores.txt");
			RegrasReservas.CarregaReservasParaLista(filePath + "Reservas.txt");
			RegrasAlojamentos.CarregaAlojamentosParaLista(filePath + "Alojamentos.txt");
			//RegrasCheck_Ins.CarregaCheckInsParaLista(filePath + "Check_ins.txt");
			//RegrasCheck_outs.CarregaCheckOutsParaLista(filePath + "Check_outs.txt");
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
			this.Hide();
			criarContaCliente.ShowDialog();
			this.Show();
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

		private void ExitButton_Click(object sender, EventArgs e)
		{
			string filePath = @"C:\Users\Hugo\Desktop\repositorio\githugo\POO_27993_Hugo_Monteiro_2024_2025\GereTurismo\";
			RegrasUtilizadores.GuardaUtilizadoresParaFicheiro(filePath + "Utilizadores.txt");
			RegrasAlojamentos.GuardaAlojamentosParaFicheiro(filePath + "Alojamentos.txt");
			RegrasReservas.GuardaReservasParaFicheiro(filePath + "Reservas.txt");
			//RegrasCheck_Ins.GuardaCheckInParaFicheiro(filePath + "Check_ins.txt");
			//RegrasCheck_outs.GuardaCheckOutParaFicheiro(filePath + "Check_outs.txt");
			this.Close();
		}
	}
}
