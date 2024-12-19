/*
*	<copyright file="RegrasNegocio" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>12/9/2024 1:03:24 AM</date>
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
	/// Purpose: Check-out rules class
	/// Created by: Hugo
	/// Created on: 12/9/2024 1:03:24 AM
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public class RegrasCheck_outs
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
		/// Creates a new check-out record.
		/// </summary>
		/// <param name="data">The date of check-out.</param>
		/// <param name="idCliente">The ID of the client checking out.</param>
		/// <param name="idAlojamento">The ID of the accommodation being checked out from.</param>
		/// <param name="pagamento">The payment amount for the check-out.</param>
		/// <returns>
		/// Returns `-1` if any input parameters are invalid (i.e., `data` is null, `idCliente` or `idAlojamento` is less than or equal to 0, or `pagamento` is less than or equal to 0.00).
		/// Otherwise, it calls `Check_outs.criarCheckOut` to create the check-out and returns the result.
		/// </returns>
		public static int criarCheckOut(DateTime data, int idCliente, int idAlojamento,double pagamento)
		{
			if(data == null || idCliente <= 0 || idAlojamento <= 0 || pagamento <= 0.00)
			{
				return -1;
			}
			return Check_outs.criarCheckOut(data,idCliente,idAlojamento,pagamento);
		}

		/// <summary>
		/// Updates the check-out date of an existing check-out record.
		/// </summary>
		/// <param name="idCheckOut">The ID of the check-out to be updated.</param>
		/// <param name="novaData">The new check-out date.</param>
		/// <returns>
		/// Returns `-2` if the `idCheckOut` is less than or equal to 0 or `novaData` is null. 
		/// Otherwise, it calls `Check_outs.alterarCheckOut` to update the check-out record and returns the result.
		/// </returns>
		public static int alterarCheckOut(int idCheckOut, DateTime novaData)
		{
			if(idCheckOut <= 0 || novaData == null)
			{
				return -2;
			}
			return Check_outs.alterarCheckOut(idCheckOut, novaData);
		}

		/// <summary>
		/// Removes a check-out record.
		/// </summary>
		/// <param name="idCheckOut">The ID of the check-out to be removed.</param>
		/// <returns>
		/// Returns `-1` if the `idCheckOut` is less than or equal to 0. 
		/// Otherwise, it calls `Check_outs.removeCheckOut` to remove the check-out and returns the result.
		/// </returns>
		public static int removeCheckOut(int idCheckOut)
		{
			if(idCheckOut <= 0)
			{
				return -1;
			}
			return Check_outs.removeCheckOut(idCheckOut);
		}

		/// <summary>
		/// Removes all check-out records.
		/// </summary>
		/// <returns>
		/// Calls `Check_outs.removeTodosCheckOuts` to remove all check-out records and returns the result.
		/// </returns>
		public static int removeTodosCheckOuts()
		{
			return Check_outs.removeTodosCheckOuts();
		}

		/// <summary>
		/// Displays all check-out records.
		/// </summary>
		/// <returns>
		/// Returns the list of all check-out records from `Check_outs.Check_Outs`.
		/// </returns>
		public static List<Check_out> mostrarTodosCheckOuts()
		{
			return Check_outs.Check_Outs;
		}

		/// <summary>
		/// Loads check-out records from a file into the list.
		/// </summary>
		/// <param name="filePath">The file path to load the check-out records from.</param>
		/// <returns>
		/// Returns `false` if the file path is null or invalid. Otherwise, it calls `Check_outs.CarregaCheckOutsParaLista` to load the check-out records from the file.
		/// </returns>
		public static bool CarregaCheckOutsParaLista(string filePath)
		{
			if(filePath == null)
			{
				return false;
			}
			return Check_outs.CarregaCheckOutsParaLista(filePath);
		}

		/// <summary>
		/// Saves the check-out records to a file.
		/// </summary>
		/// <param name="filePath">The file path to save the check-out records to.</param>
		/// <returns>
		/// Returns `false` if the file path is null or invalid. Otherwise, it calls `Check_outs.GuardaCheckOutParaFicheiro` to save the check-out records to the file.
		/// </returns>
		public static bool GuardaCheckOutParaFicheiro(string filePath)
		{
			if(filePath == null)
			{
				return false;
			}
			return Check_outs.GuardaCheckOutParaFicheiro(filePath);
		}
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}