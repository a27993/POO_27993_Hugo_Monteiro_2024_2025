//-----------------------------------------------------------------
//    <copyright file="Alojamentos.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>20-10-2024</date>
//    <time>22:00</time>
//    <version>0.1</version>
//    <author>Hugo Monteiro</author>
//-----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alojamentos
{
	public class alojamentos
	{
		#region Private
		private int id { get; set; }
		private string localizacao { get; set; }
		private double precoPorNoite { get; set; }
		private int capacidade { get; set; }
		#endregion

		#region Public
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

		#region Constructors
		public alojamentos()
		{
			this.id = 0;
			this.localizacao = "";
			this.precoPorNoite = 0.00;
			this.capacidade = 0;
		}
		#endregion
	}
}