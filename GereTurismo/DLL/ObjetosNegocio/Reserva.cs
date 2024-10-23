using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNegocio
{
    public class Reserva
    {
		#region Private
		private int idCliente;
        private int idAlojamento;
        private DateTime dataInicio;
        private DateTime dataFim;
		private int idReserva;
		#endregion

		#region Public
		public int IdCliente
		{
			get { return this.idCliente; }
			set { this.idCliente = value; }
		}

		public int IdAlojamento
		{
			get { return this.idAlojamento; }
			set { this.idAlojamento = value; }
		}

		public DateTime DataInicio
		{
			get { return this.dataInicio; }
			set { this.dataInicio = value; }
		}

		public DateTime DataFim
		{
			get { return this.dataFim; }
			set {  this.dataFim = value; }
		}

		public int IdReserva
		{
			get { return this.idReserva; }
			set { this.idReserva = value; }
		}
		#endregion

		#region Constructors
		public Reserva()
		{
			this.idCliente = 0;
			this.idAlojamento = 0;
			this.dataInicio = new DateTime();
			this.dataFim = new DateTime();
			this.idReserva = 0;
		}
		public Reserva(int idCliente,int idAlojamento,DateTime dataInicio,DateTime dataFim,int idReserva)
		{
			this.idCliente = idCliente;
			this.idAlojamento = idAlojamento;
			this.dataInicio = dataInicio;
			this.dataFim = dataFim;
			this.idReserva = idReserva;
		}
		#endregion

		#region Methods
		/**
		 * datafim - datainicio (em dias) = convert.toint * precoPorNoite
		 */
		public double calcularPrecoTotal(double precoPorNoite)
		{
			//	double diaInicial = Convert.ToInt32(this.dataInicio);
			//	double diaFinal = Convert.ToInt32(this.dataFim);

			//	double diferencaDias = diaFinal - diaInicial;
			//	double precoTotal = (double)(precoPorNoite - diferencaDias);

			TimeSpan diferencaDias = this.dataFim - this.dataInicio;

			double precoTotal = diferencaDias.TotalDays * precoPorNoite;

			return precoTotal;
		}
		#endregion
	}
}
