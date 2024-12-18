using ObjetosNegocio;
using RegrasNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
	public partial class CriarReservaCliente : Form
	{
		public CriarReservaCliente()
		{
			InitializeComponent();
		}

		private void CriarReservaButton_Click(object sender, EventArgs e)
		{
			int verificarIdLogado = RegrasUtilizadores.ObterIdLogado();
			if(verificarIdLogado == -1)
			{
				MessageBox.Show("Invalido");
			}
			else
			{
				int verificacao = RegrasReservas.criaReserva(verificarIdLogado, int.Parse(AlojamentoTextBox.Text), DateTime.ParseExact(DataInicioTextBox.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture), DateTime.ParseExact(DataFimTextBox.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture));
				if (verificacao == -1)
				{
					MessageBox.Show("Dados invalidos");
				}
				else MessageBox.Show("Sucesso");
				this.Close();
			}
		}
	}
}
