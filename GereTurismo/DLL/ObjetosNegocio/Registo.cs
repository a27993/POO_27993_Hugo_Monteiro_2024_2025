using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNegocio
{
	public class Registo
	{
		#region Private
		private DateTime data;
		private int idAlojamento;
		private int idCliente;
		#endregion

		#region Public
		public DateTime Data
		{
			get { return this.data; }
			set { this.data = value; }
		}

		public int IdAlojamento
		{
			get { return this.idAlojamento; }
			set { this.idAlojamento = value; }
		}

		public int IdCliente
		{
			get { return this.idCliente; }
			set { this.idCliente = value; }
		}
		#endregion

		#region Constructors
		public Registo()
		{
			this.data = DateTime.Now;
			this.idAlojamento = 0;
			this.idCliente = 0;
		}
		public Registo(DateTime data, int idAlojamento,int idCliente)
		{
			this.data = data;
			this.idAlojamento = idAlojamento;
			this.idCliente = idCliente;
		}
		#endregion
	}
}
