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
			criarContaFuncionario.Show();
		}

		private void AdicionarAlojamentosButton_Click(object sender, EventArgs e)
		{
			CriarAlojamentoFuncionario criarAlojamentoFuncionario = new CriarAlojamentoFuncionario();
			criarAlojamentoFuncionario.Show();
		}

		private void ReservasButton_Click(object sender, EventArgs e)
		{
			ReservasFuncionario reservasFuncionario = new ReservasFuncionario();
			reservasFuncionario.Show();
		}

		private void ConsultasButton_Click(object sender, EventArgs e)
		{

		}
	}
}
