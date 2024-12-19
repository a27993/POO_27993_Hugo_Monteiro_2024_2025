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
	public partial class RemoverReservaSingularFuncionario : Form
	{
		public RemoverReservaSingularFuncionario()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Handles the Click event for the "Remover Reserva" button.
		/// This method attempts to remove a reservation based on the reservation ID entered in the `IdReservaTextBox`.
		/// If the ID is invalid, it displays an error message. If the removal is successful, it displays a success message.
		/// After completing the operation, the current form is closed.
		/// </summary>
		/// <param name="sender">The source of the event (RemoverButton).</param>
		/// <param name="e">The event data.</param>
		private void RemoverButton_Click(object sender, EventArgs e)
		{
			int verificacao = RegrasReservas.removeReserva(int.Parse(IdReservaTextBox.Text));
			if (verificacao == -2)
			{
				MessageBox.Show("Id invalido");
			}
			else MessageBox.Show("Sucesso");
			this.Close();
		}
	}
}
