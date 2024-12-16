/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>12/15/2024 7:14:41 PM</date>
*	<description></description>
*/


using System;

namespace ObjetosNegocio
{
	/// <summary>
	/// Purpose: 
	/// Created by: Hugo
	/// Created on: 12/15/2024 7:14:41 PM
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public interface IUtilizador
	{
		#region Methods

		#region Properties
		string Nome { get; set; }
		string CC { get; set; }
		string Email { get; set; }
		string Telemovel { get; set; }
		string Nif { get; set; }
		string Password { get; set; }
		int Tipo { get; set; }
		int Id { get; set; }
		#endregion

		#region Operators
		#endregion

		#region Overrides
		#endregion

		#region OtherMethods
		string tipoUtilizador(int tipo);
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}