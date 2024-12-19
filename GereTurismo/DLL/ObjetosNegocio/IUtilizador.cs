/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>12/15/2024 7:14:41 PM</date>
*	<description></description>
*/


using System;

namespace ObjetosNegocio
{
	/// <summary>
	/// Purpose: Interface user
	/// Created by: Hugo
	/// Created on: 12/15/2024 7:14:41 PM
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public interface IUtilizador
	{
		#region Methods

		#region Properties
		/// <summary>
		/// Gets or sets the full name of the user or client.
		/// </summary>
		string Nome { get; set; }

		/// <summary>
		/// Gets or sets the unique citizen card (CC) number of the user or client.
		/// </summary>
		string CC { get; set; }

		/// <summary>
		/// Gets or sets the email address of the user or client.
		/// </summary>
		string Email { get; set; }

		/// <summary>
		/// Gets or sets the mobile phone number of the user or client.
		/// </summary>
		string Telemovel { get; set; }

		/// <summary>
		/// Gets or sets the tax identification number (NIF) of the user or client.
		/// </summary>
		string Nif { get; set; }

		/// <summary>
		/// Gets or sets the password for the user or client. 
		/// Ensure this property is securely handled and stored.
		/// </summary>
		string Password { get; set; }

		/// <summary>
		/// Gets or sets the type of user or client. 
		/// This could represent roles or access levels (e.g., admin, client).
		/// </summary>
		int Tipo { get; set; }

		/// <summary>
		/// Gets or sets the unique identifier for the user or client.
		/// </summary>
		int Id { get; set; }
		#endregion

		#region Operators
		#endregion

		#region Overrides
		#endregion

		#region OtherMethods
		/// <summary>
		/// Returns a string representation of the user type based on the provided type identifier.
		/// </summary>
		/// <param name="tipo">An integer representing the type of user or client.</param>
		/// <returns>
		/// A string describing the user type. For example:
		/// - 1 might correspond to "Administrator"
		/// - 2 might correspond to "Client"
		/// </returns>
		string tipoUtilizador(int tipo);
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}