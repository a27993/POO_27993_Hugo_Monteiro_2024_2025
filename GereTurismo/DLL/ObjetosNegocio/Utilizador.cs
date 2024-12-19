/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>27/11/2024 20:11:03</date>
*	<description></description>
*/


using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ObjetosNegocio
{
	/// <summary>
	/// Purpose: User Class
	/// Created by: Hugo
	/// Created on: 27/11/2024 20:11:03
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public class Utilizador : IUtilizador
	{
		#region Attributes
		private string nome;
		private string cc;
		private string email;
		private string telemovel;
		private string nif;
		private string password;
		private int tipo;
		private int id;	
		private static int totalId = 1;


		public string Display => $"Id:{Id} - Nome:{Nome} - CC:{CC} - Email:{Email} - Telemovel:{Telemovel} - Nif:{Nif} - Password:{Password} - Tipo:{Tipo}";
		#endregion

		#region Methods

		#region Constructors
		/// <summary>
		/// Default constructor for the User class.
		/// Initializes a user with default values: empty name, email, ID number (CC), NIF, and phone number.
		/// </summary>
		public Utilizador()
		{
			this.nome = "";
			this.email = "";
			this.cc = "";
			this.nif = "";
			this.telemovel = "";
			this.password = "";
			this.tipo = -1;
			this.id = totalId;
			totalId++;
		}

		/// <summary>
		/// Parameterized constructor for the user class.
		/// Allows initializing a client with specific values for name, ID number (CC), NIF, email, and phone number.
		/// </summary>
		/// <param name="nome">The name of the client.</param>
		/// <param name="cc">The identification number (CC) of the client.</param>
		/// <param name="nif">The tax identification number (NIF) of the user.</param>
		/// <param name="email">The email address of the user.</param>
		/// <param name="telemovel">The phone number of the user.</param>
		public Utilizador(string nome, string cc, string nif, string email, string telemovel,int tipo, string password)
		{
			this.nome = nome;
			this.cc = cc;
			this.telemovel = telemovel;
			this.nif = nif;
			this.email = email;
			this.password = password;
			this.tipo = tipo;
			this.id = totalId;
			totalId++;
		}
		#endregion

		#region Properties
		/// <summary>
		/// Static property for accessing the total ID value.
		/// </summary>
		public static int TotalId
		{
			get { return totalId; }
		}
		/// <summary>
		/// Property for accessing and setting the user's password.
		/// </summary>
		public string Password
		{
			get { return this.password; }
			set { this.password = value; }
		}
		/// <summary>
		/// Property for accessing and setting the unique identifier of the user.
		/// </summary>
		public int Id
		{
			get { return this.id; }
			set { this.id = value; }
		}
		/// <summary>
		/// Property for accessing and setting the type associated with the user.
		/// </summary>
		public int Tipo
		{
			get { return this.tipo; }
			set { this.tipo = value; }
		}

		/// <summary>
		/// Property for accessing and setting the name of the user.
		/// </summary>
		public string Nome
		{
			get { return this.nome; }
			set { this.nome = value; }
		}

		/// <summary>
		/// Property for accessing and setting the identification number (CC) of the user.
		/// </summary>
		public string CC
		{
			get { return this.cc; }
			set { this.cc = value; }
		}

		/// <summary>
		/// Property for accessing and setting the email address of the user.
		/// </summary>
		public string Email
		{
			get { return this.email; }
			set { this.email = value; }
		}

		/// <summary>
		/// Property for accessing and setting the phone number of the user.
		/// </summary>
		public string Telemovel
		{
			get { return this.telemovel; }
			set { this.telemovel = value; }
		}

		/// <summary>
		/// Property for accessing and setting the tax identification number (NIF) of the user.
		/// </summary>
		public string Nif
		{
			get { return this.nif; }
			set { this.nif = value; }
		}
		#endregion

		#region Operators
		#endregion

		#region Overrides
		#endregion

		#region OtherMethods
		/// <summary>
		/// Method that returns the user type as a string based on the provided integer value.
		/// </summary>
		/// <param name="tipo">An integer representing the user type (1 for 'Funcionario', 0 for 'Cliente, other for 'Nao definido').</param>
		/// <returns>
		/// A string representing the user type:
		/// - "Funcionario" if tipo is 1.
		/// - "Cliente" if tipo is 0.
		/// - "Nao definido" if tipo is any other value.
		/// </returns>
		public string tipoUtilizador(int tipo)
		{
			if (tipo == 1)
			{
				return "Funcionario";
			}
			else if (tipo == 0)
			{
				return "Cliente";
			}
			else return "Nao definido"; //if dont exists
		}
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}