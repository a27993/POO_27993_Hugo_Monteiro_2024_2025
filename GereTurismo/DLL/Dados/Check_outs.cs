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
using ObjetosNegocio;

namespace Dados
{
	/// <summary>
	/// Purpose: 
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
		public Check_outs()
		{
			check_outs = new List<Check_out>();	
		}
		#endregion

		#region Properties
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
		public static int criarCheckOut(DateTime data, int idCliente, int idAlojamento, int idRegisto, bool pagamento)
		{
			Check_out check_out = new Check_out(data, idAlojamento, idCliente, pagamento, idRegisto);
			check_outs.Add(check_out);
			return 1;
		}

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

		public static int removeTodosCheckOuts()
		{
			check_outs.Clear();
			return 0;
		}

		public static void mostrarTodosCheckOuts()
		{
			foreach (var check_out in check_outs)
			{
				check_out.exibirRegisto();
			}
		}
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}