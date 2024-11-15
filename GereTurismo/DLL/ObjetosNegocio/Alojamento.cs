/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>10/26/2024 9:05:04 PM</date>
*	<description></description>
*/


using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ObjetosNegocio
{
	/// <summary>
	/// Purpose: Houses class
	/// Created by: Hugo
	/// Created on: 10/26/2024 9:05:04 PM
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public class Alojamento
	{
		#region Attributes
		private int id;
		private string localizacao;
		private double precoPorNoite;
		private int capacidade;
		static List<Alojamento> alojamentos;
		private static int totalId;
		#endregion

		#region Methods

		#region Constructors
		/// <summary>
		/// Static constructor for the Alojamento class.
		/// Initializes the list of accommodations and sets the initial total ID count to zero.
		/// </summary>
		static Alojamento()
		{
			alojamentos = new List<Alojamento>();
			totalId = 0;
		}
		/// <summary>
		/// Default constructor for the Alojamento class.
		/// Initializes an accommodation with default values: an empty location, zero price per night, and zero capacity.
		/// The ID is automatically assigned based on the current total ID count, which then increments.
		/// </summary>
		public Alojamento()
		{
			this.id = totalId;
			totalId++;
			this.localizacao = "";
			this.precoPorNoite = 0.00;
			this.capacidade = 0;
		}
		/// <summary>
		/// Parameterized constructor for the Alojamento class.
		/// Allows initializing an accommodation with specific values for location, price per night, and capacity.
		/// The ID is automatically assigned based on the current total ID count, which then increments.
		/// </summary>
		/// <param name="localizacao">The location of the accommodation.</param>
		/// <param name="precoPorNoite">The price per night for the accommodation.</param>
		/// <param name="capacidade">The capacity of the accommodation.</param>
		public Alojamento(string localizacao, double precoPorNoite, int capacidade)
		{
			this.id = totalId;
			totalId++;
			this.localizacao = localizacao;
			this.precoPorNoite = precoPorNoite;
			this.capacidade = capacidade;

		}
		#endregion

		#region Properties
		/// <summary>
		/// Property for accessing and setting the unique identifier (ID) of the accommodation.
		/// </summary>
		public int Id
		{
			get { return this.id; }
			set { this.id = value; }
		}
		/// <summary>
		/// Property for accessing and setting the location of the accommodation.
		/// </summary>
		public string Localizacao
		{
			get { return this.localizacao; }
			set { this.localizacao = value; }
		}
		/// <summary>
		/// Property for accessing and setting the price per night for the accommodation.
		/// </summary>
		public double PrecoPorNoite
		{
			get { return this.precoPorNoite; }
			set { this.precoPorNoite = value; }
		}
		/// <summary>
		/// Property for accessing and setting the capacity of the accommodation
		/// </summary>
		public int Capacidade
		{
			get { return this.capacidade; }
			set { this.capacidade = value; }
		}
		/// <summary>
		/// Static property for accessing the list of all accommodation instances.
		/// </summary>
		public static List<Alojamento> Alojamentos
		{
			get { return alojamentos; }
		}
		/// <summary>
		/// Static property for accessing the total count of IDs assigned to accommodations.
		/// </summary>
		public static int TotalId
		{
			get { return totalId; }
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
		public static int criarAlojamento(string localizacao, double precoPorNoite,int capacidade)
		{
			Alojamento alojamento = new Alojamento(localizacao, precoPorNoite, capacidade);
			alojamentos.Add(alojamento);
			return 1;
		}
		/// <summary>
		/// Removes an accommodation from the list based on the specified ID.
		/// Searches for the accommodation with the given ID and removes it if found.
		/// </summary>
		/// <param name="id">The ID of the accommodation to be removed.</param>
		/// <returns>Returns 1 if the accommodation is removed successfully; returns 0 if the ID is not found.</returns>
		public static int removerAlojamento(int id)
		{
			Alojamento alojamento = alojamentos.Find(x => x.id == id);
			if (alojamento != null)
			{
				alojamentos.Remove(alojamento);
				return 1;
			}
			else return 0;
		}
		/// <summary>
		/// Displays the details of an individual accommodation in the console.
		/// Shows the ID, location, price per night, and capacity of the accommodation.
		/// </summary>
		public void mostraAlojamento()
		{
			Console.WriteLine($"{id}, {localizacao}, {precoPorNoite}, {capacidade}");
		}
		/// <summary>
		/// Displays the details of all accommodations in the list in the console.
		/// Calls the mostraAlojamento method for each accommodation in the list.
		/// </summary>
		public static void mostraTodosAlojamento()
		{
			foreach (var alojamento in alojamentos)
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