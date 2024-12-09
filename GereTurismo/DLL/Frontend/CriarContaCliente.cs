using ObjetosNegocio;
using RegrasNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
	public partial class CriarContaCliente : Form
	{
		public CriarContaCliente()
		{
			InitializeComponent();
		}

		private void criarContaButton_Click(object sender, EventArgs e)
		{
			if (RegrasUtilizadores.criarCliente(nomeText.Text, ccText.Text, emailText.Text, telemovelText.Text, nifText.Text, passwordText.Text) == -1)
			{
				MessageBox.Show("Email ja registado");
			}
			else if (RegrasUtilizadores.criarCliente(nomeText.Text, ccText.Text, emailText.Text, telemovelText.Text, nifText.Text, passwordText.Text) == -2)
			{
				MessageBox.Show("Dados invalidos");
			}
			else MessageBox.Show("Sucesso");
			List<Utilizador> u = Consultas.mostrarTodosUtilizadores();
			if (u == null)
			{
				MessageBox.Show("Sem utilizadores");
			}
			else
			{
				foreach(var utilizador in u)
				{
					MessageBox.Show($"{utilizador.Nome},{utilizador.Email}");
				}
			}
			this.Close();
		}
	}
}
