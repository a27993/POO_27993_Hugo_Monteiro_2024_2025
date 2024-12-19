/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>12/15/2024 7:20:32 PM</date>
*	<description></description>
*/


using System;

namespace ObjetosNegocio
{
	/// <summary>
	/// Purpose: Interface reserve
	/// Created by: Hugo
	/// Created on: 12/15/2024 7:20:32 PM
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public interface IReserva
	{
		#region Methods

		#region Properties
		/// <summary>
		/// Gets or sets the unique identifier for the client associated with the reservation.
		/// </summary>
		int IdCliente { get; set; }

		/// <summary>
		/// Gets or sets the unique identifier for the accommodation associated with the reservation.
		/// </summary>
		int IdAlojamento { get; set; }

		/// <summary>
		/// Gets or sets the start date of the reservation.
		/// </summary>
		DateTime DataInicio { get; set; }

		/// <summary>
		/// Gets or sets the end date of the reservation.
		/// </summary>
		DateTime DataFim { get; set; }

		/// <summary>
		/// Gets or sets the unique identifier for the reservation.
		/// </summary>
		int IdReserva { get; set; }
		#endregion

		#region Operators
		#endregion

		#region Overrides
		#endregion

		#region OtherMethods
		/// <summary>
		/// Displays the details of a reservation. 
		/// This method should output or present information such as the client, accommodation, 
		/// reservation dates, and other relevant details.
		/// </summary>
		void mostrarReserva();

		/// <summary>
		/// Calculates the total price of the reservation based on the nightly price.
		/// </summary>
		/// <param name="precoPorNoite">The price per night for the accommodation.</param>
		/// <returns>The total price for the entire reservation period, based on the start and end dates.</returns>
		double calcularPrecoTotal(double precoPorNoite);
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}