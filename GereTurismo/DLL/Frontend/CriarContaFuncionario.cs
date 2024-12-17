using RegrasNegocio;
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
