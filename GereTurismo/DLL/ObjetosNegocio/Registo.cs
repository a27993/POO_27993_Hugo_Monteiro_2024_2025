/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>10/26/2024 9:14:19 PM</date>
*	<description></description>
*/


using System;

namespace ObjetosNegocio
{
	/// <summary>
	/// Purpose: 
	/// Created by: Hugo
	/// Created on: 10/26/2024 9:14:19 PM
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public class Registo
	{
		#region Attributes
		private DateTime data;
		private int idAlojamento;
		private int idCliente;
		#endregion

		#region Methods

		#region Constructors
		public Registo()
		{
			this.data = DateTime.Now;
			this.idAlojamento = 0;
			this.idCliente = 0;
		}
		public Registo(DateTime data, int idAlojamento, int idCliente)
		{
			this.data = data;
			this.idAlojamento = idAlojamento;
			this.idCliente = idCliente;
		}
		#endregion

		#region Properties
		public DateTime Data
		{
			get { return this.data; }
			set { this.data = value; }
		}

		public int IdAlojamento
		{
			get { return this.idAlojamento; }
			set { this.idAlojamento = value; }
		}

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
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}