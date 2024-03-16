using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.Base;
using CommonModel.Entities;

namespace ApplicationLogic.Interfaces.Dictionaries
{
    public interface IStationListView : IBaseView
    {
        IList<MeasureStation> Stations { set; }
        MeasureStation CurrentStation { get; }
    }
}
