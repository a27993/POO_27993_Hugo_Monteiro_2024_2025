using ObjetosNegocio;
using RegrasNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
	public partial class CriarReservaCliente : Form
	{
		public CriarReservaCliente()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Handles the Click event for the CriarReservaButton (Create Reservation button).
		/// This method attempts to create a new reservation by calling the relevant business logic method.
		/// It checks if the user is logged in, retrieves the input data for accommodation, start date, and end date, and passes them to the business logic layer.
		/// If the user is not logged in, an error message is displayed.
		/// If the data is invalid, an error message is shown.
		/// If the reservation is successfully created, a success message is displayed.
		/// The form is closed after the operation is complete.
		/// </summary>
		/// <param name="sender">The source of the event (CriarReservaButton).</param>
		/// <param name="e">The event data.</param>
		private void CriarReservaButton_Click(object sender, EventArgs e)
		{
			int verificarIdLogado = RegrasUtilizadores.ObterIdLogado();
			if(verificarIdLogado == -1)
			{
				MessageBox.Show("Invalido");
			}
			else
			{
				int verificacao = RegrasReservas.criaReserva(verificarIdLogado, int.Parse(AlojamentoTextBox.Text), DateTime.ParseExact(DataInicioTextBox.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture), DateTime.ParseExact(DataFimTextBox.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture));
				if (verificacao == -1)
				{
					MessageBox.Show("Dados invalidos");
				}
				else MessageBox.Show("Sucesso");
				this.Close();
			}
		}
	}
}
