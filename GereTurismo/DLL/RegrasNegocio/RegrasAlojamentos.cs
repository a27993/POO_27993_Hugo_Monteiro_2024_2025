﻿/*
*	<copyright file="RegrasNegocio" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>Hugo</author>
*   <date>12/8/2024 11:38:18 PM</date>
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
	/// Created on: 12/8/2024 11:38:18 PM
	/// </summary>
	/// <remarks></remarks>
	/// <example></example>
	public class RegrasAlojamentos
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
		public static int criarAlojamento(string localizacao, double precoPorNoite, int capacidade)
		{
			if (string.IsNullOrEmpty(localizacao) || precoPorNoite <= 0 || capacidade <= 0)
			{
				return -1;
			}
			return Alojamentos.criarAlojamento(localizacao, precoPorNoite, capacidade);
		}

		public static int removerAlojamento(int id)
		{
			if (id <= 0)
			{
				return -1;
			}
			return Alojamentos.removerAlojamento(id);
		}

		public static int alterarAlojamento(double novoPrecoPorNoite, int id)
		{
			if (id <= 0)
			{
				return -1;
			}
			return Alojamentos.alterarAlojamento(novoPrecoPorNoite, id);
		}

		public static List<Alojamento> mostraTodosAlojamento()
		{
			return Alojamentos.A;
		}

		public static bool CarregaAlojamentosParaLista(string filePath)
		{
			if (!File.Exists(filePath))
			{
				return false;
			}
			return Alojamentos.CarregaAlojamentosParaLista(filePath);
		}

		public static bool GuardaAlojamentosParaFicheiro(string filePath)
		{
			if (!File.Exists(filePath))
			{
				return false;
			}
			return Alojamentos.GuardaAlojamentosParaFicheiro(filePath);
		}
		#endregion

		#region Destructor
		#endregion

		#endregion
	}
}