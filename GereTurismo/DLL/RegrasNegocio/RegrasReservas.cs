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
	/// Purpose: 
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
		public static int criaReserva(int idCliente, int idAlojamento, DateTime dataInicio, DateTime dataFim)
		{
			if (idCliente <= 0 || idAlojamento <= 0)
			{
				return -1;
			}
			return Reservas.criaReserva(idCliente, idAlojamento, dataInicio, dataFim);
		}

		public static int removeReserva(int idReserva)
		{
			if (idReserva <= 0)
			{
				return -2;
			}
			return Reservas.removeReserva(idReserva);
		}

		public static bool removeTodasReservas()
		{
			return Reservas.removeTodasReservas();
		}

		public static int alterarReserva(int idReserva, DateTime novaDataInicio, DateTime novaDataFim)
		{
			if (idReserva <= 0)
			{
				return -1;
			}
			return Reservas.alterarReserva(idReserva, novaDataInicio, novaDataFim);
		}

		public static int encontrarReserva(int idReserva)
		{
			if (idReserva <= 0)
			{
				return -2;
			}
			return Reservas.encontrarReserva(idReserva);
		}

		public static List<Reserva> encontrarReservasUtilizador(int idCliente)
		{
			if(idCliente <= 0)
			{
				return null;
			}
			return Reservas.encontrarReservasUtilizador(idCliente);
		}

		public static List<Reserva> mostrarTodasReserva()
		{
			return Reservas.R;
		}

		public static bool CarregaReservasParaLista(string filePath)
		{
			if (!File.Exists(filePath))
			{
				return false;
			}
			return Reservas.CarregaReservasParaLista(filePath);
		}

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