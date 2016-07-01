using System;
using System.Data;
using PersonalLib2.Sql.Attributes;

namespace Init.SIGePro.Data
{
	[DataTable("VERTICALIZZAZIONIBASE")]
	public class VerticalizzazioniBase : BaseDataClass
	{
		string modulo=null;
		[KeyField("MODULO",Size=30, Type=DbType.String, Compare="like", CaseSensitive=false)]
		public string MODULO
		{
			get { return modulo; }
			set { modulo = value; }
		}

		string descrizione=null;
		[DataField("DESCRIZIONE",Size=2000, Type=DbType.String, Compare="like", CaseSensitive=false)]
		public string DESCRIZIONE
		{
			get { return descrizione; }
			set { descrizione = value; }
		}

	}
}