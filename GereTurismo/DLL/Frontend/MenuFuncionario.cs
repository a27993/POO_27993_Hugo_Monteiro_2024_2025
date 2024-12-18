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

		private void CriarFuncionarioButton_Click(object sender, EventArgs e)
		{
			CriarContaFuncionario criarContaFuncionario = new CriarContaFuncionario();
			this.Hide();
			criarContaFuncionario.ShowDialog();
			this.Show();
		}

		private void AdicionarAlojamentosButton_Click(object sender, EventArgs e)
		{
			CriarAlojamentoFuncionario criarAlojamentoFuncionario = new CriarAlojamentoFuncionario();
			this.Hide();
			criarAlojamentoFuncionario.ShowDialog();
			this.Show();
		}

		private void ReservasButton_Click(object sender, EventArgs e)
		{
			ReservasFuncionario reservasFuncionario = new ReservasFuncionario();
			this.Hide();
			reservasFuncionario.ShowDialog();
			this.Show();
		}

		private void ConsultasButton_Click(object sender, EventArgs e)
		{
			ConsultasFuncionarios consultasFuncionario = new ConsultasFuncionarios();
			this.Hide();
			consultasFuncionario.ShowDialog();
			this.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
