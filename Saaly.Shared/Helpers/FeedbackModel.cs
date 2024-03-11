using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Saaly.Shared.Helpers
{
    public class FeedbackModel
    {
        public eFeedbackType FeedbackType { get; set; }
        public eStatusType Type { get; set; }
        public List<string?> Messages { get; set; }
        public ModelStateDictionary? ModelState { get; set; }
        public string? AlertClass { get; set; }
    }
}
