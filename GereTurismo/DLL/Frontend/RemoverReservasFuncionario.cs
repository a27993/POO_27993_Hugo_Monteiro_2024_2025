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

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void RemoverTodasReservasButton_Click(object sender, EventArgs e)
		{
			RegrasReservas.removeTodasReservas();
		}

		private void RemoverReservaButton_Click(object sender, EventArgs e)
		{

		}
	}
}
