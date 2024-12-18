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
	/// Purpose: 
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
		public Check_ins()
		{
			check_ins = new List<Check_in>();
		}
		#endregion

		#region Properties
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

		public static int criarCheckIn(DateTime data, int idCliente, int idAlojamento)
		{
			Check_in check_in = new Check_in(data, idAlojamento, idCliente);
			check_ins.Add(check_in);
			return 1;
		}

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

		public static int removeTodosCheckIns()
		{
			check_ins.Clear();
			return 0;
		}

		public static void mostrarTodosCheckIns()
		{
			foreach (var check_in in check_ins)
			{
				check_in.exibirRegisto();
			}
		}

		public static bool CarregaCheckInsParaLista(string filePath)
		{
			// Lê todas as linhas do ficheiro
			string[] linhas = File.ReadAllLines(filePath);

			// Para cada linha no ficheiro, processa o conteúdo
			foreach (string linha in linhas)
			{
				// Divide a linha em partes
				string[] partes = linha.Split(';');

				// Verifica se há exatamente 4 partes
				if (partes.Length == 3)
				{
					DateTime data = DateTime.Parse(partes[0]);
					int idAlojamento = int.Parse(partes[1]);
					int idCliente = int.Parse(partes[2]);
					
					// Cria o objeto checkOut e adiciona-o à lista de checkOuts
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