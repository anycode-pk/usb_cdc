using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationLogic.Helpers
{
    /// <summary>
    /// Repozytorium tekstów, etykiet, których treść wprowadzana jest w kodzie (nie w designerze).
    /// Przede wszystkim MessageBoxy.
    /// </summary>
    public static class TextContentRepository
    {

        #region general
        public const string Attention = "Uwaga!";
        public const string Info = "Informacja";
        public const string EmtyString = "Nazwa nie może być pusta.";

        #endregion

        #region LoginView
        public const string BadLogin = "Nieprawidłowy login lub hasło.";
        public const string UserLocked = "Użytkownik został zablokowany. Skontaktuj się z Administratorem.";
        public const string ConfigFileNotFound = "Plik konfiguracyjny nie został odnaleziony.";
        public const string BadConfigFile = "Plik konfiguracyjny zawiera błędne dane.";
        public const string StationNoFound = "Ta stacja nie została dodana do bazy. Skontaktuj się z Administratorem.";
        public const string DenyAccessToStation = "Nie masz uprawnień do korzystania z tej stacji. Skontaktuj się z Administratorem.";
        public const string OpenLastSession = "Ostatnia sesja nie została prawidłowo zakończona. Program zakończył ją automatycznie.";
        public const string DenyAccessToAdministrative = "Nie masz dostępu do sesji administratora.";
        public const string DBNoFound = "Połączenie z serwerem nie powiodło się. Skontaktuj się z Administratorem.";
        #endregion

        #region ConfigurationSelector
        public const string DeviceConnError = "Program nie mógł połączyć się z wybranym urządzeniem. Sprawdź czy urządzenie jest podłączone i odpowiednio skonfigurowane.";
        #endregion 

        #region ConfigSQL
        public const string BadConnectionString = "Wprowadzona ścieżka połączenia jest nieprawiłowa. Czy mimo to chcesz ją zapisać?";
        public const string ErrorCryptography = "Wystąpił błąd związany z funkcjami kryptograficznymi.";
        public const string FileWriteError = "Błąd zapisu pliku.";
        #endregion

        #region DeviceList
        public const string DeviceDeleteQuestion = "Czy na pewno chcesz usunąć to urządzenie?";
        public const string DeviceDeleteError = "Nie można usunąć urządzenia, ponieważ zostało już wykorzystane. Spróbuj usunąć możliwe powiązania, lub ustaw jako nieaktywne.";
        #endregion

        #region UserList
        public const string PasswordNoMatch = "Wprowadzone hasła nie zgadzają się.";
        public const string ChangedPassword = "Zmieniono hasło";
        public const string UserDeleteQuestion = "Czy na pewno chcesz usunąć tego użytkownika?";
        public const string UserDeleteError = "Nie można usunąć użytkownika, ponieważ rozpoczął już sesję. Spróbuj usunąć możliwe powiązania, lub zablokuj go.";
        public const string DeleteLAstUser = "Nie można usunąć użytkownika, ponieważ jest to ostatni użytkownik, który posiada uprawnienia zarządzania użytkownikami.";
        public const string UserAlready = "Użytkownik o takim loginie istnieje już w bazie.";
        #endregion

        #region StationList
        public const string StationDeleteQuestion = "Czy na pewno chcesz usunąć tę stację?";
        public const string StationDeleteError = "Nie można usunąć stacji, ponieważ została już wykorzystana. Spróbuj usunąć możliwe powiązania, lub ustaw jako nieaktywną.";
        #endregion

        #region UnitList
        public const string UnitDeleteQuestion = "Czy na pewno chcesz usunąć tę jednostkę?";
        public const string UnitDeleteError = "Nie można usunąć jednoski, ponieważ została już wykorzystana. Spróbuj usunąć możliwe powiązania.";
        #endregion

        #region CmdArchetypeList
        public const string CmdArchetypeDeleteQuestion = "Czy na pewno chcesz usunąć tę jednostkę?";
        public const string CmdArchetypeDeleteError = "Nie można usunąć jednostki, ponieważ została już wykorzystana. Spróbuj usunąć możliwe powiązania.";
        #endregion

        #region ConfigurationList
        public const string ConfigurationDeleteQuestion = "Czy na pewno chcesz usunąć tę konfigurację?";
        public const string ConfigurationDeleteError = "Nie można usunąć konfiguracji, ponieważ została już wykorzystana. Spróbuj usunąć możliwe powiązania, lub ustaw jako nieaktywną.";
        #endregion

        #region CommandList
        public const string CmdListDeleteQuestion = "Czy na pewno chcesz usunąć tę listę rozkazów?";
        public const string CmdListDeleteError = "Nie można usunąć listy rozkazów, ponieważ została już wykorzystana. Spróbuj usunąć możliwe powiązania, lub ustaw konfigurację jako nieaktywną.";
        public const string RepeatedNoInOrder = "Wykryto powtarzające się indeksy kolejności. Jest to dopuszczalne, lecz wykonanie rozkazów o tym samym indeksie może być różne od oczekiwań użytkownika.";
        public const string EmptyConfiguration = "Konfiguracje urządzeń nie zostały zdefiniowane. Nie można utworzyć listy rozkazów.";
        #endregion

        #region MainForm
        public const string CloseApplicationQuestion = "Czy na pewno chcesz zamknąć aplikację?";
        #endregion

        #region MeasureStation
        public const string ForceStopCycle = "Czy na pewno chcesz przerwać cykl pomiarowy? Spowoduje to pojawienie się błędnych i niekompletnych danych w bazie danych.";
        public const string DeviceBusy = "Nie można wykonać żądanej operacji. Urządzenie jest zajęte lub niedostępne.";
        public const string DeviceStateReady = "Gotowe do pracy";
        public const string DeviceStateDisconnect = "Urządzenie odłączone";
        public const string DeviceStateWorking = "Pracuje...";
        public const string DeviceStateNone = "Nieznany";
        #endregion
    }
}
