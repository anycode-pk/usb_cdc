using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonModel.ModelChandegEvents
{
    public class MeasureValuesCahngedEventArgs : EventArgs
    {
        public CommonModel.Entities.MeasureValue Values { get; set; }
        public MeasureValuesCahngedEventArgs(CommonModel.Entities.MeasureValue values)
        {
            Values = values;
        }

    }
}
