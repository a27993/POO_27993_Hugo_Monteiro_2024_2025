/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>10/26/2024 9:19:38 PM</date>
*	<description></description>
*/


using System;

namespace ObjetosNegocio
{
	/// <summary>
	/// Purpose: query class
	/// Created by: Hugo
	/// Created on: 10/26/2024 9:19:38 PM
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public class Consoluta
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
		/// <summary>
		/// Displays all available accommodations in the console.
		/// Calls the static method mostraTodosAlojamento from the Alojamento class to show details of all accommodations.
		/// </summary>
		public void mostrarAlojamentosDisponiveis()
		{
			Alojamento.mostraTodosAlojamento();
		}
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}