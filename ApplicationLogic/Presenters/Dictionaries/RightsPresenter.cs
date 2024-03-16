using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.Dictionaries;

namespace ApplicationLogic.Presenters.Dictionaries
{
    public class RightsPresenter : ApplicationLogic.Presenters.Base.BasePresenter<IRightsView>
    {
        public RightsPresenter(IRightsView view)
            : base(view)
        {

        }

        public override void Initialize()
        {
        }
    }
}
