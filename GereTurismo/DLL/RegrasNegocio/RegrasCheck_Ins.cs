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
	/// Purpose: 
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
		public static int confirmaDados(int idReserva, int idCliente)
		{
			if (idReserva <= 0 ||  idCliente <= 0)
			{
				return -3;
			}
			return Check_ins.confirmaDados(idReserva, idCliente);
		}

		public static int criarCheckIn(DateTime data, int idCliente, int idAlojamento)
		{
			if (data == null || idCliente <= 0 || idAlojamento <= 0)
			{
				return -1;
			}
			return Check_ins.criarCheckIn(data, idCliente, idAlojamento);
		}

		public static int alterarCheckIn(int idCheckIn, DateTime novaData)
		{
			if(idCheckIn <= 0 || novaData == null) 
			{ 	
				return -1; 
			}
			return Check_ins.alterarCheckIn(idCheckIn, novaData);
		}

		public static int removeCheckIn(int idCheckIn)
		{
			if(idCheckIn <= 0)
			{
				return -1;
			}
			return Check_ins.removeCheckIn(idCheckIn);
		}

		public static int removeTodosCheckIns()
		{
			return Check_ins.removeTodosCheckIns();
		}

		public static List<Check_in> mostrarTodosCheckIns()
		{
			return Check_ins.Check_Ins;
		}
		public static bool CarregaCheckInsParaLista(string filePath)
		{
			if(filePath == null)
			{
				return false;
			}
			return Check_ins.CarregaCheckInsParaLista(filePath);
		}

		public static bool GuardaCheckInParaFicheiro(string filePath)
		{
			if(filePath == null)
			{
				return false;
			}
			return Check_ins.GuardaCheckInParaFicheiro(filePath);
		}
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}