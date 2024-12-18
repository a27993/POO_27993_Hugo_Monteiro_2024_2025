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

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			string listaEscolhida = comboBox1.SelectedItem.ToString();

			AtualizarListBox(listaEscolhida);
		}

		private void ConsultasFuncionarios_Load(object sender, EventArgs e)
		{
			comboBox1.Items.Add("Alojamentos");
			comboBox1.Items.Add("Utilizadores");
			comboBox1.Items.Add("Reservas");
			
			comboBox1.SelectedIndex = 0;
		}

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
