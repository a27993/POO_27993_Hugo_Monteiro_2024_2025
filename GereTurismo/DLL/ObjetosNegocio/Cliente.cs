/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>10/26/2024 8:59:35 PM</date>
*	<description></description>
*/


using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ObjetosNegocio
{
	/// <summary>
	/// Purpose: Client class
	/// Created by: Hugo
	/// Created on: 10/26/2024 8:59:35 PM
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public class Cliente
	{
		#region Attributes
		private string nome;
		private string cc;
		private string email;
		private string telemovel;
		private string nif;
		private int id;
		private static int totalId;
		static List<Cliente> clientes;
		#endregion

		#region Methods

		#region Constructors
		/// <summary>
		/// Static constructor for the Cliente class.
		/// Initializes the list of clients and sets the initial total ID count to 1.
		/// </summary>
		static Cliente()
		{
			clientes = new List<Cliente>();
			totalId = 1;
		}

		/// <summary>
		/// Default constructor for the Cliente class.
		/// Initializes a client with default values: empty name, email, ID number (CC), NIF, and phone number.
		/// The ID is automatically assigned based on the current total ID count, which then increments.
		/// </summary>
		public Cliente()
		{
			this.nome = "";
			this.email = "";
			this.cc = "";
			this.nif = "";
			this.telemovel = "";
			this.id = totalId;
			totalId++;
		}

		/// <summary>
		/// Parameterized constructor for the Cliente class.
		/// Allows initializing a client with specific values for name, ID number (CC), NIF, email, and phone number.
		/// The ID is automatically assigned based on the current total ID count, which then increments.
		/// </summary>
		/// <param name="nome">The name of the client.</param>
		/// <param name="cc">The identification number (CC) of the client.</param>
		/// <param name="nif">The tax identification number (NIF) of the client.</param>
		/// <param name="email">The email address of the client.</param>
		/// <param name="telemovel">The phone number of the client.</param>
		public Cliente(string nome, string cc, string nif, string email, string telemovel)
		{
			this.nome = nome;
			this.cc = cc;
			this.telemovel = telemovel;
			this.nif = nif;
			this.email = email;
			this.id = totalId;
			totalId++;
		}
		#endregion

		#region Properties
		/// <summary>
		/// Property for accessing and setting the unique identifier (ID) of the client.
		/// </summary>
		public int Id
		{
			get { return this.id; }
			set { this.id = value; }
		}

		/// <summary>
		/// Property for accessing and setting the name of the client.
		/// </summary>
		public string Name
		{
			get { return this.nome; }
			set { this.nome = value; }
		}

		/// <summary>
		/// Property for accessing and setting the identification number (CC) of the client.
		/// </summary>
		public string CC
		{
			get { return this.cc; }
			set { this.cc = value; }
		}

		/// <summary>
		/// Property for accessing and setting the email address of the client.
		/// </summary>
		public string Email
		{
			get { return this.email; }
			set { this.email = value; }
		}

		/// <summary>
		/// Property for accessing and setting the phone number of the client.
		/// </summary>
		public string Telemovel
		{
			get { return this.telemovel; }
			set { this.telemovel = value; }
		}

		/// <summary>
		/// Property for accessing and setting the tax identification number (NIF) of the client.
		/// </summary>
		public string Nif
		{
			get { return this.nif; }
			set { this.nif = value; }
		}

		/// <summary>
		/// Static property for accessing the list of all client instances.
		/// </summary>
		public static List<Cliente> Clientes
		{
			get { return clientes; }
		}

		/// <summary>
		/// Static property for accessing the total count of IDs assigned to clients.
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
		/// Creates a new client with the specified name, identification number, email, phone number, and tax identification number (NIF).
		/// Adds the new client to the list and returns 1 to indicate success.
		/// </summary>
		/// <param name="nome">The name of the client.</param>
		/// <param name="cc">The identification number of the client.</param>
		/// <param name="email">The email address of the client.</param>
		/// <param name="telemovel">The phone number of the client.</param>
		/// <param name="nif">The tax identification number (NIF) of the client.</param>
		/// <returns>Returns 1 if the client is created successfully.</returns>
		public static int CriarCliente(string nome,string cc,string email,string telemovel,string nif)
		{
			Cliente criarCliente = new Cliente(nome,cc,email,telemovel,nif);
			clientes.Add(criarCliente);
			return 1;
		}

		/// <summary>
		/// Removes a client from the list based on the specified ID.
		/// Searches for the client with the given ID and removes it if found.
		/// </summary>
		/// <param name="id">The ID of the client to be removed.</param>
		/// <returns>Returns 1 if the client is removed successfully; returns 0 if the ID is not found.</returns>
		public static int RemoverCliente(int id)
		{
			Cliente removeCliente = clientes.Find(x => x.Id == id); //Search if the client id exists

			if(removeCliente != null) //if exists remove, return 1 as successfull
			{
				clientes.Remove(removeCliente);
				return 1;
			}
			else return 0;
		}

		/// <summary>
		/// Displays the details of an individual client in the console.
		/// Shows the client's name, identification number, email, phone number, tax identification number (NIF), and ID.
		/// </summary>
		public void mostrarCliente()
		{
            Console.WriteLine($"{nome},{cc},{email},{telemovel},{nif},{id}");
		}

		/// <summary>
		/// Displays the details of all clients in the list in the console.
		/// Calls the mostrarCliente method for each client in the list.
		/// </summary>
		public void mostrarTodosClientes()
		{
			foreach(var cliente in clientes)
			{
				cliente.mostrarCliente();
			}
		}
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}