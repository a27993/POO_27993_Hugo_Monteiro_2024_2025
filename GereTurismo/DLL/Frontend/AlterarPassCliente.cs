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
	public partial class AlterarPassCliente : Form
	{
		public AlterarPassCliente()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Handles the event triggered when the "AlterarPassButton" is clicked.
		/// This method attempts to change the password of a user based on the input provided in the text boxes.
		/// </summary>
		/// <param name="sender">The source of the event, typically the button that was clicked.</param>
		/// <param name="e">An EventArgs object containing event data.</param>
		private void AlterarPassButton_Click(object sender, EventArgs e)
		{
			int verificacao = RegrasUtilizadores.AlterarPassword(PassAntigaTextBox.Text, PassNovaTextBox.Text);
			if (verificacao == -1)
			{
				MessageBox.Show("Cliente nao existe");
			}
			else if (verificacao == -2)
			{
				MessageBox.Show("Dados invalidos");
			}
			else MessageBox.Show("Sucesso");
			this.Close();
		}
	}
}
