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
	/// Purpose: 
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
		public static int criarCheckOut(DateTime data, int idCliente, int idAlojamento,string pagamento)
		{
			if(data == null || idCliente <= 0 || idAlojamento <= 0 || string.IsNullOrEmpty(pagamento))
			{
				return -1;
			}
			return Check_outs.criarCheckOut(data,idCliente,idAlojamento,pagamento);
		}

		public static int alterarCheckOut(int idCheckOut, DateTime novaData)
		{
			if(idCheckOut <= 0 || novaData == null)
			{
				return -2;
			}
			return Check_outs.alterarCheckOut(idCheckOut, novaData);
		}

		public static int removeCheckOut(int idCheckOut)
		{
			if(idCheckOut <= 0)
			{
				return -1;
			}
			return Check_outs.removeCheckOut(idCheckOut);
		}

		public static int removeTodosCheckOuts()
		{
			return Check_outs.removeTodosCheckOuts();
		}

		public static List<Check_out> mostrarTodosCheckOuts()
		{
			return Check_outs.Check_Outs;
		}

		public static bool CarregaCheckOutsParaLista(string filePath)
		{
			if(filePath == null)
			{
				return false;
			}
			return Check_outs.CarregaCheckOutsParaLista(filePath);
		}

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