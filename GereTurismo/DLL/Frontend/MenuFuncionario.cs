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
	public partial class MenuFuncionario : Form
	{
		public MenuFuncionario()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Handles the Click event for the "Criar Funcionario" button.
		/// This method opens the "CriarContaFuncionario" form, allowing the user to create a new employee account.
		/// It hides the current form, shows the "CriarContaFuncionario" form, and then shows the original form again when the user closes the "CriarContaFuncionario" form.
		/// </summary>
		/// <param name="sender">The source of the event (CriarFuncionarioButton).</param>
		/// <param name="e">The event data.</param>
		private void CriarFuncionarioButton_Click(object sender, EventArgs e)
		{
			CriarContaFuncionario criarContaFuncionario = new CriarContaFuncionario();
			this.Hide();
			criarContaFuncionario.ShowDialog();
			this.Show();
		}

		/// <summary>
		/// Handles the Click event for the "Adicionar Alojamentos" button.
		/// This method opens the "CriarAlojamentoFuncionario" form to allow the user to add a new accommodation.
		/// It hides the current form, shows the "CriarAlojamentoFuncionario" form, and then shows the original form again when the user closes the "CriarAlojamentoFuncionario" form.
		/// </summary>
		/// <param name="sender">The source of the event (AdicionarAlojamentosButton).</param>
		/// <param name="e">The event data.</param>
		private void AdicionarAlojamentosButton_Click(object sender, EventArgs e)
		{
			CriarAlojamentoFuncionario criarAlojamentoFuncionario = new CriarAlojamentoFuncionario();
			this.Hide();
			criarAlojamentoFuncionario.ShowDialog();
			this.Show();
		}

		/// <summary>
		/// Handles the Click event for the "Reservas" button.
		/// This method opens the "ReservasFuncionario" form to allow the user to manage reservations.
		/// It hides the current form, shows the "ReservasFuncionario" form, and then shows the original form again when the user closes the "ReservasFuncionario" form.
		/// </summary>
		/// <param name="sender">The source of the event (ReservasButton).</param>
		/// <param name="e">The event data.</param>
		private void ReservasButton_Click(object sender, EventArgs e)
		{
			ReservasFuncionario reservasFuncionario = new ReservasFuncionario();
			this.Hide();
			reservasFuncionario.ShowDialog();
			this.Show();
		}

		/// <summary>
		/// Handles the Click event for the "Consultas" button.
		/// This method opens the "ConsultasFuncionarios" form to allow the user to perform various queries and view data.
		/// It hides the current form, shows the "ConsultasFuncionarios" form, and then shows the original form again when the user closes the "ConsultasFuncionarios" form.
		/// </summary>
		/// <param name="sender">The source of the event (ConsultasButton).</param>
		/// <param name="e">The event data.</param>
		private void ConsultasButton_Click(object sender, EventArgs e)
		{
			ConsultasFuncionarios consultasFuncionario = new ConsultasFuncionarios();
			this.Hide();
			consultasFuncionario.ShowDialog();
			this.Show();
		}

		/// <summary>
		/// Handles the Click event for the "Exit" button (button1).
		/// This method simply closes the current form when the "Exit" button is clicked.
		/// </summary>
		/// <param name="sender">The source of the event (button1).</param>
		/// <param name="e">The event data.</param>
		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
