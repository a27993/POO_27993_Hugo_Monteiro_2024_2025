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
	public partial class ConsultaCliente : Form
	{
		public ConsultaCliente()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Handles the Click event for the button1.
		/// This method closes the current form when the button is clicked.
		/// </summary>
		/// <param name="sender">The source of the event (button1).</param>
		/// <param name="e">The event data.</param>
		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// Handles the SelectedIndexChanged event for the ClienteComboBox (Client ComboBox).
		/// This method is triggered when the selected item in the combo box changes.
		/// It retrieves the selected item, converts it to a string, and calls the AtualizarListBox method to update the list box with the chosen data.
		/// </summary>
		/// <param name="sender">The source of the event (ClienteComboBox).</param>
		/// <param name="e">The event data.</param>
		private void ClienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string listaEscolhida = ClienteComboBox.SelectedItem.ToString();

			AtualizarListBox(listaEscolhida);
		}

		/// <summary>
		/// Handles the Load event for the ConsultaCliente form.
		/// This method populates the ClienteComboBox with two options: "Alojamentos" and "Reservas".
		/// It also sets the default selected index to 0, meaning "Alojamentos" will be selected by default.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The event data.</param>
		private void ConsultaCliente_Load(object sender, EventArgs e)
		{
			ClienteComboBox.Items.Add("Alojamentos");
			ClienteComboBox.Items.Add("Reservas");

			ClienteComboBox.SelectedIndex = 0;
		}

		/// <summary>
		/// Updates the contents of the list box based on the selected item in the ClienteComboBox.
		/// It fetches the appropriate data (either "Alojamentos" or "Reservas") and binds it to the list box.
		/// The list box will display the "Display" property of the data items.
		/// </summary>
		/// <param name="listaEscolhida">The selected item from the ClienteComboBox, which determines the data to display in the list box.</param>
		private void AtualizarListBox(string listaEscolhida)
		{
			int idCliente = RegrasUtilizadores.ObterIdLogado();
			switch (listaEscolhida)
			{
				case "Alojamentos":
					listBox1.DataSource = Consultas.mostrarTodosAlojamentos();
					listBox1.DisplayMember = "Display";
					break;
				case "Reservas":
					listBox1.DataSource = RegrasReservas.encontrarReservasUtilizador(idCliente);
					listBox1.DisplayMember = "Display";
					break;
			}
		}
	}
}
