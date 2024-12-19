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

		/// <summary>
		/// Handles the Click event for the ConfirmarDadosButton (Confirm Data Button).
		/// This method performs several checks and confirmations related to the user's reservation data.
		/// It first checks if the logged-in client is valid, and if so, it confirms the client's reservation.
		/// Depending on the outcome of the reservation check, an appropriate message is displayed.
		/// </summary>
		/// <param name="sender">The source of the event (ConfirmarDadosButton).</param>
		/// <param name="e">The event data.</param>
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
