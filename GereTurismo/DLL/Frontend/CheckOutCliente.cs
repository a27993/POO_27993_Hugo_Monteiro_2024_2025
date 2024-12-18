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
	public partial class CheckOutCliente : Form
	{
		public CheckOutCliente()
		{
			InitializeComponent();
		}

		private void Check_OutButton_Click(object sender, EventArgs e)
		{
			int verificicaoIdCliente = RegrasUtilizadores.ObterIdLogado();
			if(verificicaoIdCliente == -1)
			{
				MessageBox.Show("Cliente invalido");
			}
			else
			{
				int verificacao = RegrasCheck_outs.criarCheckOut(DateTime.Parse(DataTextBox.Text), verificicaoIdCliente, int.Parse(IdAlojamentoTextBox.Text), PagamentoTextBox.Text);

			}
		}
	}
}
