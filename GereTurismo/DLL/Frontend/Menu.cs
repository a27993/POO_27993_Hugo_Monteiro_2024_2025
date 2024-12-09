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

		}

		private void Menu_Load(object sender, EventArgs e)
		{

		}
	}
}
