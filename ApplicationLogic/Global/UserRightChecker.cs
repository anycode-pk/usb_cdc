using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Enums;
using CommonModel;
using CommonModel.Entities;

namespace ApplicationLogic.Global
{
    /// <summary>
    /// Klasa statyczna, zawiera funkcje odpowiedzialne za sprawdzenie uprawnień użytkowników.
    /// </summary>
    public static class UserRightChecker
    {
        /// <summary>
        /// Sprawdza czy aktualny użytkownik posiada wybrane uprawnienie.
        /// </summary>
        /// <param name="right">Uprawnieniem enum pokrywający się z ID w tabeli Right.</param>
        /// <returns>Prawda jeśli posiada uprawnienie.</returns>
        public static bool CheckRightCurrenUser(RightsMapper right)
        {
            return !((CommonContext.Instance.CurrentUser.UserRight.Where(p=> p.RightId == (int) right).FirstOrDefault()) == null);
        }

        /// <summary>
        /// Sprawdza czy wybrany użytkownik posiada wybrane uprawnienie.
        /// </summary>
        /// <param name="right">Uprawnieniem enum pokrywający się z ID w tabeli Right.</param>
        /// <param name="usr">Obiekt użytkownika z modelu danych.</param>
        /// <returns>Prawda jeśli posiada uprawnienie.</returns>
        public static bool CheckRightUser(RightsMapper right, User usr)
        {
            return !((usr.UserRight.Where(p => p.RightId == (int)right).FirstOrDefault()) == null);
        }

        /// <summary>
        /// Z użytkowników przesłanych w parametrze zwraca tylko tych co mają wybrane uprawnienie.
        /// </summary>
        /// <param name="right">Uprawnieniem enum pokrywający się z ID w tabeli Right.</param>
        /// <param name="users">Lista użytkowników z modelu danych.</param>
        /// <returns>Lista użytkowników posiadających wybrane uprawnienie.</returns>
        public static IList<User> GetUserWithRight(RightsMapper right, IList<User> users)
        {
            IList<User> result = new List<User>();
            foreach (User usr in users)
            {
                if (CheckRightUser(right, usr))
                    result.Add(usr);
            }
            return result;
        }

        /// <summary>
        /// Pobiera wszystkie uprawnienia aktualnego użytkownika.
        /// </summary>
        /// <returns>Lista uprawnien użytkownika (zmapowany enum).</returns>
        public static IList<RightsMapper> GetAllRightsCurrentUser()
        {
            IList<RightsMapper> allRights = HelpersRight.GetAllTypes();
            IList<RightsMapper> curRights = new List<RightsMapper>();
            foreach (RightsMapper r in allRights)
            {
                if (CheckRightCurrenUser(r) == true)
                {
                    curRights.Add(r);
                }
            }
            return curRights;
        }
    }
}
