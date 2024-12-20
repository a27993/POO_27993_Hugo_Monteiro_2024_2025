/*
*	<copyright file="Dados" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>12/8/2024 9:22:49 PM</date>
*	<description></description>
*/


using System;
using System.Collections.Generic;
using System.IO;
using ObjetosNegocio;

namespace Dados
{
	/// <summary>
	/// Purpose: Check-outs class
	/// Created by: Hugo
	/// Created on: 12/8/2024 9:22:49 PM
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public class Check_outs
	{
		#region Attributes
		private static List<Check_out> check_outs;
		#endregion

		#region Methods

		#region Constructors
		/// <summary>
		/// Static constructor for the check-out class.
		/// Initializes the list of check-outs.
		/// </summary>
		static Check_outs()
		{
			check_outs = new List<Check_out>();	
		}
		#endregion

		#region Properties
		/// <summary>
		/// Static property for accessing the list of all check-out instances.
		/// </summary>
		public static List<Check_out> Check_Outs
		{
			get { return check_outs; }
		}
		#endregion

		#region Operators
		#endregion

		#region Overrides
		#endregion

		#region OtherMethods
		/// <summary>
		/// Creates a new check-out entry and adds it to the list of check-outs.
		/// </summary>
		/// <param name="data">The date of the check-out.</param>
		/// <param name="idCliente">The ID of the client making the check-out.</param>
		/// <param name="idAlojamento">The ID of the lodging from which the client is checking out.</param>
		/// <param name="pagamento">The amount paid by the client at check-out.</param>
		/// <returns>
		/// Returns `1` if the check-out was successfully created and added to the list.
		/// </returns>
		public static int criarCheckOut(DateTime data, int idCliente, int idAlojamento,double pagamento)
		{
			Check_out check_out = new Check_out(data, idCliente, idAlojamento, pagamento);
			check_outs.Add(check_out);
			return 1;
		}

		/// <summary>
		/// Modifies the check-out date for an existing check-out entry.
		/// </summary>
		/// <param name="idCheckOut">The ID of the check-out to be modified.</param>
		/// <param name="novaData">The new check-out date.</param>
		/// <returns>
		/// - `1` if the check-out was successfully modified.
		/// - `0` if no check-out with the specified ID was found.
		/// - `-1` if the check-out could not be found (null object).
		/// </returns>
		public static int alterarCheckOut(int idCheckOut, DateTime novaData)
		{
			if (check_outs.Exists(x => x.IdRegisto == idCheckOut))
			{
				Check_out check_out = check_outs.Find(x => x.IdRegisto == idCheckOut);
				if (check_out == null)
				{
					return -1;
				}
				check_out.Data = novaData;
				return 1;
			}
			return 0;
		}

		/// <summary>
		/// Removes an existing check-out based on the provided check-out ID.
		/// </summary>
		/// <param name="idCheckOut">The ID of the check-out to be removed.</param>
		/// <returns>
		/// - `1` if the check-out was successfully removed.
		/// - `0` if no check-out with the specified ID was found.
		/// </returns>
		public static int removeCheckOut(int idCheckOut)
		{
			Check_out check_out = check_outs.Find(x => x.IdRegisto == idCheckOut);
			if (check_out != null)
			{
				check_outs.Remove(check_out);
				return 1;
			}
			return 0;
		}

		/// <summary>
		/// Removes all check-outs from the list of check-outs.
		/// </summary>
		/// <returns>
		/// Always returns `0` as an indication that all check-outs have been cleared.
		/// </returns>
		public static int removeTodosCheckOuts()
		{
			check_outs.Clear();
			return 0;
		}

		/// <summary>
		/// Displays all check-out records.
		/// </summary>
		public static void mostrarTodosCheckOuts()
		{
			foreach (var check_out in check_outs)
			{
				check_out.exibirRegisto();
			}
		}

		/// <summary>
		/// Loads check-out data from a file and adds it to the list of check-outs.
		/// </summary>
		/// <param name="filePath">The path to the file containing the check-out data.</param>
		/// <returns>
		/// Returns `true` if the check-outs were successfully loaded and added to the list.
		/// </returns>
		/// <exception cref="Exception">Thrown when the file format is invalid or incomplete.</exception>
		public static bool CarregaCheckOutsParaLista(string filePath)
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
					DateTime data = DateTime.Parse(partes[0]);
					int idCliente = int.Parse(partes[1]);
					int idAlojamento = int.Parse(partes[2]);
					double pagamento = double.Parse(partes[3]);

					// Create an reservation object and add it to the reservation list
					Check_out check_Out = new Check_out(data, idCliente, idAlojamento, pagamento);
					check_outs.Add(check_Out);
				}
				else
				{
					throw new Exception("Formato da linha inválido.");
				}
			}
			return true;
		}

		/// <summary>
		/// Saves all check-out data to a file.
		/// </summary>
		/// <param name="filePath">The path to the file where the check-out data should be saved.</param>
		/// <returns>
		/// Returns `true` if the check-out data was successfully saved to the file.
		/// </returns>
		public static bool GuardaCheckOutParaFicheiro(string filePath)
		{
			using (StreamWriter writer = new StreamWriter(filePath)) //Open the file to write
			{
				foreach (Check_out check_Out in check_outs)
				{
					writer.WriteLine($"{check_Out.Data};{check_Out.IdCliente};{check_Out.IdAlojamento};{check_Out.Pagamento}");
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