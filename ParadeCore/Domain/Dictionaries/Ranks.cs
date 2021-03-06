﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParadeCore.Domain.Dictionaries
{
    public class RankDictionary
    {
        public static (string name, string abbreviation) Lookup(RankEquivalence rank, RankModifier modifier = RankModifier.Standard)
        {
            switch (rank)
            {
                case RankEquivalence.PrivateRecruit:
                    switch (modifier)
                    {
                        case RankModifier.Navy:
                            return ("Ordinary Seaman (Recruit)", "OS(R)");
                        case RankModifier.AirForce:
                            return ("Aviator (Recruit)", "Avr(R)");
                        default:
                            return ("Private (Recruit)", "Pte(R)");
                    }
                case RankEquivalence.PrivateBasic:
                    switch (modifier)
                    {
                        case RankModifier.Navy:
                            return ("Ordinary Seaman (Basic)", "OS(B)");
                        case RankModifier.AirForce:
                            return ("Aviator (Basic)", "Avr(B)");
                        default:
                            return ("Private (Basic)", "Pte(B)");
                    }
                case RankEquivalence.Private:
                    switch (modifier)
                    {
                        case RankModifier.Navy:
                            return ("Ordinary Seaman", "OS");
                        case RankModifier.AirForce:
                            return ("Aviator", "Avr");
                        case RankModifier.Artillery:
                            return ("Gunner", "Gnr");
                        case RankModifier.Rifles:
                            return ("Rifleman", "Rfmn");
                        default:
                            return ("Private", "Pte");
                    }
                case RankEquivalence.Corporal:
                    switch (modifier)
                    {
                        case RankModifier.Navy:
                            return ("Able Seaman", "AS");
                        case RankModifier.Artillery:
                            return ("Bombardier", "Bdr");
                        default:
                            return ("Corporal", "Cpl");
                    }
                case RankEquivalence.MasterCorporal:
                    switch (modifier)
                    {
                        case RankModifier.Navy:
                            return ("Master Seaman", "MS");
                        case RankModifier.Artillery:
                            return ("Master Bombardier", "MBdr");
                        default:
                            return ("Master Corporal", "MCpl");
                    }
                case RankEquivalence.Sergeant:
                    return (modifier == RankModifier.Navy) ? ("Petty Officer 2nd Class", "PO2") : ("Sergeant", "Sgt");
                case RankEquivalence.WarrantOfficer:
                    return (modifier == RankModifier.Navy) ? ("Petty Officer 1st Class", "PO1") : ("Warrant Officer", "WO");
                case RankEquivalence.MasterWarrantOfficer:
                    return (modifier == RankModifier.Navy) ? ("Chief Petty Officer 2nd Class", "CPO2") : ("Master Warrant Officer", "MWO");
                case RankEquivalence.ChiefWarrantOfficer:
                    return (modifier == RankModifier.Navy) ? ("Chief Petty Officer 1st Class", "CPO1") : ("Chief Warrant Officer", "CWO");
                default:
                    return ("", "");
            }
            // return (modifier == RankModifier.Navy) ? ("", "") : ("", "");
        }

    }
}