﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Init.Sigepro.FrontEnd.AppLogic.Configurazione.V2
{
	public interface IConfigurazione<T> where T:IParametriConfigurazione
	{
		T Parametri { get; }
	}
}
