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
	/// Purpose: Users rules class
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
		/// <summary>
		/// Creates a new client with the provided details.
		/// Validates that none of the input fields are empty or null. 
		/// Returns -2 if any field is invalid.
		/// Calls the Utilizadores.criarCliente method to create the client.
		/// </summary>
		/// <param name="nome">The name of the client.</param>
		/// <param name="cc">The citizen card number of the client.</param>
		/// <param name="email">The email address of the client.</param>
		/// <param name="telemovel">The mobile phone number of the client.</param>
		/// <param name="nif">The tax identification number (NIF) of the client.</param>
		/// <param name="password">The password for the client.</param>
		/// <returns>Returns an integer indicating the result of the client creation process.</returns>
		public static int criarCliente(string nome, string cc, string email, string telemovel, string nif, string password)
		{
			if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cc) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telemovel) || string.IsNullOrEmpty(nif) || string.IsNullOrEmpty(password))
			{
				return -2;
			}
			return Utilizadores.criarCliente(nome, cc, email, telemovel, nif, password);
		}

		/// <summary>
		/// Creates a new employee with the provided details.
		/// Validates that none of the input fields are empty or null. 
		/// Returns -2 if any field is invalid.
		/// Calls the Utilizadores.criarFuncionario method to create the employee.
		/// </summary>
		/// <param name="nome">The name of the employee.</param>
		/// <param name="cc">The citizen card number of the employee.</param>
		/// <param name="email">The email address of the employee.</param>
		/// <param name="telemovel">The mobile phone number of the employee.</param>
		/// <param name="nif">The tax identification number (NIF) of the employee.</param>
		/// <param name="password">The password for the employee.</param>
		/// <returns>Returns an integer indicating the result of the employee creation process.</returns>
		public static int criarFuncionario(string nome, string cc, string email, string telemovel, string nif, string password)
		{
			if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cc) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telemovel) || string.IsNullOrEmpty(nif) || string.IsNullOrEmpty(password))
			{
				return -2;
			}
			return Utilizadores.criarFuncionario(nome, cc, email, telemovel, nif, password);
		}

		/// <summary>
		/// Authenticates a user by their email and password.
		/// Returns -1 if either the email or password is null or empty.
		/// Calls the Utilizadores.Login method to attempt the login.
		/// </summary>
		/// <param name="email">The email address of the user.</param>
		/// <param name="password">The password of the user.</param>
		/// <returns>Returns an integer indicating the result of the login process.</returns>
		public static int Login(string email, string password)
		{
			if (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password))
			{
				return -1;
			}
			return Utilizadores.Login(email, password);
		}

		/// <summary>
		/// Retrieves the logged-in user's type.
		/// Returns -1 if no user is logged in or if the type is not available.
		/// </summary>
		/// <returns>Returns the type of the logged-in user as an integer.</returns>
		public static int ObterTipoLogado()
		{
			if(Utilizadores.TipoLogado == null) return -1;
			return (int)Utilizadores.TipoLogado;
		}

		/// <summary>
		/// Retrieves the logged-in user's ID.
		/// Returns -1 if no user is logged in or if the ID is not available.
		/// </summary>
		/// <returns>Returns the ID of the logged-in user as an integer.</returns>
		public static int ObterIdLogado()
		{
			if (Utilizadores.IdLogado == null) return -1;
			return (int)Utilizadores.IdLogado;
		}

		/// <summary>
		/// Changes the logged-in user's password.
		/// Returns -1 if no user is logged in.
		/// Returns -3 if both old and new passwords are not empty or null.
		/// Calls the Utilizadores.AlterarPassword method to change the password.
		/// </summary>
		/// <param name="passwordAntiga">The old password of the user.</param>
		/// <param name="passwordNova">The new password of the user.</param>
		/// <returns>Returns an integer indicating the result of the password change process.</returns>
		public static int AlterarPassword(string passwordAntiga, string passwordNova)
		{
			if (Utilizadores.IdLogado == null)
			{
				return -1;
			}
			if (!string.IsNullOrEmpty(passwordAntiga) && !string.IsNullOrEmpty(passwordNova))
			{
				return -3;
			}
			return Utilizadores.AlterarPassword(passwordAntiga, passwordNova);
		}

		/// <summary>
		/// Logs out the current logged-in user.
		/// Returns false if no user is logged in.
		/// Calls the Utilizadores.Logout method to log the user out.
		/// </summary>
		/// <returns>Returns a boolean indicating whether the logout was successful.</returns>
		public static bool Logout()
		{
			if (Utilizadores.IdLogado == null)
			{
				return false;
			}
			return Utilizadores.Logout();
		}

		/// <summary>
		/// Removes a user with the given ID.
		/// Returns -1 if the provided ID is invalid (less than or equal to 0).
		/// Calls the Utilizadores.RemoverUtilizador method to remove the user.
		/// </summary>
		/// <param name="id">The ID of the user to be removed.</param>
		/// <returns>Returns an integer indicating the result of the user removal process.</returns>
		public static int RemoverUtilizador(int id)
		{
			if (id <= 0)
			{
				return -1;
			}
			return Utilizadores.RemoverUtilizador(id);
		}

		/// <summary>
		/// Removes all users from the system.
		/// Calls the Utilizadores.removerTodosUtilizador method to remove all users.
		/// </summary>
		/// <returns>Returns an integer indicating the result of the removal process.</returns>
		public static int removerTodosUtilizador()
		{
			return Utilizadores.removerTodosUtilizador();
		}

		/// <summary>
		/// Displays the details of all users in the list in the console.
		/// Calls the mostrarUtilizador method for each user in the list.
		/// </summary>
		/// <returns>Returns a list of all users.</returns>
		public static List<Utilizador> mostrarTodosUtilizadores()
		{
			return Utilizadores.U;
		}

		/// <summary>
		/// Loads users from a file into the system.
		/// Returns false if the file does not exist.
		/// Calls the Utilizadores.CarregaUtilizadoresParaLista method to load the users from the specified file.
		/// </summary>
		/// <param name="filePath">The path to the file containing user data.</param>
		/// <returns>Returns a boolean indicating whether the users were successfully loaded.</returns>
		public static bool CarregaUtilizadoresParaLista(string filePath)
		{
			if (!File.Exists(filePath))
			{
				return false;
			}
			return Utilizadores.CarregaUtilizadoresParaLista(filePath);
		}

		/// <summary>
		/// Saves the list of users to a file.
		/// Returns false if the file does not exist.
		/// Calls the Utilizadores.GuardaUtilizadoresParaFicheiro method to save the users to the specified file.
		/// </summary>
		/// <param name="filePath">The path to the file where user data will be saved.</param>
		/// <returns>Returns a boolean indicating whether the users were successfully saved.</returns>
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