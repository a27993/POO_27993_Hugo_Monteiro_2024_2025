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
using System.Xml.Schema;

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
		public string Display => $"IdRegisto:{IdRegisto} - IdCliente:{IdCliente} - IdAlojamento:{IdAlojamento} - Data:{Data}";
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
		public Check_in(DateTime data, int idAlojamento, int idCliente) : base(data, idAlojamento, idCliente) { }
		#endregion

		#region Properties
		#endregion

		#region Operators
		#endregion

		#region Overrides
		/// <summary>
		/// Overrides the default method to display the record information.
		/// This method outputs a formatted string with the details of the record, 
		/// including the record ID, check-in date, accommodation ID, and client ID.
		/// </summary>
		public override void exibirRegisto()
		{
			Console.WriteLine($"{IdRegisto},Data Check-in: {Data},{IdAlojamento},{IdCliente}");
		}
		#endregion

		#region OtherMethods
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}