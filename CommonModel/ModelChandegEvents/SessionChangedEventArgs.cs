using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonModel.ModelChandegEvents
{
    public class SessionChangedEventArgs : EventArgs
    {
        public CommonModel.Entities.MeasureSession Session
        { get; set; }
        public SessionChangedEventArgs(CommonModel.Entities.MeasureSession session)
        {
            Session = session;
        }
    }
}
