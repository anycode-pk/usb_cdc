using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonModel.Entities;
using CommonModel.ModelChandegEvents;


namespace CommonModel
{
    /// <summary>
    /// Wspólny kontekst.
    /// </summary>
    public class CommonContext
    {
        private static CommonContext instance;
        private LogWriter logger;

        public static CommonContext Instance
        {
            get
            {
                if (instance == null)
                {
                 instance = new CommonContext();
                }

                return instance;
            }
        }

        private CommonContext()
        {
            logger = new LogWriter();
        }

        private User currentUser;
        /// <summary>
        /// Aktualny użytkownik, o ile logowanie przebiegło pomyślnie.
        /// </summary>
        public User CurrentUser
        {
            get { return currentUser; }
            set 
            { 

                currentUser = value; 
            }
        }
        private MeasureSession currentSession;
        /// <summary>
        /// Aktualna sesja, po zalogowaniu.
        /// </summary>
        public MeasureSession CurrentSession
        {
            get { return currentSession; }
            set 
            { 
                currentSession = value;
                OnCurrentSessionChanged(new SessionChangedEventArgs(currentSession));
            }
        }
        private MeasureStation currentStation;
        /// <summary>
        /// Aktualna stacja.
        /// </summary>
        public MeasureStation CurrentStation
        {
            get { return currentStation; }
            set { currentStation = value; }
        }

        public string ThisStationName;
        public string ConnectionString;
        public bool ConnectedDB;

        public delegate void CurrentSessionChangedEventHandler(SessionChangedEventArgs eventArgs);
        public event CurrentSessionChangedEventHandler OnCurrentSessionChanged;

        public void LogException(Exception ex)
        {
            logger.LogException(ex);
        }

    }
}
