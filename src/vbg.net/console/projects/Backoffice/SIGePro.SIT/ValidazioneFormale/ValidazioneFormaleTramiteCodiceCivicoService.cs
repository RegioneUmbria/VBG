﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Init.SIGePro.Sit.ValidazioneFormale
{
	internal class ValidazioneFormaleTramiteCodiceCivicoService: IValidazioneFormaleService
	{
		#region IValidazioneFormaleService Members

		public bool Valida(Init.SIGePro.Sit.Data.Sit sit)
		{
			return !String.IsNullOrEmpty(sit.CodCivico);
		}

		#endregion
	}
}
