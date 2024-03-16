using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationLogic.Interfaces.Dictionaries;
using CommonModel.Entities;
using DataManager.Repositories;
using ApplicationLogic.Helpers;
using ApplicationLogic.Global;
using CommonModel.Enums;

namespace ApplicationLogic.Presenters.Dictionaries
{
    public class UserListPresenter : ApplicationLogic.Presenters.Base.BasePresenter<IUserListView>
    {
        private UserRepository userRepo = new UserRepository();
        public UserListPresenter(IUserListView view)
            : base(view)
        {
        }

        public override void Initialize()
        {
            this.View.Users = userRepo.GetAll();
        }

        public void ShowEditor(IUserEditView view, User user)
        {
            view.CurrentUser = user;
            view.CurrentRight = user.UserRight.Select(p=> p.Right).ToList();
            view.ShowView();
        }

        public void DeleteUser()
        {
            if (IsDelitingLastAdmin() == true)
                return;

            if (this.View.ShowQuestion(TextContentRepository.UserDeleteQuestion, TextContentRepository.Attention) == true)
            {
                if (userRepo.Remove(this.View.CurrentUser) == false)
                {
                    this.View.ShowError(TextContentRepository.UserDeleteError, TextContentRepository.Attention);
                }
            }  
        }

        private bool IsDelitingLastAdmin()
        {
            bool isLastAdmin = false;

            if (UserRightChecker.CheckRightUser(RightsMapper.AllowLogOnAdministrative, this.View.CurrentUser) ||
                UserRightChecker.CheckRightUser(RightsMapper.AllowDefineUsers, this.View.CurrentUser))
            {
                if (
                   (UserRightChecker.GetUserWithRight(RightsMapper.AllowLogOnAdministrative, this.View.Users).Count <= 1) &&
                   (UserRightChecker.GetUserWithRight(RightsMapper.AllowDefineUsers, this.View.Users).Count <= 1)
                   )
                        {
                            this.View.ShowWarning(TextContentRepository.DeleteLAstUser, TextContentRepository.Attention);
                            isLastAdmin = true;
                        }
            }

            return isLastAdmin;
        }

    }
}
