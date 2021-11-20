using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.TagHelpers
{
    [HtmlTargetElement("alert")]
    public class AlertTagHelpers : TagHelper
    {
        public string Color { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.Add("class", "alert alert-info");
        }
    }
}
