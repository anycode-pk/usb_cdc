using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.Dictionaries;
using CommonModel.Entities;
using DataManager.Repositories;
using ApplicationLogic.Helpers;

namespace ApplicationLogic.Presenters.Dictionaries
{
    public class UserEditPresenter : ApplicationLogic.Presenters.Base.BasePresenter<IUserEditView>
    {
        private UserRepository userRepo = new UserRepository();
        public UserEditPresenter(IUserEditView view)
            : base(view)
        {
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public void Save()
        {
            if (this.View.CurrentUser.Id == 0)
            {
                this.View.CurrentUser.CreateDate = DateTime.Now;
            }

            User alreadyUser = userRepo.Get(this.View.CurrentUser.Login);
            if (alreadyUser != null)
            {
                if (alreadyUser.Id != this.View.CurrentUser.Id)
                {
                    this.View.ShowError(TextContentRepository.UserAlready, TextContentRepository.Attention);
                    return;
                }
            }            

            this.PrepareRights();

            userRepo.InsertOrUpdate(this.View.CurrentUser);
            this.View.CloseView();
        }

        [Obsolete("Metoda poprawna, jednak należy ją ponownie zaimplementować przy refaktoringu dostępu do danych, np. przy implementacji wzorca Unit of Work.")]
        private void PrepareRights()
        {
            IList<UserRight> toRemove = new List<UserRight>(); // kolekcja uprawnień, które mają zostać usunięte
            IList<UserRight> dontAdd = new List<UserRight>();  // kolekcja uprawnień, które już są i nie należy ich ponownie dodawać

            foreach (UserRight ur in this.View.CurrentUser.UserRight) // Porównanie kolekcji utworzonej w oknie do kolekcji posiadanej przez użytkownika.
            {
                if (this.View.CurrentRight.Where(p => p.Id == ur.RightId).Any()) //czy wśród uprawnień w kolekcji utworzonej w oknie występuje aktualnie iterowane uprawnienie
                {
                    dontAdd.Add(ur);    // jeśli tak, to należy je oznaczyć, że aby go ponownie nie dodało
                }
                else
                {
                    toRemove.Add(ur); // jeśli nie, to oznacza, że uprawnienie zostało skasowane
                }
            }
            foreach (UserRight ur in toRemove) // usunięcie tych, które należy usunąć
            {
                this.View.CurrentUser.UserRight.Remove(ur);
                new UserRightRepository().Remove(ur);
            }

            foreach (Right r in this.View.CurrentRight) // dodanie nowych
            {
                if (dontAdd.Where(p => p.RightId == r.Id).Any() == false)
                    this.View.CurrentUser.UserRight.Add(new UserRight() { RightId = r.Id, UserId = this.View.CurrentUser.Id });
            }
        }

        public void ShowRights(IRightsView view)
        {
            view.OtherRights = new DataManager.Repositories.RightRepository().GetOther(this.View.CurrentRight);
            view.ShowView();
            if (view.WindowResult == Global.WindowResult.SelectedResult)
            {
                IList<Right> tmpRight = this.View.CurrentRight;
                foreach (Right r in view.SelectedRights) // dodanie nowo zaznaczonych uprawnień do tymczasowej listy
                {
                    tmpRight.Add(r);
                }
                this.View.CurrentRight = tmpRight; // odświeżenie danych
                this.Initialize();
            }
        }

        public void RemoveRights()
        {
            foreach (Right r in this.View.SelectedRights)
            {
                this.View.CurrentRight.Remove(r);
            }
            this.View.CurrentRight = this.View.CurrentRight; // stuczne odświeżenie listy
        }

        public void Cancel()
        {
            userRepo.RejectChanges(this.View.CurrentUser);
            this.View.CloseView();
        }
    }
}
