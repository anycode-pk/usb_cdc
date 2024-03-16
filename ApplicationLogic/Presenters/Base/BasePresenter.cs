using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.Base;

namespace ApplicationLogic.Presenters.Base
{
    /// <summary>
    /// Bazowa klasa prezentera, typowana na odpowiadający jej widok.
    /// </summary>
    /// <typeparam name="TView"></typeparam>
    public abstract class BasePresenter<TView> : IPresenter
        where TView : IBaseView
    {

        private TView view;

        public TView View
        {
            get { return view; }
            private set { view = value; }
        }


        public BasePresenter(TView view)
        {
            if (view == null)
                throw new ArgumentNullException("view");

            this.view = view;
        }

        public virtual void Initialize()
        {
        }


        public virtual void Dispose()
        {
        }
    }
}
