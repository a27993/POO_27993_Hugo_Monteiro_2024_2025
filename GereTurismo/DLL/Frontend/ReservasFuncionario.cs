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

		private void Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CriarReservaButton_Click(object sender, EventArgs e)
		{
			CriarReservaCliente criarReservaCliente = new CriarReservaCliente();
			this.Hide();
			criarReservaCliente.ShowDialog();
			this.Close();
		}

		private void RemoverReservaButton_Click(object sender, EventArgs e)
		{
			RemoverReservasFuncionario removerReservasFuncionario = new RemoverReservasFuncionario();
			this.Hide();
			removerReservasFuncionario.ShowDialog();
			this.Show();
		}
	}
}
