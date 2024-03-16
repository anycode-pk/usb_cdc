using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Reflection;

namespace CommonModel.Enums
{
    public enum SessionType
    {
        [Description("Stacja pomiarowa")]
        Measure = 0,
        [Description("Administracyjny")]
        Administrative = 1,
        [Description("Konfiguracja SQL")]
        SQLConfig = 2,
        [Description("Test urządzenia")]
        TestDevice = 3
    }


    public static class HelpersSession
    {
        public static IList<SessionType> GetAllTypes()
        {
            return Enum.GetValues(typeof(SessionType)).Cast<SessionType>().ToList();
        }
    }
}
