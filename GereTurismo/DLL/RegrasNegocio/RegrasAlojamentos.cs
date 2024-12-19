/*
*	<copyright file="RegrasNegocio" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>12/8/2024 11:38:18 PM</date>
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
	/// Purpose: Accomodation rules class
	/// Created by: Hugo
	/// Created on: 12/8/2024 11:38:18 PM
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public class RegrasAlojamentos
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
		/// Creates a new accommodation if the provided data is valid.
		/// </summary>
		/// <param name="localizacao">The location of the accommodation.</param>
		/// <param name="precoPorNoite">The price per night for the accommodation.</param>
		/// <param name="capacidade">The capacity of the accommodation.</param>
		/// <returns>
		/// Returns `-1` if any of the provided data is invalid. 
		/// Otherwise, it calls the `Alojamentos.criarAlojamento` method to create the accommodation and returns the result.
		/// </returns>
		public static int criarAlojamento(string localizacao, double precoPorNoite, int capacidade)
		{
			if (string.IsNullOrEmpty(localizacao) || precoPorNoite <= 0 || capacidade <= 0)
			{
				return -1;
			}
			return Alojamentos.criarAlojamento(localizacao, precoPorNoite, capacidade);
		}

		/// <summary>
		/// Removes an accommodation by its ID.
		/// </summary>
		/// <param name="id">The ID of the accommodation to be removed.</param>
		/// <returns>
		/// Returns `-1` if the ID is invalid (less than or equal to 0). 
		/// Otherwise, it calls the `Alojamentos.removerAlojamento` method to remove the accommodation and returns the result.
		/// </returns>
		public static int removerAlojamento(int id)
		{
			if (id <= 0)
			{
				return -1;
			}
			return Alojamentos.removerAlojamento(id);
		}

		/// <summary>
		/// Alters the price per night of an accommodation by its ID.
		/// </summary>
		/// <param name="novoPrecoPorNoite">The new price per night for the accommodation.</param>
		/// <param name="id">The ID of the accommodation to be updated.</param>
		/// <returns>
		/// Returns `-1` if the ID is invalid (less than or equal to 0). 
		/// Otherwise, it calls the `Alojamentos.alterarAlojamento` method to update the accommodation price and returns the result.
		/// </returns>
		public static int alterarAlojamento(double novoPrecoPorNoite, int id)
		{
			if (id <= 0)
			{
				return -1;
			}
			return Alojamentos.alterarAlojamento(novoPrecoPorNoite, id);
		}

		/// <summary>
		/// Returns a list of all accommodations.
		/// </summary>
		/// <returns>
		/// A list of all accommodations from the `Alojamentos.A` list.
		/// </returns>
		public static List<Alojamento> mostraTodosAlojamento()
		{
			return Alojamentos.A;
		}

		/// <summary>
		/// Loads accommodations from a file and adds them to the list.
		/// </summary>
		/// <param name="filePath">The path to the file containing accommodation data.</param>
		/// <returns>
		/// Returns `false` if the file does not exist. 
		/// Otherwise, it calls `Alojamentos.CarregaAlojamentosParaLista` to load the accommodations and returns the result.
		/// </returns>
		public static bool CarregaAlojamentosParaLista(string filePath)
		{
			if (!File.Exists(filePath))
			{
				return false;
			}
			return Alojamentos.CarregaAlojamentosParaLista(filePath);
		}

		/// <summary>
		/// Saves accommodations to a file.
		/// </summary>
		/// <param name="filePath">The path to the file where the accommodation data will be saved.</param>
		/// <returns>
		/// Returns `false` if the file does not exist. 
		/// Otherwise, it calls `Alojamentos.GuardaAlojamentosParaFicheiro` to save the accommodations and returns the result.
		/// </returns>
		public static bool GuardaAlojamentosParaFicheiro(string filePath)
		{
			if (!File.Exists(filePath))
			{
				return false;
			}
			return Alojamentos.GuardaAlojamentosParaFicheiro(filePath);
		}
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}