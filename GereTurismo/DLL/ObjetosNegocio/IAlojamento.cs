/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>12/15/2024 7:18:59 PM</date>
*	<description></description>
*/


using System;

namespace ObjetosNegocio
{
	/// <summary>
	/// Purpose: 
	/// Created by: Hugo
	/// Created on: 12/15/2024 7:18:59 PM
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public interface IAlojamento
	{
		#region Methods

		#region Properties
		int Id { get; set; }
		string Localizacao {  get; set; }
		double PrecoPorNoite { get; set; }
		int Capacidade { get; set; }
		#endregion

		#region Operators
		#endregion

		#region Overrides
		#endregion

		#region OtherMethods
		void mostraAlojamento();
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}