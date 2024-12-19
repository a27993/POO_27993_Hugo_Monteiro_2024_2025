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
	public partial class RemoverReservasFuncionario : Form
	{
		public RemoverReservasFuncionario()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Handles the Click event for the "Exit" button (button3).
		/// This method simply closes the current form when the "Exit" button is clicked.
		/// </summary>
		/// <param name="sender">The source of the event (button3).</param>
		/// <param name="e">The event data.</param>
		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// Handles the Click event for the "Remover Todas Reservas" button.
		/// This method calls the `removeTodasReservas` function from the `RegrasReservas` class to remove all reservations.
		/// </summary>
		/// <param name="sender">The source of the event (RemoverTodasReservasButton).</param>
		/// <param name="e">The event data.</param>
		private void RemoverTodasReservasButton_Click(object sender, EventArgs e)
		{
			RegrasReservas.removeTodasReservas();
		}

		/// <summary>
		/// Handles the Click event for the "Remover Reserva" button.
		/// This method opens the "RemoverReservaSingularFuncionario" form to allow the user to remove a specific reservation.
		/// It hides the current form, shows the "RemoverReservaSingularFuncionario" form, and then shows the original form again when the user closes the "RemoverReservaSingularFuncionario" form.
		/// </summary>
		/// <param name="sender">The source of the event (RemoverReservaButton).</param>
		private void RemoverReservaButton_Click(object sender, EventArgs e)
		{
			RemoverReservaSingularFuncionario removerReservaSigularFuncionario = new RemoverReservaSingularFuncionario();
			this.Hide();
			removerReservaSigularFuncionario.ShowDialog();
			this.Show();
		}
	}
}
