/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>10/26/2024 9:14:19 PM</date>
*	<description></description>
*/


using System;
using System.Collections.Generic;

namespace ObjetosNegocio
{
	/// <summary>
	/// Purpose: Registration class	
	/// Created by: Hugo
	/// Created on: 10/26/2024 9:14:19 PM
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public abstract class Registo
	{
		#region Attributes
		private DateTime data;
		private int idAlojamento;
		private int idCliente;
		private int idRegisto;
		private static int totalId = 1;
		#endregion

		#region Methods

		#region Constructors
		/// <summary>
		/// Default constructor for the Registo class.
		/// Initializes the registration with the current date and default values of zero for accommodation and client IDs.
		/// </summary>
		public Registo()
		{
			this.data = DateTime.Now;
			this.idAlojamento = 0;
			this.idCliente = 0;
			this.idRegisto = totalId;
			totalId++;
		}

		/// <summary>
		/// Parameterized constructor for the Registo class.
		/// Initializes a registration with the specified date, accommodation ID, and client ID.
		/// </summary>
		/// <param name="data">The date of the registration.</param>
		/// <param name="idAlojamento">The ID of the associated accommodation.</param>
		/// <param name="idCliente">The ID of the associated client.</param>
		public Registo(DateTime data, int idAlojamento, int idCliente, int idRegisto)
		{
			this.data = data;
			this.idAlojamento = idAlojamento;
			this.idCliente = idCliente;
			this.idRegisto = totalId;
			totalId++;
		}
		#endregion

		#region Properties
		public int IdRegisto
		{
			get { return this.idRegisto; }
			set { this.idRegisto = value; }
		}

		public static int TotalId
		{
			get { return totalId; }
		}

		/// <summary>
		/// Property for accessing and setting the date of the registration.
		/// </summary>
		public DateTime Data
		{
			get { return this.data; }
			set { this.data = value; }
		}

		/// <summary>
		/// Property for accessing and setting the ID of the associated accommodation.
		/// </summary>
		public int IdAlojamento
		{
			get { return this.idAlojamento; }
			set { this.idAlojamento = value; }
		}

		/// <summary>
		/// Property for accessing and setting the ID of the associated client.
		/// </summary>
		public int IdCliente
		{
			get { return this.idCliente; }
			set { this.idCliente = value; }
		}
		#endregion

		#region Operators
		#endregion

		#region Overrides
		#endregion

		#region OtherMethods
		public abstract void exibirRegisto();
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}