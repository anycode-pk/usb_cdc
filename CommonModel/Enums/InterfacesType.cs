using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonModel.Enums
{
    /// <summary>
    /// Określa typ interfejsów.
    /// </summary>
    public enum InterfacesType
    {
        USB = 0,
        RS232 = 1
    }

    public static class HelpersInterface
    {
        public static IList<InterfacesType> GetAllTypes()
        {
            Array arr = Enum.GetValues(typeof(InterfacesType));
            List<InterfacesType> statuses = new List<InterfacesType>(arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                statuses.Add((InterfacesType)arr.GetValue(i));
            }

            return statuses;
        }
    }
}
