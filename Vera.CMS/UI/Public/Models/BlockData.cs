using System;
using Vera.CMS.Application.Utils;

namespace Vera.CMS.UI.Public.Models
{
    public class BlockData
    {
        public string Text { get; set; }
        public int Level { get; set; }
        public string[] Items { get; set; }
        private string _code;
        public string Code
        {
            get => CleanCode(_code);
            set => _code = CleanCode(value);
        }

        public string Language { get; set; }

        private string CleanCode(string value)
        {
            return Language switch
            {
                "cs" => StringUtils.StripHtml(value),
                _ => value
            };
        }
    }
}