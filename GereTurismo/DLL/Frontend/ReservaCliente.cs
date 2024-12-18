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
	public partial class ReservaCliente : Form
	{
		public ReservaCliente()
		{
			InitializeComponent();
		}

		private void CriarReservaButton_Click(object sender, EventArgs e)
		{
			CriarReservaCliente criarReservaCliente = new CriarReservaCliente();
			this.Hide();
			criarReservaCliente.ShowDialog();
			this.Show();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ConfirmarCheckIn_Click(object sender, EventArgs e)
		{
			ConfirmarDadosCliente confirmarDadosCliente = new ConfirmarDadosCliente();
			this.Hide();
			confirmarDadosCliente.ShowDialog();
			this.Show();
		}

		private void CheckOutButton_Click(object sender, EventArgs e)
		{
			CheckOutCliente checkOutCliente = new CheckOutCliente();
			this.Hide();
			checkOutCliente.ShowDialog();
			this.Show();
		}
	}
}
