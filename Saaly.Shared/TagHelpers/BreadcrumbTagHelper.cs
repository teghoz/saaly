using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

namespace Saaly.Shared.TagHelpers
{
    public class BreadcrumbTagHelper : TagHelper
    {
        private readonly IUrlHelper _urlHelper;

        public BreadcrumbTagHelper(IUrlHelper urlHelper)
        {
            _urlHelper = urlHelper;
        }

        public string? NavClass { get; set; } = "flex-shrink-0 mt-3 mt-sm-0 ms-sm-3";
        public string? ListClass { get; set; } = "breadcrumb breadcrumb-alt";
        public CrumbList Crumbs { get; set; }

        [ViewContext]
        public ViewContext ViewContext { set; get; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var builder = new StringBuilder();
            builder.Append($"<nav class='{NavClass}' aria-label='breadcrumb'>");
            builder.Append($"<ol class='{ListClass}'>");

            foreach (var item in Crumbs.Items.OrderBy(i => i.Order))
            {
                if (item.HasAriaCurrent)
                {
                    builder.Append(MakeListItem(item));
                }
                else
                {
                    if (item.HasLink)
                    {
                        var link = $"<a class='{item.LinkClass}' href='{item.Url}'>{item.Label}</a>";
                        builder.Append(MakeListItem(item, link));
                    }
                    else
                    {
                        builder.Append(MakeListItem(item));
                    }
                }
            }

            builder.Append("</ol>");
            builder.Append("</nav>");
            output.Content.SetHtmlContent(builder.ToString());
            output.Attributes.Clear();
        }

        private string MakeListItem(ListItem item, string? content = null)
        {
            var listAttributes = item.HasAriaCurrent ? $"aria-current='{item.AriaCurrent}'" : string.Empty;
            var listTemplates = $"<li class='{item.ClassName}' ${listAttributes}>{content ?? item.Label}</li>";
            return listTemplates;
        }
    }
}