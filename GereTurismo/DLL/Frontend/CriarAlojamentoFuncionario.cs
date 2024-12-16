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
	public partial class CriarAlojamentoFuncionario : Form
	{
		public CriarAlojamentoFuncionario()
		{
			InitializeComponent();
		}

		private void CriarAlojamentoButton_Click(object sender, EventArgs e)
		{
			int verificacao = RegrasAlojamentos.criarAlojamento(LocalizacaoTextBox.Text, double.Parse(PrecoPorNoiteTextBox.Text), int.Parse(CapacidadeTextBox.Text));
			if (verificacao == -1)
			{
				MessageBox.Show("Dados invalidos");
			}
			else MessageBox.Show("Sucesso");
			this.Close();
		}
	}
}
