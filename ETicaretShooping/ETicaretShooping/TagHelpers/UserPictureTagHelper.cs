using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.TagHelpers
{
    public class UserPictureTagHelper : TagHelper
    {
        public string ImageURL { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "img";

            if (string.IsNullOrEmpty(ImageURL))
            {
                output.Attributes.SetAttribute("src", "/userimages/defaultpicture.png");
            }
            else

            {
                output.Attributes.SetAttribute("src", $"/userimages/{ImageURL}");
            }
        }
    }
}
