/*
*	<copyright file="Frontend" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>12/8/2024 11:23:56 PM</date>
*	<description></description>
*/


using System;
using System.Collections.Generic;
using ObjetosNegocio;
using RegrasNegocio;

namespace Frontend
{
	/// <summary>
	/// Purpose: queries class
	/// Created by: Hugo
	/// Created on: 12/8/2024 11:23:56 PM
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public class Consultas
	{
		#region Attributes
		#endregion

		#region Methods

		#region Constructors
		#endregion

		#region Properties
		#endregion

		#region Operators
		#endregion

		#region Overrides
		#endregion

		#region OtherMethods
		/// <summary>
		/// Retrieves and returns a list of all accommodations.
		/// This method calls the relevant method from the business logic layer to fetch the data.
		/// </summary>
		/// <returns>A list of Alojamento objects representing all accommodations.</returns>
		public static List<Alojamento> mostrarTodosAlojamentos()
		{
			return RegrasAlojamentos.mostraTodosAlojamento();
		}

		/// <summary>
		/// Retrieves and returns a list of all users.
		/// This method calls the relevant method from the business logic layer to fetch the data.
		/// </summary>
		/// <returns>A list of Utilizador objects representing all users.</returns>
		public static List<Utilizador> mostrarTodosUtilizadores()
		{
			return RegrasUtilizadores.mostrarTodosUtilizadores();
		}

		/// <summary>
		/// Retrieves and returns a list of all check-ins.
		/// This method calls the relevant method from the business logic layer to fetch the data.
		/// </summary>
		/// <returns>A list of Check_in objects representing all check-ins.</returns>
		public static List<Check_in> mostrarTodosCheck_ins()
		{
			return RegrasCheck_Ins.mostrarTodosCheckIns();
		}

		/// <summary>
		/// Retrieves and returns a list of all check-outs.
		/// This method calls the relevant method from the business logic layer to fetch the data.
		/// </summary>
		/// <returns>A list of Check_out objects representing all check-outs.</returns>
		public static List<Check_out> mostrarTodosCheck_outs()
		{
			return RegrasCheck_outs.mostrarTodosCheckOuts();
		}

		/// <summary>
		/// Retrieves and returns a list of all reservations.
		/// This method calls the relevant method from the business logic layer to fetch the data.
		/// </summary>
		/// <returns>A list of Reserva objects representing all reservations.</returns>
		public static List<Reserva> mostrarTodasReservas()
		{
			return RegrasReservas.mostrarTodasReserva();
		}
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}