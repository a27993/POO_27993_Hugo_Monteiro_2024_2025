/*
*	<copyright file="Dados" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>06/12/2024 18:16:39</date>
*	<description></description>
*/


using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.IO;

namespace Dados
{
	/// <summary>
	/// Purpose: 
	/// Created by: Hugo
	/// Created on: 06/12/2024 18:16:39
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public class Utilizadores
	{
		#region Attributes
		static List<Utilizador> u;
		private static int? idLogado; //int or null
		private static int? tipoLogado;
		#endregion

		#region Methods

		#region Constructors
		/// <summary>
		/// Static constructor for the Utilizador class.
		/// Initializes the list of users.
		/// </summary>
		static Utilizadores()
		{
			u = new List<Utilizador>();
		}
		#endregion

		#region Properties
		/// <summary>
		/// Gets the type of the logged-in user. 
		/// The type is represented by an integer that indicates the user's role (e.g., admin, client, etc.).
		/// </summary>
		/// <returns>
		/// Returns an `int?` (nullable integer) representing the type of the logged-in user.
		/// It may return `null` if no user is logged in.
		/// </returns>
		public static int? TipoLogado
		{
			get { return tipoLogado; }
		}

		/// <summary>
		/// Gets the ID of the logged-in user.
		/// </summary>
		/// <returns>
		/// Returns an `int?` (nullable integer) representing the ID of the logged-in user.
		/// It may return `null` if no user is logged in.
		/// </returns>
		public static int? IdLogado
		{
			get { return idLogado; }
		}

		/// <summary>
		/// Gets the list of users.
		/// </summary>
		/// <returns>
		/// Returns a list of `Utilizador` objects representing all the users.
		/// </returns>
		public static List<Utilizador> U
		{
			get { return u; }
		}
		#endregion

		#region Operators
		#endregion

		#region Overrides
		#endregion

		#region OtherMethods
		/// <summary>
		/// Creates a new client and adds it to the list of users if the email is unique.
		/// </summary>
		/// <param name="nome">The name of the client.</param>
		/// <param name="cc">The identification card number of the client.</param>
		/// <param name="email">The email of the client.</param>
		/// <param name="telemovel">The phone number of the client.</param>
		/// <param name="nif">The NIF (taxpayer identification number) of the client.</param>
		/// <param name="password">The password for the client.</param>
		/// <returns>
		/// Returns 1 if the client was successfully created and added to the list.
		/// Returns -1 if a user with the same email already exists.
		/// </returns>
		public static int criarCliente(string nome, string cc, string email, string telemovel, string nif, string password)
		{
			if (u.Exists(x => x.Email == email))
			{
				return -1;
			}
			Utilizador cliente = new Utilizador(nome, cc, nif, email, telemovel, 0, password);
			u.Add(cliente);
			return 1;
		}

		/// <summary>
		/// Creates a new employee and adds it to the list of users if the email is unique.
		/// </summary>
		/// <param name="nome">The name of the employee.</param>
		/// <param name="cc">The identification card number of the employee.</param>
		/// <param name="email">The email of the employee.</param>
		/// <param name="telemovel">The phone number of the employee.</param>
		/// <param name="nif">The NIF (taxpayer identification number) of the employee.</param>
		/// <param name="password">The password for the employee.</param>
		/// <returns>
		/// Returns 1 if the employee was successfully created and added to the list.
		/// Returns -1 if a user with the same email already exists.
		/// </returns>
		public static int criarFuncionario(string nome, string cc, string email, string telemovel, string nif, string password)
		{
			if (u.Exists(x => x.Email == email))
			{
				return -1;
			}
			Utilizador funcionario = new Utilizador(nome, cc, email, telemovel, nif, 1, password);
			u.Add(funcionario);
			return 1;
		}

		/// <summary>
		/// Logs a user in by checking their email and password.
		/// </summary>
		/// <param name="email">The email of the user trying to log in.</param>
		/// <param name="password">The password of the user trying to log in.</param>
		/// <returns>
		/// Returns 1 if the login was successful.
		/// Returns -2 if the user with the specified email does not exist.
		/// Returns -3 if the password does not match.
		/// </returns>
		public static int Login(string email, string password)
		{
			Utilizador utilizador = u.Find(x => x.Email == email);
			if (utilizador == null) //Se nao existe
			{
				return -2;
			}
			if (utilizador.Password != password)//Se nao for igual a que escreveu
			{
				return -3;
			}
			idLogado = utilizador.Id;
			tipoLogado = utilizador.Tipo;
			return 1;
		}

		/// <summary>
		/// Changes the password for the logged-in user.
		/// </summary>
		/// <param name="passwordAntiga">The old password of the user.</param>
		/// <param name="passwordNova">The new password for the user.</param>
		/// <returns>
		/// Returns 1 if the password was successfully changed.
		/// Returns -2 if the user is not logged in.
		/// Returns -4 if the old password does not match.
		/// </returns>
		public static int AlterarPassword(string passwordAntiga, string passwordNova)
		{
			Utilizador utilizador = u.Find(x => x.Id == idLogado);
			if(utilizador == null)
			{
				return -2;
			}
			if (utilizador.Password == passwordAntiga) //se a password = password antiga
			{
				utilizador.Password = passwordNova; //muda a password para a nova
				return 1;
			}
			else return -4; //Se nao for igual nao muda
		}

		/// <summary>
		/// Logs the user out by clearing the logged-in user information.
		/// </summary>
		/// <returns>
		/// Returns `true` to indicate the user was successfully logged out.
		/// </returns>
		public static bool Logout()
		{
			idLogado = null;
			tipoLogado = null;
			return true;
		}

		/// <summary>
		/// Removes a user from the list based on the specified ID.
		/// Searches for the user with the given ID and removes it if found.
		/// </summary>
		/// <param name="id">The ID of the user to be removed.</param>
		/// <returns>Returns 1 if the user is removed successfully; returns 0 if the ID is not found.</returns>
		public static int RemoverUtilizador(int id)
		{
			Utilizador removeUtilizador = u.Find(x => x.Id == id); //Search if the user id exists
			if (removeUtilizador != null) //if exists remove, return 1 as successfull
			{
				u.Remove(removeUtilizador);
				return 1;
			}
			else return 0;
		}

		/// <summary>
		/// Removes all users from the list of users.
		/// </summary>
		/// <returns>
		/// Returns 1 to indicate that all users have been successfully removed.
		/// </returns>
		public static int removerTodosUtilizador()
		{
			u.Clear();
			return 1;
		}

		/// <summary>
		/// Loads users from a file and adds them to the list of users.
		/// </summary>
		/// <param name="filePath">The path to the file containing the user data.</param>
		/// <returns>
		/// Returns `true` if users were successfully loaded into the list.
		/// Throws an exception if the file format is invalid.
		/// </returns>
		public static bool CarregaUtilizadoresParaLista(string filePath)
		{
			// Reads all lines of the file
			string[] linhas = File.ReadAllLines(filePath);

			// Foreach line in the file, processes the content
			foreach (string linha in linhas)
			{
				// Divide the lines in parts
				string[] partes = linha.Split(';');

				// Verify if exists exactly 7 parts
				if (partes.Length == 7)
				{
					string nome = partes[0];
					string cc = partes[1];
					string nif = partes[2];
					string email = partes[3];
					string telemovel = partes[4];
					int tipo = int.Parse(partes[5]);
					string password = partes[6];

					// Create an user object and add it to the users list
					Utilizador utilizador = new Utilizador(nome, cc, nif, email, telemovel, tipo, password);
					u.Add(utilizador);
				}
				else
				{
					throw new Exception("Formato da linha inválido.");
				}
			}
			return true;
		}

		/// <summary>
		/// Saves all users from the list to a file.
		/// </summary>
		/// <param name="filePath">The path to the file where the user data will be saved.</param>
		/// <returns>
		/// Returns `true` if the users were successfully saved to the file.
		/// </returns>
		public static bool GuardaUtilizadoresParaFicheiro(string filePath)
		{
			using (StreamWriter writer = new StreamWriter(filePath)) //Open the file to write
			{
				foreach (Utilizador utilizador in u)
				{
					writer.WriteLine($"{utilizador.Nome};{utilizador.CC};{utilizador.Nif};{utilizador.Email};{utilizador.Telemovel};{utilizador.Tipo};{utilizador.Password}");
				}
			}
			return true; 
		}
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}