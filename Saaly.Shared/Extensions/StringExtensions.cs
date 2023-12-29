namespace Saaly.Shared.Extensions
{
    public static class StringExtensions
    {
        public static string GenerateSlug(this string word)
        {
            var slug = "";
            slug = word.Replace(' ', '-').Replace("&", "and");
            return slug;
        }

        public static string GeneratedRedactedName(this string name, string firstName)
        {
            var redactedName = "";
            firstName = firstName.Contains(' ') ? firstName.Split(' ')[0] : firstName;
            redactedName = $@"{firstName}. {name?.Substring(0, 1)?.ToUpper() ?? ""}";
            return redactedName;
        }

        public static string GetInitials(this string name)
        {
            // StringSplitOptions.RemoveEmptyEntries excludes empty spaces returned by the Split method

            string[] nameSplit = name.Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);

            string initials = "";

            foreach (string item in nameSplit)
            {
                initials += item.Substring(0, 1).ToUpper();
            }

            return initials;
        }
    }
}
