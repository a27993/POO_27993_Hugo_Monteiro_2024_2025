//-----------------------------------------------------------------
//    <copyright file="Clientes.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>20-10-2024</date>
//    <time>19:00</time>
//    <version>0.1</version>
//    <author>Hugo Monteiro</author>
//-----------------------------------------------------------------
using System;

namespace Clientes
{
	public class cliente
	{
		#region Private
		private string nome { get; set; }
		private string cc { get; set; }
		private string email { get; set; }
		private string telemovel { get; set; }
		private string nif { get; set; }
		private int id { get; set; }
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
		public cliente()
		{
			nome = "";
			email = "";
			cc = "";
			nif = "";
			telemovel = "";
			id = 0;
		}
		#endregion
	}
}
