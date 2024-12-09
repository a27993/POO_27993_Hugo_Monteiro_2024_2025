
/*
*	<copyright file="Dados" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>07/12/2024 00:25:12</date>
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
	/// Created on: 07/12/2024 00:25:12
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public class Alojamentos
	{
		#region Attributes
		static List<Alojamento> a;
		#endregion

		#region Methods

		#region Constructors
		/// <summary>
		/// Static constructor for the Alojamento class.
		/// Initializes the list of accommodations and sets the initial total ID count to zero.
		/// </summary>
		static Alojamentos()
		{
			a = new List<Alojamento>();
		}
		#endregion

		#region Properties
		/// <summary>
		/// Static property for accessing the list of all accommodation instances.
		/// </summary>
		public static List<Alojamento> A
		{
			get { return a; }
		}
		#endregion

		#region Operators
		#endregion

		#region Overrides
		#endregion

		#region OtherMethods
		/// <summary>
		/// Creates a new accommodation with the specified location, price per night, and capacity.
		/// Adds the new accommodation to the list and returns 1 to indicate success.
		/// </summary>
		/// <param name="localizacao">The location of the accommodation.</param>
		/// <param name="precoPorNoite">The price per night for the accommodation.</param>
		/// <param name="capacidade">The capacity of the accommodation.</param>
		/// <returns>Returns 1 if the accommodation is created successfully.</returns>
		public static int criarAlojamento(string localizacao, double precoPorNoite, int capacidade)
		{
			Alojamento alojamento = new Alojamento(localizacao, precoPorNoite, capacidade);
			a.Add(alojamento);
			return 1;
		}

		public static int alterarAlojamento(double novoPrecoPorNoite, int id)
		{
			if (a.Exists(x => x.Id == id))
			{
				Alojamento alojamento = a.Find(x => x.Id == id);
				if (alojamento == null)
				{
					return -1;
				}
				alojamento.PrecoPorNoite = novoPrecoPorNoite;
				return 1;
			}
			return 0;
		}

		/// <summary>
		/// Removes an accommodation from the list based on the specified ID.
		/// Searches for the accommodation with the given ID and removes it if found.
		/// </summary>
		/// <param name="id">The ID of the accommodation to be removed.</param>
		/// <returns>Returns 1 if the accommodation is removed successfully; returns 0 if the ID is not found.</returns>
		public static int removerAlojamento(int id)
		{
			Alojamento alojamento = a.Find(x => x.Id == id);
			if (alojamento != null)
			{
				a.Remove(alojamento);
				return 1;
			}
			else return 0;
		}
		/// <summary>
		/// Displays the details of all accommodations in the list in the console.
		/// Calls the mostraAlojamento method for each accommodation in the list.
		/// </summary>
		public static void mostraTodosAlojamento()
		{
			foreach (var alojamento in a)
			{
				alojamento.mostraAlojamento();
			}
		}
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}