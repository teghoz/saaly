using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

namespace Saaly.Shared.TagHelpers
{
    public class FeedbackTagHelper : TagHelper
    {
        private readonly IUrlHelper _urlHelper;

        public FeedbackTagHelper(IUrlHelper urlHelper)
        {
            _urlHelper = urlHelper;
        }
        /// <summary>
        /// Guid is required and is a reference to the resource we need to update
        /// </summary>
        public Guid Guid { get; set; }

        public string ButtonStyle { get; set; } = "";
        /// <summary>
        /// This is the edit text or label on the button.
        ///
        /// Default is 'Edit'
        /// </summary>
        public string EditText { get; set; } = "Edit";

        /// <summary>
        /// This is the edit Url on the button.
        ///
        /// Default is './Edit'
        /// </summary>
        public string EditUrl { get; set; } = "./Edit";

        /// <summary>
        /// This is the Detail text or label on the button.
        ///
        /// Default is 'Detail'
        /// </summary>
        public string DetailsText { get; set; } = "Detail";

        /// <summary>
        /// This is the Detail Url for the button.
        ///
        /// Default is './Details'
        /// </summary>
        public string DetailsUrl { get; set; } = "./Details";

        /// <summary>
        /// This is the delete text or label on the button.
        ///
        /// Default is 'Delete'
        /// </summary>
        public string DeleteText { get; set; } = "Delete";

        /// <summary>
        /// This is the delete Url for the button.
        ///
        /// Default is 'Delete'
        /// </summary>
        public string DeleteUrl { get; set; } = "./Delete";

        /// <summary>
        /// This is used to show the edit button.
        ///
        /// Default is 'true'
        /// </summary>
        public bool ShowEdit { get; set; } = true;

        /// <summary>
        /// This is used to show the details button.
        ///
        /// Default is 'true'
        /// </summary>
        public bool ShowDetails { get; set; } = true;

        /// <summary>
        /// This is used to show the delete button.
        ///
        /// Default is 'true'
        /// </summary>
        public bool ShowDelete { get; set; } = true;
        /// <summary>
        /// This is used to show the edit button.
        ///
        /// Default is 'true'
        /// </summary>
        public bool ShowEditText { get; set; } = false;

        /// <summary>
        /// This is used to show the details button.
        ///
        /// Default is 'true'
        /// </summary>
        public bool ShowDetailText { get; set; } = false;

        /// <summary>
        /// This is used to show the delete button.
        ///
        /// Default is 'true'
        /// </summary>
        public bool ShowDeleteText { get; set; } = false;

        [ViewContext]
        public ViewContext ViewContext { set; get; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var builder = new StringBuilder();
            builder.Append($@"<div class='btn-group'>");
            if (ShowEdit)
            {
                if (ShowEditText)
                {
                    builder.Append($@"<a href='{_urlHelper.Page(EditUrl, new { Guid })}' class='btn btn-sm btn-alt-secondary'>{IconGenerator("edit")} {EditText}</a>");
                }
                else
                {
                    builder.Append($@"<a href='{_urlHelper.Page(EditUrl, new { Guid })}' class='btn btn-sm btn-alt-secondary'>{IconGenerator("edit")}</a>");
                }
            }

            if (ShowDetails)
            {
                if (ShowDetailText)
                {
                    builder.Append($@" <a href='{_urlHelper.Page(DetailsUrl, new { Guid })}' class='btn btn-sm btn-alt-secondary'>{IconGenerator("detail")} {DetailsText}</a>");
                }
                else
                {
                    builder.Append($@" <a href='{_urlHelper.Page(DetailsUrl, new { Guid })}' class='btn btn-sm btn-alt-secondary'>{IconGenerator("detail")}</a>");
                }
            }

            if (ShowDelete)
            {
                if (ShowDeleteText)
                {
                    builder.Append($@" <a href='{_urlHelper.Page(DeleteUrl, new { Guid })}' class='btn btn-sm btn-alt-secondary'>{IconGenerator("delete")} {DeleteText}</a>");
                }
                else
                {
                    builder.Append($@" <a href='{_urlHelper.Page(DeleteUrl, new { Guid })}' class='btn btn-sm btn-alt-secondary'>{IconGenerator("delete")}</a>");
                }
            }

            builder.Append($@"</div>");
            output.Content.SetHtmlContent(builder.ToString());
            output.Attributes.Clear();
        }

        private string IconGenerator(string type)
        {
            var icon = type switch
            {
                "edit" => "fa fa-fw fa-pencil-alt",
                "detail" => "fa fa-fw fa-eye",
                "delete" => "fa fa-fw fa-times",
                _ => ""
            };
            return $"<i class='{icon}' aria-hidden='true'></i>";
        }
    }
}
