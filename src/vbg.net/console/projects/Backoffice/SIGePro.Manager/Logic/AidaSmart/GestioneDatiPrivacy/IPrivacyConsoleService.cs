﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Init.SIGePro.Manager.Logic.AidaSmart.GestioneDatiPrivacy
{
    public interface IPrivacyConsoleService
    {
        //responsabileTrattamento
        //dataProtectionOfficer
        ResponsabiliPrivacyConsoleDto GetDatiPrivacy();

    }
}
