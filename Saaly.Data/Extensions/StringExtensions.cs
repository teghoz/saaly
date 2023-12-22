using Microsoft.EntityFrameworkCore;
using Saaly.Models.Bases;

namespace Saaly.Data.Extensions
{
    public static class StringExtensions
    {
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
        public static async Task<string> GenerateCode<T>(this string value, DbSet<T> db, string prefix, string name, bool showInitial = false)
            where T : SaalyBase
        {
            var code = "";
            var totalCount = await db.AsNoTracking().CountAsync();
            var max = totalCount > 0 ? await db.AsNoTracking().MaxAsync(c => c.Id) : totalCount;
            var lastCount = (totalCount) > 0 ? max + 1 : 1;
            var initials = showInitial ? GetInitials(name).ToUpper() : "";
            code = $"{prefix}{initials}{lastCount.ToString("0000000")}";
            return code;
        }
    }
}
