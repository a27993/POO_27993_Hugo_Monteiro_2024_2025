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
		private static int? idLogado; //ou e int ou null
		private static int? tipoLogado;
		#endregion

		#region Methods

		#region Constructors
		static Utilizadores()
		{
			u = new List<Utilizador>();
		}
		#endregion

		#region Properties
		public static int? TipoLogado
		{
			get { return tipoLogado; }
		}
		public static int? IdLogado
		{
			get { return idLogado; }
		}
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
		public static int removerTodosUtilizador()
		{
			u.Clear();
			return 1;
		}

		public static bool CarregaUtilizadoresParaLista(string filePath)
		{
			// Lê todas as linhas do ficheiro
			string[] linhas = File.ReadAllLines(filePath);

			// Para cada linha no ficheiro, processa o conteúdo
			foreach (string linha in linhas)
			{
				// Divide a linha em partes
				string[] partes = linha.Split(';');

				// Verifica se há exatamente 7 partes
				if (partes.Length == 7)
				{
					string nome = partes[0];
					string cc = partes[1];
					string nif = partes[2];
					string email = partes[3];
					string telemovel = partes[4];
					int tipo = int.Parse(partes[5]);
					string password = partes[6];

					// Cria o objeto utilizador e adiciona-o à lista de utilizadores
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