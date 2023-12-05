using Saaly.Models.Bases;
using Saaly.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models.EntityModels
{
    public class EntityLocation : EntityBase
    {
        public string? Title { get; set; }
        public string? Slug { get; set; }
        public Guid? ParentGuid { get; set; }
        public eLocationDepth Depth { get; set; }
        public int SortOrder { get; set; }
        public string? MapData { get; set; }
        [ForeignKey("ParentGuid")]
        public virtual EntityLocation? Parent { get; set; }
        public string GetLocation()
        {
            var fullLocation = Parent?.Title ?? string.Empty;
            var locationObj = Parent;

            while (locationObj != null)
            {
                locationObj = locationObj.Parent;
                if (locationObj is not null)
                {
                    fullLocation += $", {locationObj.Title}";
                }
                else
                {
                    fullLocation = fullLocation.TrimEnd();
                    fullLocation = $@"{fullLocation}.";
                }
            }
            return fullLocation;
        }
    }
}