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

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ClienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string listaEscolhida = ClienteComboBox.SelectedItem.ToString();

			AtualizarListBox(listaEscolhida);
		}

		private void ConsultaCliente_Load(object sender, EventArgs e)
		{
			ClienteComboBox.Items.Add("Alojamentos");
			ClienteComboBox.Items.Add("Reservas");

			ClienteComboBox.SelectedIndex = 0;
		}

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
