using System.ComponentModel;

namespace Saaly.Claims
{
    public static class SaalyClaimConstants
    {
        [Description(""), Category("Profile")]
        public const string AdminProfileView = "AdminProfileView";
        [Description(""), Category("Profile")]
        public const string AdminProfileEdit = "AdminProfileEdit";
        [Description(""), Category("Profile")]
        public const string ProfileView = "ProfileView";
        [Description(""), Category("Profile")]
        public const string ProfileEdit = "ProfileEdit";
        [Description(""), Category("Profile")]
        public const string DashboardView = "DashboardView";
        [Description(""), Category("Profile")]
        public const string WaiterDashboardView = "WaiterDashboardView";
        [Description(""), Category("Profile")]
        public const string SettingsView = "SettingsView";

        [Description(""), Category("Settings")]
        public const string PayoutView = "PayoutView";
        [Description(""), Category("Settings")]
        public const string PayoutList = "PayoutList";
        [Description(""), Category("Settings")]
        public const string ThemeView = "ThemeView";
        [Description(""), Category("Settings")]
        public const string SystemUsersList = "SystemUsersList";

        [Description(""), Category("Users")]
        public const string UsersView = "UsersView";
        [Description(""), Category("Users")]
        public const string UsersCreate = "UsersCreate";
        [Description(""), Category("Users")]
        public const string UsersEdit = "UsersEdit";
        [Description(""), Category("Users")]
        public const string UsersDelete = "UsersDelete";
        [Description(""), Category("Users")]
        public const string UsersList = "UsersList";

        [Description(""), Category("Audits")]
        public const string AuditsView = "AuditsView";
        [Description(""), Category("Audits")]
        public const string AuditsCreate = "AuditsCreate";
        [Description(""), Category("Audits")]
        public const string AuditsEdit = "AuditsEdit";
        [Description(""), Category("Audits")]
        public const string AuditsDelete = "AuditsDelete";
        [Description(""), Category("Audits")]
        public const string AuditsList = "AuditsList";
    }
}
