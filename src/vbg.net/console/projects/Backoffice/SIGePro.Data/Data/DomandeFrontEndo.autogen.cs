
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
						/// File generato automaticamente dalla tabella DOMANDEFRONT_ENDO il 09/01/2009 16.48.53
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
						[DataTable("DOMANDEFRONT_ENDO")]
						[Serializable]
						public partial class DomandeFrontEndo : BaseDataClass
						{
							#region Membri privati
							
							private string m_idcomune = null;

                            private int? m_codicedomanda = null;

                            private int? m_codiceinventario = null;
			
							#endregion
							
							#region properties
							
							#region Key Fields
							
							
							[KeyField("IDCOMUNE" , Type=DbType.String, Size=6)]
							public string Idcomune
							{
								get{ return m_idcomune; }
								set{ m_idcomune = value; }
							}
							
							[KeyField("CODICEDOMANDA" , Type=DbType.Decimal)]
							public int? Codicedomanda
							{
								get{ return m_codicedomanda; }
								set{ m_codicedomanda = value; }
							}
							
							[KeyField("CODICEINVENTARIO" , Type=DbType.Decimal)]
							public int? Codiceinventario
							{
								get{ return m_codiceinventario; }
								set{ m_codiceinventario = value; }
							}
							
							
							#endregion
							
							#region Data fields
							
							#endregion

							#endregion
						}
					}
				