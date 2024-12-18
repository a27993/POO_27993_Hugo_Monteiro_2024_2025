/*
*	<copyright file="RegrasNegocio" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>12/8/2024 11:36:36 PM</date>
*	<description></description>
*/


using System;
using System.Collections.Generic;
using System.IO;
using Dados;
using ObjetosNegocio;


namespace RegrasNegocio
{
	/// <summary>
	/// Purpose: 
	/// Created by: Hugo
	/// Created on: 12/8/2024 11:36:36 PM
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public class RegrasUtilizadores
	{
		#region Attributes
		#endregion

		#region Methods

		#region Constructors
		#endregion

		#region Properties
		#endregion

		#region Operators
		#endregion

		#region Overrides
		#endregion

		#region OtherMethods
		public static int criarCliente(string nome, string cc, string email, string telemovel, string nif, string password)
		{
			if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cc) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telemovel) || string.IsNullOrEmpty(nif) || string.IsNullOrEmpty(password))
			{
				return -2;
			}
			return Utilizadores.criarCliente(nome, cc, email, telemovel, nif, password);
		}

		public static int criarFuncionario(string nome, string cc, string email, string telemovel, string nif, string password)
		{
			if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cc) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telemovel) || string.IsNullOrEmpty(nif) || string.IsNullOrEmpty(password))
			{
				return -2;
			}
			return Utilizadores.criarFuncionario(nome, cc, email, telemovel, nif, password);
		}

		public static int Login(string email, string password)
		{
			if (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password))
			{
				return -1;
			}
			return Utilizadores.Login(email, password);
		}

		public static int ObterTipoLogado()
		{
			if(Utilizadores.TipoLogado == null) return -1;
			return (int)Utilizadores.TipoLogado;
		}

		public static int ObterIdLogado()
		{
			if (Utilizadores.IdLogado == null) return -1;
			return (int)Utilizadores.IdLogado;
		}

		public static int AlterarPassword(string passwordAntiga, string passwordNova)
		{
			if (Utilizadores.IdLogado == null) //Se nao houver utilizadores logados
			{
				return -1;
			}
			if (!string.IsNullOrEmpty(passwordAntiga) && !string.IsNullOrEmpty(passwordNova))
			{
				return -3;
			}
			return Utilizadores.AlterarPassword(passwordAntiga, passwordNova);
		}

		public static bool Logout()
		{
			if (Utilizadores.IdLogado == null) //Se nao tiver logado
			{
				return false;
			}
			return Utilizadores.Logout();
		}

		public static int RemoverUtilizador(int id)
		{
			if (id <= 0)
			{
				return -1;
			}
			return Utilizadores.RemoverUtilizador(id);
		}

		public static int removerTodosUtilizador()
		{
			return Utilizadores.removerTodosUtilizador();
		}

		/// <summary>
		/// Displays the details of all users in the list in the console.
		/// Calls the mostrarUtilizador method for each users in the list.
		/// </summary>
		public static List<Utilizador> mostrarTodosUtilizadores()
		{
			return Utilizadores.U;
		}

		public static bool CarregaUtilizadoresParaLista(string filePath)
		{
			if (!File.Exists(filePath))
			{
				return false;
			}
			return Utilizadores.CarregaUtilizadoresParaLista(filePath);
		}

		public static bool GuardaUtilizadoresParaFicheiro(string filePath)
		{
			if (!File.Exists(filePath))
			{
				return false;
			}
			return Utilizadores.GuardaUtilizadoresParaFicheiro(filePath);
		}
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}