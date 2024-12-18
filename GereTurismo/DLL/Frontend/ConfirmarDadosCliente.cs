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
	public partial class ConfirmarDadosCliente : Form
	{
		public ConfirmarDadosCliente()
		{
			InitializeComponent();
		}

		private void ConfirmarDadosButton_Click(object sender, EventArgs e)
		{
			int verificiacaoIdCliente = RegrasUtilizadores.ObterIdLogado();
			if(verificiacaoIdCliente == -1)
			{
				MessageBox.Show("Cliente invalido");
			}
			else
			{
				int verificacao = RegrasCheck_Ins.confirmaDados(int.Parse(IdReservaTextBox.Text), verificiacaoIdCliente);
				if (verificacao == -3)
				{
					MessageBox.Show("Dados invalidos");
				}
				else if (verificacao == -1)
				{
					MessageBox.Show("Cliente nao tem reserva");
				}
				else if (verificacao == -2)
				{
					MessageBox.Show("Nao existe reserva");
				}
				else MessageBox.Show("Sucesso");
				this.Close();
			}
		}
	}
}
