using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonModel.ModelChandegEvents
{
    public class CmdsListChangedEventArgs : EventArgs
    {
        public CommonModel.Entities.CmdList CommandList { get; set; }
        public CmdsListChangedEventArgs(CommonModel.Entities.CmdList commandList)
        {
            CommandList = commandList;
        }
    }
}
