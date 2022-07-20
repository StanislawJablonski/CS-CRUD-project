using System.Text;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CRUD_Project.Helpers
{
    namespace LibraryWebApp.TagHelpers
    {
        [HtmlTargetElement("welcome-tag-helper")]
        public class WelcomeTagHelper : TagHelper
        {
            public string Name { get; set; }
            public override void Process(TagHelperContext context, TagHelperOutput output)
            {
                output.TagName = "WelcomeTagHelper";
                output.TagMode = TagMode.StartTagAndEndTag;

                var sb = new StringBuilder();
                var et = Name.IndexOf("@");
                var substr = Name.Substring(0, et);
                
                sb.AppendFormat("<span>Hello {0}!</span>", substr);

                output.PreContent.SetHtmlContent(sb.ToString());
            }
        }
    }
}