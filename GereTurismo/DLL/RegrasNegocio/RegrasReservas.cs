/*
*	<copyright file="RegrasNegocio" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>12/8/2024 11:39:23 PM</date>
*	<description></description>
*/


using System;
using System.Collections.Generic;
using System.IO;
using Dados;
using ObjetosNegocio;

namespace RegrasNegocio
{
	/// <summary>
	/// Purpose: Reservations rules class
	/// Created by: Hugo
	/// Created on: 12/8/2024 11:39:23 PM
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public class RegrasReservas
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
		/// Creates a new reservation.
		/// </summary>
		/// <param name="idCliente">The ID of the client making the reservation.</param>
		/// <param name="idAlojamento">The ID of the accommodation being reserved.</param>
		/// <param name="dataInicio">The start date of the reservation.</param>
		/// <param name="dataFim">The end date of the reservation.</param>
		/// <returns>
		/// Returns `-1` if either `idCliente` or `idAlojamento` is less than or equal to 0.
		/// Otherwise, it calls `Reservas.criaReserva` to create the reservation and returns the result.
		/// </returns>
		public static int criaReserva(int idCliente, int idAlojamento, DateTime dataInicio, DateTime dataFim)
		{
			if (idCliente <= 0 || idAlojamento <= 0)
			{
				return -1;
			}
			return Reservas.criaReserva(idCliente, idAlojamento, dataInicio, dataFim);
		}

		/// <summary>
		/// Removes a reservation by its ID.
		/// </summary>
		/// <param name="idReserva">The ID of the reservation to be removed.</param>
		/// <returns>
		/// Returns `-2` if `idReserva` is less than or equal to 0. Otherwise, it calls `Reservas.removeReserva` to remove the reservation and returns the result.
		/// </returns>
		public static int removeReserva(int idReserva)
		{
			if (idReserva <= 0)
			{
				return -2;
			}
			return Reservas.removeReserva(idReserva);
		}

		/// <summary>
		/// Removes all reservations.
		/// </summary>
		/// <returns>
		/// Returns the result of calling `Reservas.removeTodasReservas` to remove all reservations.
		/// </returns>
		public static bool removeTodasReservas()
		{
			return Reservas.removeTodasReservas();
		}

		/// <summary>
		/// Updates the start and end dates of an existing reservation.
		/// </summary>
		/// <param name="idReserva">The ID of the reservation to be updated.</param>
		/// <param name="novaDataInicio">The new start date of the reservation.</param>
		/// <param name="novaDataFim">The new end date of the reservation.</param>
		/// <returns>
		/// Returns `-1` if `idReserva` is less than or equal to 0. Otherwise, it calls `Reservas.alterarReserva` to update the reservation and returns the result.
		/// </returns>
		public static int alterarReserva(int idReserva, DateTime novaDataInicio, DateTime novaDataFim)
		{
			if (idReserva <= 0)
			{
				return -1;
			}
			return Reservas.alterarReserva(idReserva, novaDataInicio, novaDataFim);
		}

		/// <summary>
		/// Finds a reservation by its ID.
		/// </summary>
		/// <param name="idReserva">The ID of the reservation to be found.</param>
		/// <returns>
		/// Returns `-2` if `idReserva` is less than or equal to 0. Otherwise, it calls `Reservas.encontrarReserva` to find the reservation and returns the result.
		/// </returns>
		public static int encontrarReserva(int idReserva)
		{
			if (idReserva <= 0)
			{
				return -2;
			}
			return Reservas.encontrarReserva(idReserva);
		}

		/// <summary>
		/// Finds all reservations made by a specific client.
		/// </summary>
		/// <param name="idCliente">The ID of the client whose reservations are to be found.</param>
		/// <returns>
		/// Returns a list of reservations for the specified client. Returns `null` if `idCliente` is invalid (less than or equal to 0).
		/// </returns>
		public static List<Reserva> encontrarReservasUtilizador(int idCliente)
		{
			if(idCliente <= 0)
			{
				return null;
			}
			return Reservas.encontrarReservasUtilizador(idCliente);
		}

		/// <summary>
		/// Displays all reservations.
		/// </summary>
		/// <returns>
		/// Returns a list of all reservations from `Reservas.R`.
		/// </returns>
		public static List<Reserva> mostrarTodasReserva()
		{
			return Reservas.R;
		}

		/// <summary>
		/// Loads reservations from a file into the reservation list.
		/// </summary>
		/// <param name="filePath">The file path from which to load reservations.</param>
		/// <returns>
		/// Returns `false` if the file does not exist. Otherwise, it calls `Reservas.CarregaReservasParaLista` to load the reservations from the file.
		/// </returns>
		public static bool CarregaReservasParaLista(string filePath)
		{
			if (!File.Exists(filePath))
			{
				return false;
			}
			return Reservas.CarregaReservasParaLista(filePath);
		}

		/// <summary>
		/// Saves all reservations to a file.
		/// </summary>
		/// <param name="filePath">The file path where reservations will be saved.</param>
		/// <returns>
		/// Returns `false` if the file path does not exist. Otherwise, it calls `Reservas.GuardaReservasParaFicheiro` to save the reservations to the file.
		/// </returns>
		public static bool GuardaReservasParaFicheiro(string filePath)
		{
			if (!File.Exists(filePath))
			{
				return false;
			}
			return Reservas.GuardaReservasParaFicheiro(filePath);
		}
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}