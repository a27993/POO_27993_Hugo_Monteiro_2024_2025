//-----------------------------------------------------------------
//    <copyright file="Cliente.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>20-10-2024</date>
//    <time>19:00</time>
//    <version>0.1</version>
//    <author>Hugo Monteiro</author>
//-----------------------------------------------------------------
using System;

namespace ObjetosNegocio
{
	public class Cliente
	{
		#region Private
		private string nome;
		private string cc;
		private string email;
		private string telemovel;
		private string nif;
		private int id;
		#endregion

		#region Public
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
		
		public Cliente(string nome, string cc,string nif,string email,string telemovel,int id)
		{
			this.nome = nome;
			this.cc = cc;
			this.telemovel = telemovel;
			this.nif = nif;
			this.email = email;
			this.id = id; 

		}
        #endregion

        #region Methods
		/**
		 * Criar cliente
		 * Remover cliente
		 */
        #endregion
    }
}
