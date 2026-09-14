using Restaurant_Management.Models;

namespace Restaurant_Management.Utilities
{
    internal static class SessionManager
    {
        public static User CurrentUser { get; set; }
        public static void SessionLogin(User user)
        {
            CurrentUser = user;
        }
        public static bool IsLoggedIn()
        {
            return CurrentUser != null;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}
