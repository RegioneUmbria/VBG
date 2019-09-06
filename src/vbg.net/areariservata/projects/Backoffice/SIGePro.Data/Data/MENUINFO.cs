using System;
using System.Data;
using PersonalLib2.Sql.Attributes;

namespace Init.SIGePro.Data
{
	[DataTable("MENUINFO")]
	public class MenuInfo : BaseDataClass
	{
		string idcomune=null;
		[KeyField("IDCOMUNE",Size=6, Type=DbType.String )]
		public string IDCOMUNE
		{
			get { return idcomune; }
			set { idcomune = value; }
		}

		string codice=null;
		[KeyField("CODICE", Type=DbType.Decimal)]
		public string CODICE
		{
			get { return codice; }
			set { codice = value; }
		}

		string descrizione=null;
		[DataField("DESCRIZIONE",Size=100, Type=DbType.String, Compare="like", CaseSensitive=false)]
		public string DESCRIZIONE
		{
			get { return descrizione; }
			set { descrizione = value; }
		}

		string imgabil=null;
		[DataField("IMGABIL",Size=70, Type=DbType.String, Compare="like", CaseSensitive=false)]
		public string IMGABIL
		{
			get { return imgabil; }
			set { imgabil = value; }
		}

		string imgdisabil=null;
		[DataField("IMGDISABIL",Size=70, Type=DbType.String, Compare="like", CaseSensitive=false)]
		public string IMGDISABIL
		{
			get { return imgdisabil; }
			set { imgdisabil = value; }
		}

		string attivo=null;
		[DataField("ATTIVO",Size=1, Type=DbType.String, CaseSensitive=false)]
		public string ATTIVO
		{
			get { return attivo; }
			set { attivo = value; }
		}

		string _ref=null;
		[DataField("REF",Size=150, Type=DbType.String, Compare="like", CaseSensitive=false)]
		public string REF
		{
			get { return _ref; }
			set { _ref = value; }
		}

		string ordine=null;
		[DataField("ORDINE", Type=DbType.Decimal)]
		public string ORDINE
		{
			get { return ordine; }
			set { ordine = value; }
		}

		string descrizioneestesa=null;
		[DataField("DESCRIZIONEESTESA",Size=4000, Type=DbType.String, Compare="like", CaseSensitive=false)]
		public string DESCRIZIONEESTESA
		{
			get { return descrizioneestesa; }
			set { descrizioneestesa = value; }
		}

		string codiceoggetto1=null;
		[DataField("CODICEOGGETTO1", Type=DbType.Decimal)]
		public string CODICEOGGETTO1
		{
			get { return codiceoggetto1; }
			set { codiceoggetto1 = value; }
		}

		string codiceoggetto2=null;
		[DataField("CODICEOGGETTO2", Type=DbType.Decimal)]
		public string CODICEOGGETTO2
		{
			get { return codiceoggetto2; }
			set { codiceoggetto2 = value; }
		}
	}
}