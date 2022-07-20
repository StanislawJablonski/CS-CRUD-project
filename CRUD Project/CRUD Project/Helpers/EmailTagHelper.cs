using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CRUD_Project.Helpers
{
    public class EmailTagHelper : TagHelper
    {
        private const string EmailDomain = "gmail.com";
        public string MailTo { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var address = MailTo + "@" + EmailDomain;
            output.Attributes.SetAttribute("href", "mailto:" + address);
            output.Content.SetContent(address);
        }
    }
}