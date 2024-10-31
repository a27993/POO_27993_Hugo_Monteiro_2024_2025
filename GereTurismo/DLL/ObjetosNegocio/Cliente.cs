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

namespace ObjetosNegocio
{
	/// <summary>
	/// Purpose: 
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
		static List<Cliente> clientes = new List<Cliente>();
		#endregion

		#region Methods

		#region Constructors
		public Cliente()
		{
			this.nome = "";
			this.email = "";
			this.cc = "";
			this.nif = "";
			this.telemovel = "";
			this.id = 0;
		}

		public Cliente(string nome, string cc, string nif, string email, string telemovel, int id)
		{
			this.nome = nome;
			this.cc = cc;
			this.telemovel = telemovel;
			this.nif = nif;
			this.email = email;
			this.id = id;

		}
		#endregion

		#region Properties
		public int Id
		{
			get { return this.id; }
			set { this.id = value; }
		}
		public string Name
		{
			get { return this.nome; }
			set { this.nome = value; }
		}

		public string CC
		{
			get { return this.cc; }
			set { this.cc = value; }
		}

		public string Email
		{
			get { return this.email; }
			set { this.email = value; }
		}

		public string Telemovel
		{
			get { return this.telemovel; }
			set { this.telemovel = value; }
		}

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
		/**
		 * Create client
		 * Remove client
		 */
		public static int CriarCliente(string nome,string cc,string email,string telemovel,string nif,int id)
		{
			Cliente criarCliente = new Cliente(nome,cc,email,telemovel,nif,id);
			clientes.Add(criarCliente);
			return 1;
		}

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

		public void mostrarCliente()
		{
            Console.WriteLine($"{nome},{cc},{email},{telemovel},{nif},{id}");
		}

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