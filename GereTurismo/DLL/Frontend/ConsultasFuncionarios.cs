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
	public partial class ConsultasFuncionarios : Form
	{
		public ConsultasFuncionarios()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Handles the Click event for button2.
		/// This method closes the current form when button2 is clicked.
		/// </summary>
		/// <param name="sender">The source of the event (button2).</param>
		/// <param name="e">The event data.</param>
		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// Handles the SelectedIndexChanged event for comboBox1.
		/// This method is triggered when the selected item in comboBox1 changes.
		/// It retrieves the selected item, converts it to a string, and calls the AtualizarListBox method to update the list box based on the selected item.
		/// </summary>
		/// <param name="sender">The source of the event (comboBox1).</param>
		/// <param name="e">The event data.</param>
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			string listaEscolhida = comboBox1.SelectedItem.ToString();

			AtualizarListBox(listaEscolhida);
		}

		/// <summary>
		/// Handles the Load event for the ConsultasFuncionarios form.
		/// This method populates comboBox1 with three options: "Alojamentos", "Utilizadores", and "Reservas".
		/// It also sets the default selected index to 0, meaning "Alojamentos" will be selected by default.
		/// </summary>
		/// <param name="sender">The source of the event (ConsultasFuncionarios form).</param>
		/// <param name="e">The event data.</param>
		private void ConsultasFuncionarios_Load(object sender, EventArgs e)
		{
			comboBox1.Items.Add("Alojamentos");
			comboBox1.Items.Add("Utilizadores");
			comboBox1.Items.Add("Reservas");
			
			comboBox1.SelectedIndex = 0;
		}

		/// <summary>
		/// Updates the contents of the list box based on the selected item in comboBox1.
		/// It fetches the appropriate data (either "Alojamentos", "Utilizadores", or "Reservas") and binds it to the list box.
		/// The list box will display the "Display" property of the data items.
		/// </summary>
		/// <param name="listaEscolhida">The selected item from comboBox1, which determines the data to display in the list box.</param>
		private void AtualizarListBox(string listaEscolhida)
		{
			switch (listaEscolhida)
			{
				case "Alojamentos":
					listBox1.DataSource = Consultas.mostrarTodosAlojamentos();
					listBox1.DisplayMember = "Display";
					break;
				case "Utilizadores":
					listBox1.DataSource = Consultas.mostrarTodosUtilizadores();
					listBox1.DisplayMember = "Display";
					break;
				case "Reservas":
					listBox1.DataSource = Consultas.mostrarTodasReservas();
					listBox1.DisplayMember = "Display";
					break;
			}
		}
	}
}
