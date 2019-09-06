
			
using System;
using System.Collections.Generic;
using System.Text;
using Init.SIGePro.Manager;
using PersonalLib2.Data;
using Init.SIGePro.Data;
using Init.SIGePro.Validator;
using PersonalLib2.Sql;

namespace Init.SIGePro.Manager
{

	///
	/// File generato automaticamente dalla tabella TIPIUNITAMISURA per la classe TipiUnitaMisura il 15/10/2008 15.50.10
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
	public partial class TipiUnitaMisuraMgr : BaseManager
	{
		public TipiUnitaMisuraMgr(DataBase dataBase) : base(dataBase) { }

		public TipiUnitaMisura GetById(int um_id, string idcomune)
		{
			TipiUnitaMisura c = new TipiUnitaMisura();
			
			
			c.UmId = um_id;
			c.Idcomune = idcomune;
			
			return (TipiUnitaMisura)db.GetClass(c);
		}

		public List<TipiUnitaMisura> GetList(TipiUnitaMisura filtro)
		{
			return db.GetClassList( filtro ).ToList< TipiUnitaMisura>();
		}

		public TipiUnitaMisura Insert(TipiUnitaMisura cls)
		{
			cls = DataIntegrations(cls);

			Validate(cls, AmbitoValidazione.Insert);
		
			db.Insert(cls);
			
			cls = (TipiUnitaMisura)ChildDataIntegrations(cls);

			ChildInsert(cls);

			return cls;
		}
		
		public override DataClass ChildDataIntegrations(DataClass cls)
		{
			return cls;
		}

		private TipiUnitaMisura ChildInsert(TipiUnitaMisura cls)
		{
			return cls;
		}

		private TipiUnitaMisura DataIntegrations(TipiUnitaMisura cls)
		{
			return cls;
		}
		

		public TipiUnitaMisura Update(TipiUnitaMisura cls)
		{
			Validate( cls , AmbitoValidazione.Update );
		
			db.Update(cls);

			return cls;
		}

		public void Delete(TipiUnitaMisura cls)
		{
			VerificaRecordCollegati( cls );
			
			EffettuaCancellazioneACascata( cls );
		
			db.Delete(cls);
		}
			
		private void EffettuaCancellazioneACascata(TipiUnitaMisura cls )
		{
			// Inserire la logica di cancellazione a cascata di dati collegati
		}
		
		
		private void Validate(TipiUnitaMisura cls, AmbitoValidazione ambitoValidazione)
		{
			RequiredFieldValidate( cls , ambitoValidazione );
		}	
	}
}
			
			
			