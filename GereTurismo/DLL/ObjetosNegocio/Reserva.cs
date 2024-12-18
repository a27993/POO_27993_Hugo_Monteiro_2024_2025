/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>10/26/2024 9:06:56 PM</date>
*	<description></description>
*/


using System;
using System.Collections.Generic;
using System.Data;

namespace ObjetosNegocio
{
	/// <summary>
	/// Purpose: Reserve class
	/// Created by: Hugo
	/// Created on: 10/26/2024 9:06:56 PM
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public class Reserva : IReserva
	{
		#region Attributes
		private int idCliente;
		private int idAlojamento;
		private DateTime dataInicio;
		private DateTime dataFim;
		private int idReserva;
		private static int totalId = 1;


		public string Display => $"ID:{IdReserva} - Utilizador:{IdCliente} - Alojamento:{IdAlojamento} - Data inicio:{DataInicio} - Data fim:{DataFim}";
		#endregion

		#region Methods

		#region Constructors
		/// <summary>
		/// Default constructor for the Reserva class.
		/// Initializes a reservation with default values of zero for client and accommodation IDs, 
		/// and sets the start and end dates to the default DateTime value. 
		/// The reservation ID is automatically assigned and then increments the total ID count.
		/// </summary>
		public Reserva()
		{
			this.idCliente = 0;
			this.idAlojamento = 0;
			this.dataInicio = new DateTime(1970,01,01);
			this.dataFim = new DateTime(1970,01,01);
			this.idReserva = totalId;
			totalId++;
		}

		/// <summary>
		/// Parameterized constructor for the Reserva class.
		/// Allows initializing a reservation with specific values for client ID, accommodation ID, start date, and end date.
		/// The reservation ID is automatically assigned based on the current total ID count, which then increments.
		/// </summary>
		/// <param name="idCliente">The ID of the client making the reservation.</param>
		/// <param name="idAlojamento">The ID of the accommodation being reserved.</param>
		/// <param name="dataInicio">The start date of the reservation.</param>
		/// <param name="dataFim">The end date of the reservation.</param>
		public Reserva(int idCliente, int idAlojamento, DateTime dataInicio, DateTime dataFim)
		{
			this.idCliente = idCliente;
			this.idAlojamento = idAlojamento;
			this.dataInicio = dataInicio;
			this.dataFim = dataFim;
			this.idReserva = totalId;
			totalId++;
		}
		#endregion

		#region Properties
		/// <summary>
		/// Property for accessing and setting the ID of the client associated with the reservation.
		/// </summary>
		public int IdCliente
		{
			get { return this.idCliente; }
			set { this.idCliente = value; }
		}

		/// <summary>
		/// Property for accessing and setting the ID of the accommodation associated with the reservation.
		/// </summary>
		public int IdAlojamento
		{
			get { return this.idAlojamento; }
			set { this.idAlojamento = value; }
		}

		/// <summary>
		/// Property for accessing and setting the start date of the reservation.
		/// </summary>
		public DateTime DataInicio
		{
			get { return this.dataInicio; }
			set { this.dataInicio = value; }
		}

		/// <summary>
		/// Property for accessing and setting the end date of the reservation.
		/// </summary>
		public DateTime DataFim
		{
			get { return this.dataFim; }
			set { this.dataFim = value; }
		}

		/// <summary>
		/// Property for accessing and setting the unique identifier (ID) of the reservation.
		/// </summary>
		public int IdReserva
		{
			get { return this.idReserva; }
			set { this.idReserva = value; }
		}

		/// <summary>
		/// Static property for accessing the total count of reservation IDs assigned.
		/// </summary>
		public static int TotalId
		{ 
			get { return totalId; }
		}

		#endregion

		#region Operators
		#endregion

		#region Overrides
		#endregion

		#region OtherMethods
		public void mostrarReserva()
		{
			Console.WriteLine($"{idCliente},{idAlojamento},{dataInicio},{dataFim},{idReserva}");
		}

		/// <summary>
		/// Calculates the total price of a stay based on the price per night and the number of days between the start and end dates.
		/// </summary>
		/// <param name="precoPorNoite">The price per night for the accommodation.</param>
		/// <returns>Returns the total price of the stay.</returns>
		public double calcularPrecoTotal(double precoPorNoite)
		{
			TimeSpan diferencaDias = dataFim - dataInicio;

			double precoTotal = diferencaDias.TotalDays * precoPorNoite;

			return precoTotal;
		}
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}