using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;

namespace CommonModel.Enums
{
    /// <summary>
    /// Określa uprawnienia.
    /// </summary>
    public enum RightsMapper
    {
        /// <summary>
        /// Możliwe definiowanie stacji pomiarowych.
        /// </summary>
        AllowDefineStations = 1,
        /// <summary>
        /// Możeliwe logowanie z każdej stacji.
        /// </summary>
        LogFromAnyStation = 2,
        /// <summary>
        /// Możliwe logowanie do trybu administracyjnego.
        /// </summary>
        AllowLogOnAdministrative = 3,
        /// <summary>
        /// Możeliwe definiowanie urządzeń.
        /// </summary>
        AllowDefineDevices = 4,
        /// <summary>
        /// Możliwe definiowanie jednostek.
        /// </summary>
        AllowDefineUnits = 5,
        /// <summary>
        /// Możliwe definiowanie użytkowników.
        /// </summary>
        AllowDefineUsers = 6,
        /// <summary>
        /// Możliwe definiowanie pierwowzorów rozkazów.
        /// </summary>
        AllowDefineCmdArchetype = 7,
        /// <summary>
        /// Możliwe definiowanie list rozkazów.
        /// </summary>
        AllowDefineCmdList = 8,
        /// <summary>
        /// Możliwe definiowanie rozkazów.
        /// </summary>
        AllowDefineCommands = 9,
        /// <summary>
        /// Możliwe definiowanie konfiguracji urządzeń.
        /// </summary>
        AllowDefineConfigurations = 10,
        /// <summary>
        /// Możliwy podgląd ostatnich wyników pomiaru.
        /// </summary>
        AlowViewLastMeasure = 11,
        /// <summary>
        /// Możliwy dostęp do pozostałych stacji.
        /// </summary>
        AllowAccessToOtherStation = 12
    }

    public static class HelpersRight
    {
        public static IList<RightsMapper> GetAllTypes()
        {
            Array arr = Enum.GetValues(typeof(RightsMapper));
            List<RightsMapper> statuses = new List<RightsMapper>(arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                statuses.Add((RightsMapper)arr.GetValue(i));
            }
            return statuses;
        }
    }
}
