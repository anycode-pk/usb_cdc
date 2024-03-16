using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonModel.Enums
{
    /// <summary>
    /// Określa typ cyklu pomiarowego.
    /// </summary>
    public enum CycleType
    {
        /// <summary>
        /// Cykliczny pomiar, tj. wykonywane są wszystkie listy rozkazów.
        /// </summary>
        CycleMeasurement = 0,
        /// <summary>
        /// Pojedynczy pomiary, wymuszony. Wykonywana jest jedna lista rozkazów.
        /// </summary>
        SingleMeasurement,
        /// <summary>
        /// Tryb bezczynności.
        /// </summary>
        None
    }
}
