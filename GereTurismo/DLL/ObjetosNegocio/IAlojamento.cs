/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>12/15/2024 7:18:59 PM</date>
*	<description></description>
*/


using System;

namespace ObjetosNegocio
{
	/// <summary>
	/// Purpose: Interface accomodation
	/// Created by: Hugo
	/// Created on: 12/15/2024 7:18:59 PM
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public interface IAlojamento
	{
		#region Methods

		#region Properties
		/// <summary>
		/// Gets or sets the unique identifier of the accommodation.
		/// </summary>
		int Id { get; set; }

		/// <summary>
		/// Gets or sets the location of the accommodation.
		/// </summary>
		string Localizacao {  get; set; }

		/// <summary>
		/// Gets or sets the price per night for the accommodation.
		/// </summary>
		double PrecoPorNoite { get; set; }

		/// <summary>
		/// Gets or sets the capacity of the accommodation, representing the maximum number of people it can host.
		/// </summary>
		int Capacidade { get; set; }
		#endregion

		#region Operators
		#endregion

		#region Overrides
		#endregion

		#region OtherMethods
		/// <summary>
		/// Displays information about the accommodation. 
		/// This method is expected to output or handle the details of the accommodation
		/// in a user-friendly format.
		/// </summary>
		void mostraAlojamento();
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}