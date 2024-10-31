/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>10/26/2024 9:06:56 PM</date>
*	<description></description>
*/


using System;

namespace ObjetosNegocio
{
	/// <summary>
	/// Purpose: 
	/// Created by: Hugo
	/// Created on: 10/26/2024 9:06:56 PM
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public class Reserva
	{
		#region Attributes
		private int idCliente;
		private int idAlojamento;
		private DateTime dataInicio;
		private DateTime dataFim;
		private int idReserva;
		#endregion

		#region Methods

		#region Constructors
		public Reserva()
		{
			this.idCliente = 0;
			this.idAlojamento = 0;
			this.dataInicio = new DateTime();
			this.dataFim = new DateTime();
			this.idReserva = 0;
		}
		public Reserva(int idCliente, int idAlojamento, DateTime dataInicio, DateTime dataFim, int idReserva)
		{
			this.idCliente = idCliente;
			this.idAlojamento = idAlojamento;
			this.dataInicio = dataInicio;
			this.dataFim = dataFim;
			this.idReserva = idReserva;
		}
		#endregion

		#region Properties
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
			set { this.dataFim = value; }
		}

		public int IdReserva
		{
			get { return this.idReserva; }
			set { this.idReserva = value; }
		}
		#endregion

		#region Operators
		#endregion

		#region Overrides
		#endregion

		#region OtherMethods
		/**
		 * datafim - datainicio (em dias) = convert.toint * precoPorNoite
		 */
		public double calcularPrecoTotal(double precoPorNoite)
		{
			TimeSpan diferencaDias = this.dataFim - this.dataInicio;

			double precoTotal = diferencaDias.TotalDays * precoPorNoite;

			return precoTotal;
		}
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}