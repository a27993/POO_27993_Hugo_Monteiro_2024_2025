/*
*	<copyright file="RegrasNegocio" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>12/9/2024 1:03:24 AM</date>
*	<description></description>
*/


using Dados;
using System;
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
		public static int criarCheckOut(DateTime data, int idCliente, int idAlojamento, int idRegisto, bool pagamento)
		{
			if(data == null || idRegisto <= 0 || idCliente <= 0 || idAlojamento <= 0 || pagamento == false)
			{
				return -1;
			}
			return Check_outs.criarCheckOut(data,idCliente,idAlojamento,idRegisto,pagamento);
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

		public static void mostrarTodosCheckOuts()
		{
			Check_outs.mostrarTodosCheckOuts();
		}
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}