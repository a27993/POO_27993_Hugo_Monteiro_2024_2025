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
	public partial class ReservasFuncionario : Form
	{
		public ReservasFuncionario()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Handles the Click event for the "Exit" button.
		/// This method closes the current form when the "Exit" button is clicked.
		/// </summary>
		/// <param name="sender">The source of the event (Exit button).</param>
		/// <param name="e">The event data.</param>
		private void Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// Handles the Click event for the "Create Reservation" button.
		/// This method opens the "CriarReservaCliente" form to allow the user to create a reservation.
		/// It hides the current form, shows the "CriarReservaCliente" form, and closes the current form once the modal form is closed.
		/// </summary>
		/// <param name="sender">The source of the event (CriarReservaButton).</param>
		/// <param name="e">The event data.</param>
		private void CriarReservaButton_Click(object sender, EventArgs e)
		{
			CriarReservaCliente criarReservaCliente = new CriarReservaCliente();
			this.Hide();
			criarReservaCliente.ShowDialog();
			this.Close();
		}

		/// <summary>
		/// Handles the Click event for the "Remove Reservation" button.
		/// This method opens the "RemoverReservasFuncionario" form to allow the user to remove reservations.
		/// It hides the current form, shows the "RemoverReservasFuncionario" form, and shows the original form again when the modal form is closed.
		/// </summary>
		/// <param name="sender">The source of the event (RemoverReservaButton).</param>
		/// <param name="e">The event data.</param>
		private void RemoverReservaButton_Click(object sender, EventArgs e)
		{
			RemoverReservasFuncionario removerReservasFuncionario = new RemoverReservasFuncionario();
			this.Hide();
			removerReservasFuncionario.ShowDialog();
			this.Show();
		}
	}
}
