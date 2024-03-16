using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationLogic.Global
{
    /// <summary>
    /// Reprezentuje typ widoku.
    /// </summary>
    public enum ViewFunctionTypes
    {
        /// <summary>
        /// Umożliwia jedynie zarządzanie.
        /// </summary>
        OnlyList = 1,
        /// <summary>
        /// Umożliwia jedynie wybieranie z elementów z listy.
        /// </summary>
        OnlySelect,
        /// <summary>
        /// Umożliwia zarządzanie oraz wybieranie elementów z listy.
        /// </summary>
        SelectAndList
    }
}
