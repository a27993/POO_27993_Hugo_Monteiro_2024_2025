/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>10/26/2024 9:17:10 PM</date>
*	<description></description>
*/


using System;
using System.Data;

namespace ObjetosNegocio
{
	/// <summary>
	/// Purpose: Check-in class
	/// Created by: Hugo
	/// Created on: 10/26/2024 9:17:10 PM
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public class Check_in : Registo
	{
		#region Attributes
		#endregion

		#region Methods

		#region Constructors
		/// <summary>
		/// Default constructor for the Check_in class.
		/// Calls the base class constructor with no parameters.
		/// </summary>
		public Check_in() : base() { }

		/// <summary>
		/// Parameterized constructor for the Check_in class.
		/// Initializes a check-in instance with the specified date, accommodation ID, and client ID.
		/// Calls the base class constructor with the provided parameters.
		/// </summary>
		/// <param name="data">The date of the check-in.</param>
		/// <param name="idAlojamento">The ID of the accommodation associated with the check-in.</param>
		/// <param name="Cliente">The ID of the client associated with the check-in.</param>
		public Check_in(DateTime data, int idAlojamento, int Cliente) : base(data, idAlojamento, Cliente) { }
		#endregion

		#region Properties
		#endregion

		#region Operators
		#endregion

		#region Overrides
		#endregion

		#region OtherMethods
		/// <summary>
		/// Confirms reservation details based on the reservation ID.
		/// Searches for a reservation with the specified ID and checks if it exists.
		/// If the reservation exists, it verifies if the client ID matches the reservation's client ID.
		/// </summary>
		/// <param name="idReserva">The ID of the reservation to be confirmed.</param>
		/// <returns>Returns 1 if the reservation exists and the client ID matches; returns 0 otherwise.</returns>
		public int confirmaDados(int idReserva)
		{
			Reserva reserva = Reserva.Reservas.Find(x => x.IdReserva == idReserva);

			if (reserva != null) //if exists
			{
				if(this.IdCliente == reserva.IdCliente) return 1;
				else return 0;
			}
			else return 0;
		}
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}