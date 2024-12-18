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
	/// Purpose: 
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
		public static List<Alojamento> mostrarTodosAlojamentos()
		{
			return RegrasAlojamentos.mostraTodosAlojamento();
		}

		public static List<Utilizador> mostrarTodosUtilizadores()
		{
			return RegrasUtilizadores.mostrarTodosUtilizadores();
		}

		public static List<Check_in> mostrarTodosCheck_ins()
		{
			return RegrasCheck_Ins.mostrarTodosCheckIns();
		}

		public static List<Check_out> mostrarTodosCheck_outs()
		{
			return RegrasCheck_outs.mostrarTodosCheckOuts();
		}

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