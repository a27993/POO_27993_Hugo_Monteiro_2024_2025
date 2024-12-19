using ObjetosNegocio;
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
	public partial class MenuCliente : Form
	{
		public MenuCliente()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Handles the Click event for the "Consult Alojamentos" button.
		/// This method opens the "ConsultaCliente" form for the user to consult accommodations (Alojamentos).
		/// It hides the current form, shows the "ConsultaCliente" form, and then shows the original form again when the user closes the "ConsultaCliente" form.
		/// </summary>
		/// <param name="sender">The source of the event (ConsultaAlojamentos button).</param>
		/// <param name="e">The event data.</param>
		private void ConsultaAlojamentosButton_Click(object sender, EventArgs e)
		{
			ConsultaCliente consultaCliente = new ConsultaCliente();
			this.Hide();
			consultaCliente.ShowDialog();
			this.Show();
		}

		/// <summary>
		/// Handles the Click event for the "Reserva Cliente" button.
		/// This method opens the "ReservaCliente" form, allowing the user to make a reservation.
		/// It hides the current form, shows the "ReservaCliente" form, and then shows the original form again when the user closes the "ReservaCliente" form.
		/// </summary>
		/// <param name="sender">The source of the event (ReservaCliente button).</param>
		/// <param name="e">The event data.</param>
		private void ReservaClienteButton_Click(object sender, EventArgs e)
		{
			ReservaCliente reservaCliente = new ReservaCliente();
			this.Hide();
			reservaCliente.ShowDialog();
			this.Show();
		}

		/// <summary>
		/// Handles the Click event for the "Logout" button.
		/// This method attempts to log out the currently logged-in user by calling the `Logout()` method from the business logic layer.
		/// If the logout is successful, it closes the current form, effectively logging the user out of the application.
		/// </summary>
		/// <param name="sender">The source of the event (Logout button).</param>
		/// <param name="e">The event data.</param>
		private void LogoutButton_Click(object sender, EventArgs e)
		{
			bool verificacao = RegrasUtilizadores.Logout();
			if(verificacao == true)
			{
				this.Close();
			}
		}
	}
}
