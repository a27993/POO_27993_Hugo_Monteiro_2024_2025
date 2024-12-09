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
		/// Initializes the list of reservations and sets the initial total ID count to zero.
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
		public static int criaReserva(int idCliente, int idAlojamento, DateTime dataInicio, DateTime dataFim)
		{
			Reserva reserva = new Reserva(idCliente, idAlojamento, dataInicio, dataFim);
			r.Add(reserva);
			return 1;
		}

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

		public static bool removeTodasReservas()
		{
			r.Clear();
			return true;
		}

		public static int encontrarReserva(int idReserva)
		{
			Reserva encontrarReserva = r.Find(x => x.IdReserva == idReserva);
			if (encontrarReserva != null)
			{
				return 1;
			}
			else return -1;
		}

		public static void mostrarTodasReserva()
		{
			foreach (var reserva in r)
			{
				reserva.mostrarReserva();
			}
		}
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}