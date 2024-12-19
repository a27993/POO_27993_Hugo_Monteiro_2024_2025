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
				int verificacao = RegrasCheck_outs.criarCheckOut(DateTime.Parse(DataTextBox.Text), verificicaoIdCliente, int.Parse(IdAlojamentoTextBox.Text), double.Parse(PagamentoTextBox.Text));
				if(verificacao == -1)
				{
					MessageBox.Show("Dados Invalidos");
				}
				else
				{
					if(double.Parse(PagamentoTextBox.Text) >= 1.00)
					{
						MessageBox.Show("Sucesso");
						this.Close();
					}
					else
					{
						MessageBox.Show("Pagamento nao foi realizado");
						this.Close();
					}
				}
			}
		}
	}
}
