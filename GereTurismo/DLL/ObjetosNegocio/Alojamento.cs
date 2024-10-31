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

namespace ObjetosNegocio
{
	/// <summary>
	/// Purpose: 
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
		static List<Alojamento> alojamentos = new List<Alojamento>();
		#endregion

		#region Methods

		#region Constructors
		public Alojamento()
		{
			this.id = 0;
			this.localizacao = "";
			this.precoPorNoite = 0.00;
			this.capacidade = 0;
		}
		public Alojamento(int id, string localizacao, double precoPorNoite, int capacidade)
		{
			this.id = id;
			this.localizacao = localizacao;
			this.precoPorNoite = precoPorNoite;
			this.capacidade = capacidade;

		}
		#endregion

		#region Properties
		public int Id
		{
			get { return this.id; }
			set { this.id = value; }
		}
		public string Localizacao
		{
			get { return this.localizacao; }
			set { this.localizacao = value; }
		}
		public double PrecoPorNoite
		{
			get { return this.PrecoPorNoite; }
			set { this.PrecoPorNoite = value; }
		}
		public int Capacidade
		{
			get { return this.Capacidade; }
			set { this.Capacidade = value; }
		}
		#endregion

		#region Operators
		#endregion

		#region Overrides
		#endregion

		#region OtherMethods
		public static int criarAlojamento(string localizacao, double precoPorNoite, int id, int capacidade)
		{
			Alojamento alojamento = new Alojamento(id, localizacao, precoPorNoite, capacidade);
			alojamentos.Add(alojamento);
			return 1;
		}

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

		public void mostraAlojamento()
		{
			Console.WriteLine($"{id}, {localizacao}, {precoPorNoite}, {capacidade}");
		}

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