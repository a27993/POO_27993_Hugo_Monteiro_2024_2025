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

		/// <summary>
		/// Handles the Click event for the CriarAlojamentoButton (Create Accommodation button).
		/// This method attempts to create a new accommodation by calling the relevant business logic method.
		/// It retrieves the input values for location, price per night, and capacity, and passes them to the business logic layer.
		/// If the data is valid, a success message is shown. If the data is invalid, an error message is shown.
		/// The form is closed after the operation is complete.
		/// </summary>
		/// <param name="sender">The source of the event (CriarAlojamentoButton).</param>
		/// <param name="e">The event data.</param>
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
