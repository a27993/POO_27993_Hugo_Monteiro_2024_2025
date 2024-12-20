/*
*	<copyright file="RegrasNegocio" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>12/9/2024 1:11:10 AM</date>
*	<description></description>
*/


using Dados;
using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;

namespace RegrasNegocio
{
	/// <summary>
	/// Purpose: Check-in rules class
	/// Created by: Hugo
	/// Created on: 12/9/2024 1:11:10 AM
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public class RegrasCheck_Ins
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
		/// Confirms the data for a specific reservation and client.
		/// </summary>
		/// <param name="idReserva">The ID of the reservation.</param>
		/// <param name="idCliente">The ID of the client.</param>
		/// <returns>
		/// Returns `-3` if either the reservation ID or client ID is invalid (less than or equal to 0). 
		/// Otherwise, it calls `Check_ins.confirmaDados` to confirm the data and returns the result.
		/// </returns>
		public static int confirmaDados(int idReserva, int idCliente)
		{
			if (idReserva <= 0 ||  idCliente <= 0)
			{
				return -3;
			}
			return Check_ins.confirmaDados(idReserva, idCliente);
		}

		/// <summary>
		/// Creates a new check-in record.
		/// </summary>
		/// <param name="data">The date of check-in.</param>
		/// <param name="idCliente">The ID of the client making the check-in.</param>
		/// <param name="idAlojamento">The ID of the accommodation being checked into.</param>
		/// <returns>
		/// Returns `-1` if any input parameters are invalid (i.e., `data` is null or `idCliente` and `idAlojamento` are less than or equal to 0).
		/// Otherwise, it calls `Check_ins.criarCheckIn` to create the check-in and returns the result.
		/// </returns>
		public static int criarCheckIn(DateTime data, int idCliente, int idAlojamento)
		{
			if (data == null || idCliente <= 0 || idAlojamento <= 0)
			{
				return -1;
			}
			return Check_ins.criarCheckIn(data, idCliente, idAlojamento);
		}

		/// <summary>
		/// Updates an existing check-in with a new date.
		/// </summary>
		/// <param name="idCheckIn">The ID of the check-in to be updated.</param>
		/// <param name="novaData">The new check-in date.</param>
		/// <returns>
		/// Returns `-1` if any input parameters are invalid (i.e., `idCheckIn` is less than or equal to 0 or `novaData` is null).
		/// Otherwise, it calls `Check_ins.alterarCheckIn` to update the check-in and returns the result.
		/// </returns>
		public static int alterarCheckIn(int idCheckIn, DateTime novaData)
		{
			if(idCheckIn <= 0 || novaData == null) 
			{ 	
				return -1; 
			}
			return Check_ins.alterarCheckIn(idCheckIn, novaData);
		}

		/// <summary>
		/// Removes a check-in record.
		/// </summary>
		/// <param name="idCheckIn">The ID of the check-in to be removed.</param>
		/// <returns>
		/// Returns `-1` if the `idCheckIn` is less than or equal to 0. Otherwise, it calls `Check_ins.removeCheckIn` to remove the check-in and returns the result.
		/// </returns>
		public static int removeCheckIn(int idCheckIn)
		{
			if(idCheckIn <= 0)
			{
				return -1;
			}
			return Check_ins.removeCheckIn(idCheckIn);
		}

		/// <summary>
		/// Removes all check-in records.
		/// </summary>
		/// <returns>
		/// Calls `Check_ins.removeTodosCheckIns` to remove all check-ins and returns the result.
		/// </returns>
		public static int removeTodosCheckIns()
		{
			return Check_ins.removeTodosCheckIns();
		}

		/// <summary>
		/// Displays all check-in records.
		/// </summary>
		/// <returns>
		/// Returns the list of all check-ins from `Check_ins.Check_Ins`.
		/// </returns>
		public static List<Check_in> mostrarTodosCheckIns()
		{
			return Check_ins.Check_Ins;
		}

		/// <summary>
		/// Loads check-in records from a file into the list.
		/// </summary>
		/// <param name="filePath">The file path to load the check-ins from.</param>
		/// <returns>
		/// Returns `false` if the file path is null or invalid. Otherwise, it calls `Check_ins.CarregaCheckInsParaLista` to load the check-ins from the file.
		/// </returns>
		public static bool CarregaCheckInsParaLista(string filePath)
		{
			if(filePath == null)
			{
				return false;
			}
			return Check_ins.CarregaCheckInsParaLista(filePath);
		}

		/// <summary>
		/// Saves the check-in records to a file.
		/// </summary>
		/// <param name="filePath">The file path to save the check-ins to.</param>
		/// <returns>
		/// Returns `false` if the file path is null or invalid. Otherwise, it calls `Check_ins.GuardaCheckInParaFicheiro` to save the check-ins to the file.
		/// </returns>
		public static bool GuardaCheckInParaFicheiro(string filePath)
		{
			if(filePath == null)
			{
				return false;
			}
			return Check_ins.GuardaCheckInParaFicheiro(filePath);
		}

		/// <summary>
		/// Finds and returns a list of Check-In entries associated with a specific client,
		/// after validating the provided client ID.
		/// </summary>
		/// <param name="idCliente">The ID of the client for whom Check-Ins are to be found.</param>
		/// <returns>
		/// A list of <see cref="Check_in"/> objects where the client's ID matches the provided `idCliente`.
		/// Returns null if the `idCliente` is invalid.
		/// </returns>
		public static List<Check_in> encontrarCheckInsUtilizador(int idCliente)
		{
			if (idCliente <= 0)
			{
				return null;
			}
			return Check_ins.encontrarCheckInsUtilizador(idCliente);
		}
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}