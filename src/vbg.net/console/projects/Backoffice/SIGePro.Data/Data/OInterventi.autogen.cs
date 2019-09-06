
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
    /// File generato automaticamente dalla tabella O_INTERVENTI il 27/06/2008 13.01.36
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
    [DataTable("O_INTERVENTI")]
    [Serializable]
    public partial class OInterventi : BaseDataClass
    {
        #region Membri privati


        private string m_idcomune = null;

        private int? m_id = null;

        private string m_fk_occbti_id = null;

        private string m_intervento = null;

        private string m_software = null;

        private int? m_ordinamento = null;

        #endregion

        #region properties

        #region Key Fields


        [KeyField("IDCOMUNE", Type = DbType.String,  Size = 6)]
        public string Idcomune
        {
            get { return m_idcomune; }
            set { m_idcomune = value; }
        }



        #endregion

        #region Data fields

        [isRequired]
        [DataField("FK_OCCBTI_ID", Type = DbType.String, CaseSensitive = false, Size = 1)]
        public string FkOccbtiId
        {
            get { return m_fk_occbti_id; }
            set { m_fk_occbti_id = value; }
        }

        [isRequired]
        [DataField("INTERVENTO", Type = DbType.String, CaseSensitive = false, Size = 200)]
        public string Intervento
        {
            get { return m_intervento; }
            set { m_intervento = value; }
        }

        [isRequired]
        [DataField("SOFTWARE", Type = DbType.String, Size = 2)]
        public string Software
        {
            get { return m_software; }
            set { m_software = value; }
        }

        [isRequired]
        [DataField("ORDINAMENTO", Type = DbType.Decimal)]
        public int? Ordinamento
        {
            get { return m_ordinamento; }
            set { m_ordinamento = value; }
        }

        #endregion

        #endregion
    }
}
