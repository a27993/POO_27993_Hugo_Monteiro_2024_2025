//-----------------------------------------------------------------
//    <copyright file="Check-in.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>21-10-2024</date>
//    <time>15:00</time>
//    <version>0.1</version>
//    <author>Hugo Monteiro</author>
//-----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_in
{
    public class Check_in
    {
		#region Private
		private string dataEntrada {  get; set; }
        private string dataSaida { get; set; }
		#endregion

		#region Public
		public string DataEntrada
		{
			get { return this.dataEntrada; }
			set { this.dataEntrada = value; }
		}
		public string DataSaida
		{
			get { return this.dataSaida; }
			set { this.dataSaida = value; }
		}
		#endregion

		#region Constructors
		public Check_in()
		{
			this.dataEntrada = "";
			this.dataSaida = "";
		}
		#endregion
	}
}
