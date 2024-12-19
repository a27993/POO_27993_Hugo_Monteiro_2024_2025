/*
*	<copyright file="Dados" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>12/8/2024 9:22:38 PM</date>
*	<description></description>
*/


using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Dados
{
	/// <summary>
	/// Purpose: Check_ins class
	/// Created by: Hugo
	/// Created on: 12/8/2024 9:22:38 PM
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public class Check_ins
	{
		#region Attributes
		private static List<Check_in> check_ins;
		#endregion

		#region Methods

		#region Constructors
		// <summary>
		/// Static constructor for the Check_ins class.
		/// Initializes the list of check_ins.
		/// </summary>
		public Check_ins()
		{
			check_ins = new List<Check_in>();
		}
		#endregion

		#region Properties
		/// <summary>
		/// Static property for accessing the list of all check_ins instances.
		/// </summary>
		public static List<Check_in> Check_Ins
		{
			get { return check_ins; }
		}
		#endregion

		#region Operators
		#endregion

		#region Overrides
		#endregion

		#region OtherMethods
		/// <summary>
		/// Confirms reservation details based on the reservation ID.
		/// Searches for a reservation with the specified ID and checks if it exists.
		/// If the reservation exists, it verifies if the client ID matches the reservation's client ID.
		/// </summary>
		/// <param name="idReserva">The ID of the reservation to be confirmed.</param>
		/// <returns>Returns 1 if the reservation exists and the client ID matches; returns 0 otherwise.</returns>
		public static int confirmaDados(int idReserva, int idCliente)
		{
			Reserva reserva = Reservas.R.Find(x => x.IdReserva == idReserva);
			if (reserva != null) //if exists
			{
				if (reserva.IdCliente == idCliente) return 1;
				else return -1;
			}
			else return -2;
		}

		/// <summary>
		/// Creates a new check-in entry and adds it to the list of check-ins.
		/// </summary>
		/// <param name="data">The date of the check-in.</param>
		/// <param name="idCliente">The ID of the client making the check-in.</param>
		/// <param name="idAlojamento">The ID of the lodging where the check-in occurs.</param>
		/// <returns>
		/// Returns `1` if the check-in was successfully created and added to the list.
		/// </returns>
		public static int criarCheckIn(DateTime data, int idCliente, int idAlojamento)
		{
			Check_in check_in = new Check_in(data, idAlojamento, idCliente);
			check_ins.Add(check_in);
			return 1;
		}

		/// <summary>
		/// Modifies the check-in date for an existing check-in entry.
		/// </summary>
		/// <param name="idCheckIn">The ID of the check-in to be modified.</param>
		/// <param name="novaData">The new check-in date.</param>
		/// <returns>
		/// - `1` if the check-in was successfully modified.
		/// - `0` if no check-in with the specified ID was found.
		/// - `-1` if the check-in could not be found (null object).
		/// </returns>
		public static int alterarCheckIn(int idCheckIn, DateTime novaData)
		{
			if (check_ins.Exists(x => x.IdRegisto == idCheckIn))
			{
				Check_in check_in = check_ins.Find(x => x.IdRegisto == idCheckIn);
				if (check_in == null)
				{
					return -1;
				}
				check_in.Data = novaData;
				return 1;
			}
			return 0;
		}

		/// <summary>
		/// Removes an existing check-in based on the provided check-in ID.
		/// </summary>
		/// <param name="idCheckIn">The ID of the check-in to be removed.</param>
		/// <returns>
		/// - `1` if the check-in was successfully removed.
		/// - `0` if no check-in with the specified ID was found.
		/// </returns>

		public static int removeCheckIn(int idCheckIn)
		{
			Check_in check_in = check_ins.Find(x => x.IdRegisto == idCheckIn);
			if (check_in != null)
			{
				check_ins.Remove(check_in);
				return 1;
			}
			return 0;
		}

		/// <summary>
		/// Removes all check-ins from the list of check-ins.
		/// </summary>
		/// <returns>
		/// Always returns `0` as an indication that all check-ins have been cleared.
		/// </returns>
		public static int removeTodosCheckIns()
		{
			check_ins.Clear();
			return 0;
		}

		/// <summary>
		/// Displays all check-in records.
		/// </summary>
		public static void mostrarTodosCheckIns()
		{
			foreach (var check_in in check_ins)
			{
				check_in.exibirRegisto();
			}
		}

		/// <summary>
		/// Loads check-in data from a file and adds it to the list of check-ins.
		/// </summary>
		/// <param name="filePath">The path to the file containing the check-in data.</param>
		/// <returns>
		/// Returns `true` if the check-ins were successfully loaded and added to the list.
		/// </returns>
		/// <exception cref="Exception">Thrown when the file format is invalid or incomplete.</exception>
		public static bool CarregaCheckInsParaLista(string filePath)
		{
			// Reads all lines of the file
			string[] linhas = File.ReadAllLines(filePath);

			// Foreach line in the file, processes the content
			foreach (string linha in linhas)
			{
				// Divide the lines in parts
				string[] partes = linha.Split(';');

				// Verify if exists exactly 3 parts
				if (partes.Length == 3)
				{
					DateTime data = DateTime.Parse(partes[0]);
					int idAlojamento = int.Parse(partes[1]);
					int idCliente = int.Parse(partes[2]);

					// Create an check-in object and add it to the check-ins list
					Check_in check_In = new Check_in(data, idAlojamento, idCliente);
					check_ins.Add(check_In);
				}
				else
				{
					throw new Exception("Formato da linha inválido.");
				}
			}
			return true;
		}

		/// <summary>
		/// Saves all check-in data to a file.
		/// </summary>
		/// <param name="filePath">The path to the file where the check-in data should be saved.</param>
		/// <returns>
		/// Returns `true` if the check-in data was successfully saved to the file.
		/// </returns>
		public static bool GuardaCheckInParaFicheiro(string filePath)
		{
			using (StreamWriter writer = new StreamWriter(filePath)) //Open the file to write
			{
				foreach (Check_in check_In in check_ins)
				{
					writer.WriteLine($"{check_In.Data};{check_In.IdAlojamento};{check_In.IdCliente};{check_In.IdRegisto}");
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