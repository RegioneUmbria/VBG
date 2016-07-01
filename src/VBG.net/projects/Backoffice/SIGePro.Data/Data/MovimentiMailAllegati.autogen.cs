﻿
using System;
using System.Data;
using System.Reflection;
using System.Text;
using Init.SIGePro.Attributes;
using Init.SIGePro.Collection;
using PersonalLib2.Sql.Attributes;
using PersonalLib2.Sql;

namespace Init.SIGePro.Data
{
	///
	/// File generato automaticamente dalla tabella MOVIMENTIMAILALLEGATI il 06/07/2010 10.56.52
	///
	///												ATTENZIONE!!!
	///	- Specificare manualmente in quali colonne vanno applicate eventuali sequenze		
	/// - Verificare l'applicazione di eventuali attributi di tipo "[isRequired]". In caso contrario applicarli manualmente
	///	- Verificare che il tipo di dati assegnato alle proprietà sia corretto
	///
	///						ELENCARE DI SEGUITO EVENTUALI MODIFICHE APPORTATE MANUALMENTE ALLA CLASSE
	///				(per tenere traccia dei cambiamenti nel caso in cui la classe debba essere generata di nuovo)
	/// -
	/// -
	/// -
	/// - 
	///
	///	Prima di effettuare modifiche al template di MyGeneration in caso di dubbi contattare Nicola Gargagli ;)
	///
	[DataTable("MOVIMENTIMAILALLEGATI")]
	[Serializable]
	public partial class MovimentiMailAllegati : BaseDataClass
	{
		#region Membri privati

		private string m_idcomune = null;

		private int? m_id = null;

		private int? m_fk_movimentimail = null;

		private string m_documento = null;

		private int? m_codiceoggetto = null;

		#endregion

		#region properties

		#region Key Fields


		[KeyField("IDCOMUNE", Type = DbType.String, Size = 6)]
		public string Idcomune
		{
			get { return m_idcomune; }
			set { m_idcomune = value; }
		}

		[KeyField("ID", Type = DbType.Decimal)]
		[useSequence]
		public int? Id
		{
			get { return m_id; }
			set { m_id = value; }
		}


		#endregion

		#region Data fields

		[DataField("FK_MOVIMENTIMAIL", Type = DbType.Decimal)]
		public int? FkMovimentimail
		{
			get { return m_fk_movimentimail; }
			set { m_fk_movimentimail = value; }
		}

		[DataField("DOCUMENTO", Type = DbType.String, CaseSensitive = false, Size = 4000)]
		public string Documento
		{
			get { return m_documento; }
			set { m_documento = value; }
		}

		[DataField("CODICEOGGETTO", Type = DbType.Decimal)]
		public int? Codiceoggetto
		{
			get { return m_codiceoggetto; }
			set { m_codiceoggetto = value; }
		}

		#endregion

		#endregion
	}
}
