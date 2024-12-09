/*
*	<copyright file="ObjetosNegocio" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>10/26/2024 9:18:38 PM</date>
*	<description></description>
*/


using System;

namespace ObjetosNegocio
{
	/// <summary>
	/// Purpose: Check-out class
	/// Created by: Hugo
	/// Created on: 10/26/2024 9:18:38 PM
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public class Check_out : Registo
	{
		#region Attributes
		private bool pagamento;
		#endregion

		#region Methods

		#region Constructors
		/// <summary>
		/// Default constructor for the Check_out class.
		/// Calls the base class constructor and initializes the payment status to false.
		/// </summary>
		public Check_out() : base()
		{
			this.pagamento = false;
		}

		/// <summary>
		/// Parameterized constructor for the Check_out class.
		/// Initializes a check-out instance with the specified date, client ID, accommodation ID, and payment status.
		/// Calls the base class constructor with the provided parameters and sets the payment status.
		/// </summary>
		/// <param name="data">The date of the check-out.</param>
		/// <param name="idCliente">The ID of the client associated with the check-out.</param>
		/// <param name="idAlojamento">The ID of the accommodation associated with the check-out.</param>
		/// <param name="pagamento">The payment status of the check-out (true if paid, false otherwise).</param>
		public Check_out(DateTime data, int idCliente, int idAlojamento, bool pagamento, int idRegisto) : base(data, idCliente, idAlojamento, idRegisto)
		{
			this.pagamento = pagamento;
		}
		#endregion

		#region Properties
		/// <summary>
		/// Property for accessing and setting the payment status of the check-out.
		/// </summary>
		public bool Pagamento
		{
			get { return this.pagamento; }
			set { this.pagamento = value; }
		}
		#endregion

		#region Operators
		#endregion

		#region Overrides
		public override void exibirRegisto()
		{
			Console.WriteLine($"{IdRegisto},Data Check-out: {Data},{IdAlojamento},{IdCliente}");
		}
		#endregion

		#region OtherMethods
		/// <summary>
		/// Sets the payment status of the check-out based on the provided status and returns the updated status.
		/// </summary>
		/// <param name="statusPagamento">The desired payment status (true if paid, false otherwise).</param>
		/// <returns>Returns true if the payment status is set to paid; false otherwise.</returns>
		public bool PagamentoEfetuado(bool statusPagamento)
		{
			if(statusPagamento)
			{
				pagamento = true;
				return true;
			}
			else
			{
				pagamento = false; 
				return false;
			}
		}
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}