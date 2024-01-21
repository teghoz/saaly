using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Saaly.Shared.Helpers
{
    public static class StatusHelper
    {
        public static string Feedbacks(Action<FeedbackModel> model)
        {
            var options = new FeedbackModel();
            options.Messages = new List<string?>();

            model?.Invoke(options);
            options.AlertClass = AlertClass(options.Type);
            return JsonConvert.SerializeObject(options);
        }

        public static string AlertClass(eStatusType type)
        {
            var alertClass = "";
            switch (type)
            {
                case eStatusType.Success:
                    alertClass = "success";
                    break;
                case eStatusType.Secondary:
                    alertClass = "secondary";
                    break;
                case eStatusType.Warning:
                    alertClass = "warning";
                    break;
                case eStatusType.Primary:
                    alertClass = "primary";
                    break;
                case eStatusType.Error:
                    alertClass = "danger";
                    break;
                case eStatusType.Dark:
                    alertClass = "dark";
                    break;
                case eStatusType.Information:
                    alertClass = "info";
                    break;
                case eStatusType.Light:
                    alertClass = "light";
                    break;
                default:
                    alertClass = "danger";
                    break;
            }
            return alertClass;
        }
    }
}