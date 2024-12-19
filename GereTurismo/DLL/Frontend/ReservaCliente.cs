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
	public partial class ReservaCliente : Form
	{
		public ReservaCliente()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Handles the Click event for the "Criar Reserva" button.
		/// This method opens the "CriarReservaCliente" form to allow the user to create a reservation.
		/// It hides the current form, shows the "CriarReservaCliente" form, and then shows the original form again when the user closes the "CriarReservaCliente" form.
		/// </summary>
		/// <param name="sender">The source of the event (CriarReservaButton).</param>
		/// <param name="e">The event data.</param>
		private void CriarReservaButton_Click(object sender, EventArgs e)
		{
			CriarReservaCliente criarReservaCliente = new CriarReservaCliente();
			this.Hide();
			criarReservaCliente.ShowDialog();
			this.Show();
		}

		/// <summary>
		/// Handles the Click event for the "Exit" button.
		/// This method simply closes the current form when the "Exit" button is clicked.
		/// </summary>
		/// <param name="sender">The source of the event (ExitButton).</param>
		/// <param name="e">The event data.</param>
		private void ExitButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// Handles the Click event for the "Confirmar Check-In" button.
		/// This method opens the "ConfirmarDadosCliente" form to allow the user to confirm their check-in details.
		/// It hides the current form, shows the "ConfirmarDadosCliente" form, and then shows the original form again when the user closes the "ConfirmarDadosCliente" form.
		/// </summary>
		/// <param name="sender">The source of the event (ConfirmarCheckIn).</param>
		/// <param name="e">The event data.</param>
		private void ConfirmarCheckIn_Click(object sender, EventArgs e)
		{
			ConfirmarDadosCliente confirmarDadosCliente = new ConfirmarDadosCliente();
			this.Hide();
			confirmarDadosCliente.ShowDialog();
			this.Show();
		}

		/// <summary>
		/// Handles the Click event for the "Check-Out" button.
		/// This method opens the "CheckOutCliente" form to allow the user to perform check-out.
		/// It hides the current form, shows the "CheckOutCliente" form, and then shows the original form again when the user closes the "CheckOutCliente" form.
		/// </summary>
		/// <param name="sender">The source of the event (CheckOutButton).</param>
		/// <param name="e">The event data.</param>
		private void CheckOutButton_Click(object sender, EventArgs e)
		{
			CheckOutCliente checkOutCliente = new CheckOutCliente();
			this.Hide();
			checkOutCliente.ShowDialog();
			this.Show();
		}
	}
}
