﻿using ObjetosNegocio;
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
	public partial class MenuCliente : Form
	{
		public MenuCliente()
		{
			InitializeComponent();
		}

		private void ConsultaAlojamentosButton_Click(object sender, EventArgs e)
		{
			ConsultaCliente consultaCliente = new ConsultaCliente();
			this.Hide();
			consultaCliente.ShowDialog();
			this.Show();
		}

		private void ReservaClienteButton_Click(object sender, EventArgs e)
		{
			ReservaCliente reservaCliente = new ReservaCliente();
			this.Hide();
			reservaCliente.ShowDialog();
			this.Show();
		}

		private void LogoutButton_Click(object sender, EventArgs e)
		{
			bool verificacao = RegrasUtilizadores.Logout();
			if(verificacao == true)
			{
				this.Close();
			}
		}
	}
}
