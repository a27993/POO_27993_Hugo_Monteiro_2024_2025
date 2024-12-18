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
