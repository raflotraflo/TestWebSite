using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebSite.Models
{
    public class DropDownItem
    {
        public DropDownItem(int value, string display)
        {
            Value = value;
            Display = display;
        }

        public int Value { get; set; }
        public string Display { get; set; }
    }
}