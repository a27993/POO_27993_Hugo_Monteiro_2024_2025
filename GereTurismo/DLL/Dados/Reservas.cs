/*
*	<copyright file="Dados" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>07/12/2024 00:31:51</date>
*	<description></description>
*/


using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace Dados
{
	/// <summary>
	/// Purpose: 
	/// Created by: Hugo
	/// Created on: 07/12/2024 00:31:51
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public class Reservas
	{
		#region Attributes
		private static List<Reserva> r;
		#endregion

		#region Methods

		#region Constructors
		/// <summary>
		/// Static constructor for the Reserva class.
		/// Initializes the list of reservations.
		/// </summary>
		static Reservas()
		{
			r = new List<Reserva>();
		}
		#endregion

		#region Properties
		/// <summary>
		/// Static property for accessing the list of all reservation instances.
		/// </summary>
		public static List<Reserva> R
		{
			get { return r; }
		}
		#endregion

		#region Operators
		#endregion

		#region Overrides
		#endregion

		#region OtherMethods
		/// <summary>
		/// Creates a new reservation and adds it to the list of reservations.
		/// </summary>
		/// <param name="idCliente">The ID of the client making the reservation.</param>
		/// <param name="idAlojamento">The ID of the lodging being reserved.</param>
		/// <param name="dataInicio">The start date of the reservation.</param>
		/// <param name="dataFim">The end date of the reservation.</param>
		/// <returns>
		/// Returns `1` if the reservation was successfully created and added to the list.
		/// </returns>
		public static int criaReserva(int idCliente, int idAlojamento, DateTime dataInicio, DateTime dataFim)
		{ 
			Reserva reserva = new Reserva(idCliente, idAlojamento, dataInicio, dataFim);
			r.Add(reserva);
			return 1;
		}

		/// <summary>
		/// Modifies the start and end dates of an existing reservation.
		/// </summary>
		/// <param name="idReserva">The ID of the reservation to be modified.</param>
		/// <param name="novaDataInicio">The new start date for the reservation.</param>
		/// <param name="novaDataFim">The new end date for the reservation.</param>
		/// <returns>
		/// - `1` if the reservation was successfully modified.
		/// - `0` if no reservation with the specified ID was found.
		/// - `-1` if the reservation could not be found (null object).
		/// </returns>
		public static int alterarReserva(int idReserva, DateTime novaDataInicio, DateTime novaDataFim)
		{
			if (encontrarReserva(idReserva) == 1)
			{
				Reserva reserva = r.Find(x => x.IdReserva == idReserva);
				if (reserva == null)
				{
					return -1;
				}
				reserva.DataInicio = novaDataInicio;
				reserva.DataFim = novaDataFim;
				return 1;
			}
			return 0;
		}

		/// <summary>
		/// Removes a reservation based on the provided reservation ID.
		/// </summary>
		/// <param name="idReserva">The ID of the reservation to be removed.</param>
		/// <returns>
		/// - `1` if the reservation was successfully removed.
		/// - `-1` if no reservation with the specified ID was found.
		/// </returns>
		public static int removeReserva(int idReserva)
		{
			Reserva removeReserva = r.Find(x => x.IdReserva == idReserva);
			if (removeReserva != null)
			{
				r.Remove(removeReserva);
				return 1;
			}
			else return -1;
		}

		/// <summary>
		/// Removes all reservations from the list of reservations.
		/// </summary>
		/// <returns>
		/// Always returns `true` as an indication that all reservations have been cleared.
		/// </returns>
		public static bool removeTodasReservas()
		{
			r.Clear();
			return true;
		}

		/// <summary>
		/// Checks if a reservation with the given ID exists.
		/// </summary>
		/// <param name="idReserva">The ID of the reservation to find.</param>
		/// <returns>
		/// - `1` if the reservation was found.
		/// - `-1` if no reservation with the specified ID was found.
		/// </returns>
		public static int encontrarReserva(int idReserva)
		{
			Reserva encontrarReserva = r.Find(x => x.IdReserva == idReserva);
			if (encontrarReserva != null)
			{
				return 1;
			}
			else return -1;
		}

		/// <summary>
		/// Finds all reservations associated with a specific client ID.
		/// </summary>
		/// <param name="idCliente">The ID of the client whose reservations are to be retrieved.</param>
		/// <returns>
		/// A list of reservations associated with the given client ID.
		/// </returns>
		public static List<Reserva> encontrarReservasUtilizador(int idCliente)
		{
			List<Reserva> encontrarReservasUtilizador = r.FindAll(x => x.IdCliente == idCliente);
			return encontrarReservasUtilizador;
		}

		/// <summary>
		/// Displays all reservation records.
		/// </summary>
		public static void mostrarTodasReserva()
		{
			foreach (var reserva in r)
			{
				reserva.mostrarReserva();
			}
		}

		/// <summary>
		/// Loads reservation data from a file and adds it to the list of reservations.
		/// </summary>
		/// <param name="filePath">The path to the file containing the reservation data.</param>
		/// <returns>
		/// Returns `true` if the reservations were successfully loaded and added to the list.
		/// </returns>
		/// <exception cref="Exception">Thrown when the file format is invalid or incomplete.</exception>
		public static bool CarregaReservasParaLista(string filePath)
		{
			// Reads all lines of the file
			string[] linhas = File.ReadAllLines(filePath);

			// Foreach line in the file, processes the content
			foreach (string linha in linhas)
			{
				// Divide the lines in parts
				string[] partes = linha.Split(';');

				// Verify if exists exactly 4 parts
				if (partes.Length == 4)
				{
					int idCliente = int.Parse(partes[0]);
					int idAlojamento = int.Parse(partes[1]);
					DateTime dataInicio = DateTime.Parse(partes[2]);
					DateTime dataFim = DateTime.Parse(partes[3]);

					// Create an reservation object and add it to the reservation list
					Reserva reserva = new Reserva(idCliente, idAlojamento, dataInicio, dataFim);
					r.Add(reserva);
				}
				else
				{
					throw new Exception("Formato da linha inválido.");
				}
			}
			return true;
		}

		/// <summary>
		/// Saves all reservation data to a file.
		/// </summary>
		/// <param name="filePath">The path to the file where the reservation data should be saved.</param>
		/// <returns>
		/// Returns `true` if the reservation data was successfully saved to the file.
		/// </returns>
		public static bool GuardaReservasParaFicheiro(string filePath)
		{
			using (StreamWriter writer = new StreamWriter(filePath)) //Open the file to write
			{
				foreach (Reserva reserva in r)
				{
					writer.WriteLine($"{reserva.IdCliente};{reserva.IdAlojamento};{reserva.DataInicio};{reserva.DataFim}");
				}
			}
			return true;
		}
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}