﻿// -----------------------------------------------------------------------
// <copyright file="IDatiExtraReadInterface.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Init.Sigepro.FrontEnd.AppLogic.GestionePresentazioneDomanda.GestioneDatiExtra
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	/// <summary>
	/// TODO: Update summary.
	/// </summary>
	public interface IDatiExtraReadInterface
	{
		string GetValoreDato(string chiave);
		IEnumerable<string> Keys { get; }
	}
}
