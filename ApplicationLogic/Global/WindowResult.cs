using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationLogic.Global
{
    /// <summary>
    /// Reprezentuje zwracany rezultat z okna dialogowego.
    /// </summary>
    public enum WindowResult
    {
        /// <summary>
        /// Zostało coś zaznaczone.
        /// </summary>
        SelectedResult,
        /// <summary>
        /// Nie ma nic do zwrócenia.
        /// </summary>
        NoResult,
        /// <summary>
        /// Wykonano zapis.
        /// </summary>
        Save,
        /// <summary>
        /// Anulowano dodanie/edycję.
        /// </summary>
        Cancel
    }
}
