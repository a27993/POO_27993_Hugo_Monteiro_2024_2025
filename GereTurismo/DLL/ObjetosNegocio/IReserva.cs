/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>12/15/2024 7:20:32 PM</date>
*	<description></description>
*/


using System;

namespace ObjetosNegocio
{
	/// <summary>
	/// Purpose: 
	/// Created by: Hugo
	/// Created on: 12/15/2024 7:20:32 PM
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public interface IReserva
	{
		#region Methods

		#region Properties
		int IdCliente { get; set; }
		int IdAlojamento { get; set; }
		DateTime DataInicio { get; set; }
		DateTime DataFim { get; set; }
		int IdReserva { get; set; }
		#endregion

		#region Operators
		#endregion

		#region Overrides
		#endregion

		#region OtherMethods
		void mostrarReserva();
		double calcularPrecoTotal(double precoPorNoite);
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}