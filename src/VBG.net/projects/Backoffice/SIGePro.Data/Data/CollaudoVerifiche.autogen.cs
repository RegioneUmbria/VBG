
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
						/// File generato automaticamente dalla tabella COLLAUDOVERIFICHE il 30/07/2008 16.38.09
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
						[DataTable("COLLAUDOVERIFICHE")]
						[Serializable]
						public partial class CollaudoVerifiche : BaseDataClass
						{
							#region Membri privati


                            private int? m_codiceistanza = null;

                            private int? m_codiceamministrazione = null;

                            private DateTime? m_data = null;

							private string m_parere = null;

                            private int? m_esito = null;

							private string m_note = null;

                            private int? m_proprio = null;

							private string m_fileverbale = null;

                            private int? m_codiceoggetto = null;

							private string m_idcomune = null;
			
							#endregion
							
							#region properties
							
							#region Key Fields
							
							
							[KeyField("CODICEISTANZA" , Type=DbType.Decimal)]
							public int? Codiceistanza
							{
								get{ return m_codiceistanza; }
								set{ m_codiceistanza = value; }
							}
							
							[KeyField("CODICEAMMINISTRAZIONE" , Type=DbType.Decimal)]
							public int? Codiceamministrazione
							{
								get{ return m_codiceamministrazione; }
								set{ m_codiceamministrazione = value; }
							}
							
							[KeyField("IDCOMUNE" , Type=DbType.String, Size=6)]
							public string Idcomune
							{
								get{ return m_idcomune; }
								set{ m_idcomune = value; }
							}
							
							
							#endregion
							
							#region Data fields
							
							[DataField("DATA" , Type=DbType.DateTime)]
							public DateTime? Data
							{
								get{ return m_data; }
                                set { m_data = VerificaDataLocale(value); }
							}
							
							[DataField("PARERE" , Type=DbType.String, CaseSensitive=false, Size=4000)]
							public string Parere
							{
								get{ return m_parere; }
								set{ m_parere = value; }
							}
							
							[DataField("ESITO" , Type=DbType.Decimal)]
							public int? Esito
							{
								get{ return m_esito; }
								set{ m_esito = value; }
							}
							
							[DataField("NOTE" , Type=DbType.String, CaseSensitive=false, Size=4000)]
							public string Note
							{
								get{ return m_note; }
								set{ m_note = value; }
							}
							
							[DataField("PROPRIO" , Type=DbType.Decimal)]
							public int? Proprio
							{
								get{ return m_proprio; }
								set{ m_proprio = value; }
							}
							
							[DataField("FILEVERBALE" , Type=DbType.String, CaseSensitive=false, Size=70)]
							public string Fileverbale
							{
								get{ return m_fileverbale; }
								set{ m_fileverbale = value; }
							}
							
							[DataField("CODICEOGGETTO" , Type=DbType.Decimal)]
							public int? Codiceoggetto
							{
								get{ return m_codiceoggetto; }
								set{ m_codiceoggetto = value; }
							}
							
							#endregion

							#endregion
						}
					}
				