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
	public partial class CriarCheck_in : Form
	{
		public CriarCheck_in()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Event handler for the ConfirmarDadosButton Click event.
		/// This method validates the client ID and attempts to create a Check-In entry using the provided data.
		/// </summary>
		/// <param name="sender">The source of the event (the button that triggered the click).</param>
		/// <param name="e">Event data associated with the button click.</param>
		private void ConfirmarDadosButton_Click(object sender, EventArgs e)
		{
			int verificiacaoIdCliente = RegrasUtilizadores.ObterIdLogado();
			if(verificiacaoIdCliente == -1)
			{
				MessageBox.Show("Cliente invalido");
			}
			else
			{
				int verificacao = RegrasCheck_Ins.criarCheckIn(DateTime.Parse(DataTextBox.Text),verificiacaoIdCliente,int.Parse(AlojamentoTextBox.Text));
				if(verificacao == -1)
				{
					MessageBox.Show("Dados invalidos");
				}
				else
				{
					MessageBox.Show("Sucesso");
				}
				this.Close();
			}
		}
	}
}
